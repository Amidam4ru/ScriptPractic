using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling : MonoBehaviour
{
    [SerializeField] private Vector3 _scalingAxis;
    [SerializeField] private float _scalingSpeed;

    private void Update()
    {
        transform.localScale = Vector3.MoveTowards(transform.localScale, _scalingAxis, _scalingSpeed * Time.deltaTime);
    }
}
