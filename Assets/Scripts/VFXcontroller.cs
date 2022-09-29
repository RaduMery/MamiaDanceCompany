using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXcontroller : MonoBehaviour
{
    public VelocityCounter velocityCounter;

    private void Start()
    {
        velocityCounter.OnMove += Moved;
    }

    private void OnDestroy()
    {
        velocityCounter.OnMove -= Moved;
    }

    void Moved(float speed)
    {
        
    }

}
