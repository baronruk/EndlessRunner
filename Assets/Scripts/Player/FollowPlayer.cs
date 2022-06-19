using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform _player;

    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, _player.position.z);
    }
}
