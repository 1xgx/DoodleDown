using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;


public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _objectsReference;
    [SerializeField] private float _delay = 1.0f;
    [SerializeField] private Coroutine _coroutine;
    [SerializeField] private Transform _player;
    public Platform _firstPlatform;
    public List<Platform> SpawnedPlatforms;
    public bool isSpawn = false;
    [SerializeField] private float distanceBetweenPlayerAndFuturePlatform = 20f;
    [Tooltip ("Range of X")]
    [SerializeField]private Vector2 _rangeOfX = new Vector2(-2.9f, 2.9f);
    [Tooltip("Range of Y when platform instantiate")]
    [SerializeField] private float _heightOfY;
    private void Start()
    {
        SpawnedPlatforms.Add(_firstPlatform);
    }
    private void LateUpdate()
    {
        if(isSpawn) if (_player.position.y < SpawnedPlatforms[SpawnedPlatforms.Count - 1].Bottom.position.y) ObjectSpawn();
    }
    private void ObjectSpawn()
    {
        int index = Random.Range(0, _objectsReference.Count);
        float X = Random.Range(_rangeOfX.x, _rangeOfX.y);
        Platform newObject = Instantiate(_objectsReference[index]).GetComponent<Platform>();
        Transform newTransform = newObject.transform;
        newTransform.position = new Vector3(X, _player.position.y - newObject.Bottom.localPosition.y - _player.position.normalized.y - _heightOfY, 0);
        SpawnedPlatforms.Add(newObject);
        if(SpawnedPlatforms.Count > 5)
        {
            Destroy(SpawnedPlatforms[0].gameObject);
            SpawnedPlatforms.RemoveAt(0);
        }
    }
}
