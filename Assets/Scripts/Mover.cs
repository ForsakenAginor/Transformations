using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover: MonoBehaviour
{
    [SerializeField] private float _xSpeed;
    [SerializeField] private float _ySpeed;
    [SerializeField] private float _zSpeed;

    private void Update()
    {
        transform.Translate(_xSpeed * Time.deltaTime, _ySpeed * Time.deltaTime, _zSpeed * Time.deltaTime);
    }
}
