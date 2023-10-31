using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        float _scalePerFrame = _speed * Time.deltaTime;
        float maxScale = 3;
        float minScale = 0.1f;
        transform.localScale += new Vector3(_scalePerFrame, _scalePerFrame, _scalePerFrame);

        if (transform.localScale.x >= maxScale || transform.localScale.x <= minScale)
            _speed *= -1;
    }
}
