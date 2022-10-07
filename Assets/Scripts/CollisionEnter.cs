using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CollisionEnter : MonoBehaviour
{
    public GameObject stepVFX;
    public Transform spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collided with " + other.gameObject.name);

        if (other.gameObject.tag == "Ground")
        {
            Instantiate(stepVFX, spawnPoint);
        }
    }
}
