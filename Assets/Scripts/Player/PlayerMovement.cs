using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 1f;
    [SerializeField] private Rigidbody _player;
    private float _horizontalInput;
    [SerializeField] private float _horizontalMultiplier = 2f;

    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _fixedMovement();
    }

    private void _fixedMovement()
    {
        Vector3 moveForward = transform.forward * _movementSpeed * Time.fixedDeltaTime;
        Vector3 moveHorizontal = transform.right * _horizontalInput * _movementSpeed * Time.fixedDeltaTime * _horizontalMultiplier;
        _player.MovePosition(_player.position + moveForward + moveHorizontal);
    }
}
