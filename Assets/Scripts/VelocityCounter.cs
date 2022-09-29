using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class VelocityCounter : MonoBehaviour
{

    public Vector3 velocity;
    private Vector3 previousPosition;

    public float miniumMovementTolerance;
    public event Action<float> OnMove;

    private void Start()
    {
        previousPosition = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        velocity = transform.position - previousPosition;
        if (velocity.magnitude > miniumMovementTolerance)
        {
            OnMove?.Invoke(velocity.magnitude);
        }
        previousPosition = transform.position;
    }

}
