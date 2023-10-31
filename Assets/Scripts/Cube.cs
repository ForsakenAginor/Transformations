using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speed;

    private void Awake()
    {
        _rigidbody.angularVelocity = new Vector3(0, _speed, 0);
    }
}
