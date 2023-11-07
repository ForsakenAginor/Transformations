using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover: MonoBehaviour
{
    [SerializeField] private float _xSpeed;

    private void Update()
    {
        transform.Translate(_xSpeed * Time.deltaTime, 0, 0);
    }
}
