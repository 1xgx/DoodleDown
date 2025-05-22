using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Platform : MonoBehaviour, IMoveable, ISpeedable
{
    [Header ("Base Parametrs")]
    [SerializeField] private TypeOfObject _type;
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _position;
    public TypeOfObject Type => _type;


    private void Update()
    {
        Move();
        DeletePlatform();
    }
    private void Move()
    {
        transform.Translate(Vector3.up * Time.deltaTime * _speed);
    }
    public void SetSpeed(float speed)
    {
        _speed = speed;
    }
    public void GetPosition(Vector3 position)
    {
        _position = position;
    }
    private void DeletePlatform()
    {
        if (transform.position.y > 20.0f) Destroy(gameObject);
    }
}
