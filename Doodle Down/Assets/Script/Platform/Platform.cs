using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [Header ("Base Parametrs")]
    [SerializeField] private TypeOfObject _type;
    [SerializeField] private float _speed;
    [SerializeField] private Vector2 _position;
    public Transform Top;
    public Transform Bottom;
    public TypeOfObject Type => _type;
    public void GetPosition(Vector2 position)
    {
        _position = position;
    }
    private void DeletePlatform()
    {
        if (transform.position.y > 20.0f) Destroy(gameObject);
    }
}
