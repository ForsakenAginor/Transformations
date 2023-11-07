using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _ySpeed;

    private void Update()
    {
        transform.Rotate(0, _ySpeed * Time.deltaTime, 0);
    }
}
