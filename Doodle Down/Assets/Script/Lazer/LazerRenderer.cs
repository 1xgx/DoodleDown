using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class LazerRenderer : MonoBehaviour
{
    private Camera _mainCamera;
    private TrailRenderer _trail;
    private MobileInputActions _actions;
    [SerializeField] private bool _isMove = false;
    [SerializeField] private Player _player;
    private void Awake()
    {
        _mainCamera = Camera.main;
        _trail = GetComponent<TrailRenderer>();
        _actions = new MobileInputActions();
        _trail.enabled = false;
    }
    private void OnEnable()
    {
        _actions.Enable();
        _actions.Action.Pressed.started += OnPerformed;
        _actions.Action.Pressed.canceled += OnPerformed;
    }
    private void OnDisbale()
    {
        _actions.Disable();
        _actions.Action.Pressed.performed -= OnCancled;
        _actions.Action.Pressed.canceled -= OnCancled;
    }
    private void OnPerformed(InputAction.CallbackContext context)
    {
        _isMove = !_isMove;
    }
    private void OnCancled(InputAction.CallbackContext context)
    {
        _isMove = false;
    }
    private void Update()
    {
        if (_isMove) setTrail();
    }
    public void setTrail()
    {
        _trail.enabled = _isMove;
        Vector2 screenPosition = _actions.Action.Player.ReadValue<Vector2>();
        Vector3 targetPosition = _mainCamera.ScreenToWorldPoint(new Vector3(screenPosition.x, screenPosition.y, 0.0f));
        targetPosition.z = 0.0f;
        transform.position = targetPosition;
        _player.setTarget(targetPosition);
    }

}
