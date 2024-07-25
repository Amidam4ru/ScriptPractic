using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling : MonoBehaviour
{
    [SerializeField] private Vector3 _scalingDirection;
    [SerializeField] private float _scalingSpeed;

    private void Start()
    {
        
    }

    private void Update()
    {
        transform.localScale = Vector3.MoveTowards(transform.localScale, _scalingDirection, _scalingSpeed * Time.deltaTime);
    }
}
