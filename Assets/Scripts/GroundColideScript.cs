using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColideScript : MonoBehaviour
{
    public bool inAir;

    void Start()
    {
        inAir = false;
    }

    private void OnTriggerEnter(Collider other) {
        inAir = false;
        //Debug.Log("Trigger enter");
    }
    private void OnTriggerExit(Collider other) {
        inAir = true;
        Debug.Log("Jump");
    }
}
