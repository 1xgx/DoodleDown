using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _playerRB;
    [SerializeField] private float _jumpForce = 2.0f;

    private void Start()
    {
        _playerRB = GetComponent<Rigidbody>();
        Jump();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) Jump();
    }
    private void Jump()
    {
        _playerRB.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<Platform>())
        {
            Platform newPlatform = collision.collider.GetComponent<Platform>();
            Debug.Log($"You are jumping right here {newPlatform} !");
            Jump();
        }
    }

}
