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
        float _scalePerFrame = _scaleSpeed * Time.deltaTime;
        transform.localScale += new Vector3(_scalePerFrame, _scalePerFrame, _scalePerFrame);

        if (transform.localScale.x >= _maxScale || transform.localScale.x <= _minScale)
            _scaleSpeed *= -1;
    }
}
