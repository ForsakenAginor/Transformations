using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeInOneCube : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _changeScaleSpeed;

    private void Awake()
    {
        _rigidbody.velocity = new Vector3(0, _movementSpeed, 0);
        _rigidbody.angularVelocity = new Vector3(0, _rotateSpeed, 0);
    }

    private void Update()
    {
        float _scalePerFrame = _changeScaleSpeed * Time.deltaTime;
        float maxScale = 3;
        float minScale = 0.1f;
        transform.localScale += new Vector3(_scalePerFrame, _scalePerFrame, _scalePerFrame);

        if (transform.localScale.x >= maxScale || transform.localScale.x <= minScale)
            _changeScaleSpeed *= -1;
    }
}
