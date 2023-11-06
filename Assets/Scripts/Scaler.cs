using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;
    [SerializeField] private float _maxScale;
    [SerializeField] private float _minScale;

    private void Update()
    {
        transform.localScale += Vector3.one * _scaleSpeed * Time.deltaTime;

        if (transform.localScale.x >= _maxScale || transform.localScale.x <= _minScale)
            _scaleSpeed *= -1;
    }
}
