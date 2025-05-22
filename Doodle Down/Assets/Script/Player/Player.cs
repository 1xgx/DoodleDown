using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Rigidbody _playerRB;
    [SerializeField] private float _jumpForce = 2.0f;
    [Header ("InputAction")]
    [SerializeField] private MobileInputActions _action;
    [SerializeField] private float _speed;
    [SerializeField] private bool _isPressed = false;
    [SerializeField] private float _direction = 1;
    private void Awake()
    {
        _action = new MobileInputActions();
    }
    private void Start()
    {
        _action = new MobileInputActions();
        _playerRB = GetComponent<Rigidbody>();
        Jump();
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) Jump();
        if(_isPressed) Move(_direction);
    }
    private void OnEnable()
    {
        _action.Enable();
        _action.Action.TurnLeftorRight.started += OnTurnPerformed;
        _action.Action.TurnLeftorRight.canceled += OnTurnCanceled;
        _action.Action.TurnRight.started += OnTurnPerformed;
        _action.Action.TurnRight.canceled += OnTurnCanceled;
    }
    private void OnDisable()
    {
        _action.Action.TurnLeftorRight.started -= OnTurnPerformed;
        _action.Action.TurnLeftorRight.canceled -= OnTurnCanceled;
        _action.Disable();
    }
    private void OnTurnPerformed(InputAction.CallbackContext context)
    {
        if (!_isPressed)
        {
            _isPressed = true;
        }
        //transform.Translate()
    }
    private void OnTurnCanceled(InputAction.CallbackContext context)
    {
        if (_isPressed)
        {
            _isPressed = false;
        }
        Debug.Log("turnLeftUnClick");
    }
    private void Jump()
    {
        _playerRB.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
    }
    private void Move(float direction)
    {
        transform.Translate(Vector3.left * direction * _speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<Platform>())
        {
            Platform newPlatform = collision.collider.GetComponent<Platform>();
            Debug.Log($"You are jumping right here {newPlatform.Type} !");
            Jump();
        }
    }

}
