using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    public bool collided = false;
    private void OnTriggerEnter(Collider other)
    {
        collided= true;
    }
    private void OnTriggerExit(Collider other)
    {
        collided= false;
    }
}
