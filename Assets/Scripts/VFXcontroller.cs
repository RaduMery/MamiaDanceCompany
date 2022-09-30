using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXcontroller : MonoBehaviour
{
    public VelocityCounter velocityCounter;

    //SerializeField[GameObject]
    public GameObject vfx;
    public Transform elbowR;

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
        Instantiate(vfx, elbowR.position + new Vector3(0,1,0),Quaternion.identity);
        Debug.Log(velocityCounter.velocity.magnitude);
    }

}
