using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _objectsReference;
    [SerializeField] private Vector3 _objectOffset;
    [SerializeField] private float _objectSpeed;
    [SerializeField] private float _delay = 1.0f;
    private void Start()
    {
        StartCoroutine(SpawnCoroutine());
    }
    private void ObjectSpawn()
    {
        int index = Random.Range(0, _objectsReference.Count);
        float X = Random.Range(-2.9f, 2.9f);
        _objectOffset = new Vector3(X, 1.0f, 0);
        GameObject newObject = Instantiate(_objectsReference[index], _objectOffset, Quaternion.identity);
        newObject.GetComponent<ISpeedable>().SetSpeed(_objectSpeed); // Test
        
    }
    IEnumerator SpawnCoroutine() 
    {
        while (true) 
        {
            yield return new WaitForSeconds(_delay);
            ObjectSpawn();
        }
    }
}
