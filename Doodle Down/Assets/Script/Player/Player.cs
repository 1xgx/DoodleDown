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
    [SerializeField] private float _freezeOffsetY = -.5f;
    private Vector3 _targetPosition = Vector3.zero;
    private Vector3 _startPosition;
    public bool IsMove = false;

    private void Awake()
    {
        _startPosition = transform.position;
        _rigidbody2D = GetComponent<Rigidbody2D>();
        mainCamera = Camera.main;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)) transform.position = _startPosition;
        if (_targetPosition == Vector3.zero) return;
        if (_targetPosition != null) Move(_speed,_targetPosition);
        CameraMove();
    }
    public void setTarget(Vector3 position)
    {
        _targetPosition = position;
    }
    private void Move(float speed, Vector3 _targetPosition)
    {
        IsMove = true;
        transform.position = Vector3.Lerp(transform.position, new Vector2(_targetPosition.x, transform.position.y), speed * Time.deltaTime);
    }
    private void CameraMove()
    {
        Transform camera = mainCamera.GetComponent<Transform>();
        camera.position = new Vector3(camera.position.x, transform.position.y+-4.5f, camera.position.z);
    }
}
