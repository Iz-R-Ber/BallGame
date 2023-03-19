using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomColiderScrip : MonoBehaviour
{
    public bool atfeet;
    
    private void OnTriggerEnter(Collider other) {
        atfeet = true;
        Debug.Log("Atfeet");
    }
    
    private void OnTriggerExit(Collider other) {
        atfeet = false;
    }
}
