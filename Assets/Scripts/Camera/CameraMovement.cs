using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _player;
    private Vector3 _offset;
    void Start()
    {
        _offset = transform.position - _player.position;
    }

    void Update()
    {
        _followPlayer();
    }

    private void _followPlayer()
    {
        Vector3 targetPosition = _player.position + _offset;
        targetPosition.x = 0;
        transform.position = targetPosition;
    }
}
