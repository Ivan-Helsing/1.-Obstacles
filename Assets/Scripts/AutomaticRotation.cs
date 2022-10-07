using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticRotation : MonoBehaviour
{
    [SerializeField] float speed = 10f;

    float rotationValue;

    void Start()
    {
        
    }

    void Update()
    {
        rotationValue = speed * Time.deltaTime;
        transform.Rotate(0f, 0f, rotationValue);
    }
}
