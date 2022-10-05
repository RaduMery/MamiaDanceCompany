using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class VFXcontroller : MonoBehaviour
{
    public VelocityCounter velocityCounter;

    //SerializeField[GameObject]
    public ParticleSystem vfx;
    public Transform elbowR;

    private void Start()
    {
        velocityCounter.OnMove += Moved;
    }

    private void OnDestroy()
    {
        velocityCounter.OnMove -= Moved;
    }

    void Moved(Vector3 velocity)
    {
        // do something else. Do not instantiate.

        Instantiate(vfx, elbowR.position + new Vector3(0,1,0),Quaternion.identity);
        Debug.Log(velocityCounter.velocity.magnitude);

    }

}