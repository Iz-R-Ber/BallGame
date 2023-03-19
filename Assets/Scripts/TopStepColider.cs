using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopStepColider : MonoBehaviour
{
    public bool tooHigh;
    private void OnTriggerEnter(Collider other) {
        tooHigh = true;
        Debug.Log("TooHigh");
    }
    private void OnTriggerExit(Collider other) {
        tooHigh = false;
    }
}
