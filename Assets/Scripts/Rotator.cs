using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speedRotate;

    private void Update()
    {
        transform.Rotate(0, Time.deltaTime*_speedRotate, 0);
    }
}
