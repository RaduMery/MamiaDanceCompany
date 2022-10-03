using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class VFXcontroller : MonoBehaviour
{
    public VelocityCounter velocityCounter;

    //SerializeField[GameObject]
    public GameObject vfx;
    public Transform elbowR;

    private void Start()
    {
        velocityCounter.OnMove += Moved;
        //velocityCounter.MovementDicertion += CalculateMovementDirection;
    }

    private void OnDestroy()
    {
        velocityCounter.OnMove -= Moved;
        //velocityCounter.MovementDicertion -= CalculateMovementDirection;
    }

    void Moved(float speed)
    {
        //calculate movement direction and based on that instatiate

        Instantiate(vfx, elbowR.position + new Vector3(0,1,0),Quaternion.identity);
        Debug.Log(velocityCounter.velocity.magnitude);
    }

    //void CalculateMovementDirection()
    //{
    //}
}
