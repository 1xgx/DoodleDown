using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _speed = 5.0f;
    private Vector3 _targetPosition;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    private void Update()
    {
        if (_targetPosition != null) Move(_speed,_targetPosition);
    }
    
    private void Move(float speed, Vector3 _targetPosition)
    {
        transform.position = Vector3.Lerp(transform.position, new Vector2(_targetPosition.x, transform.position.y), speed * Time.deltaTime);
    }
    public void setTarget(Vector3 position)
    {
        _targetPosition = position;
    }
}
