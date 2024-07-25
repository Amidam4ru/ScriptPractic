using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _rotateDirection;
    [SerializeField] private float _speedRotate;
    private void Start()
    {
        
    }

    private void Update()
    {
        transform.Rotate(0, Time.deltaTime*_speedRotate, 0);
    }
}
