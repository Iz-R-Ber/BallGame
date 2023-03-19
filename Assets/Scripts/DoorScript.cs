using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject camObjPos;
    public Playerscript playerScript;
    public Camera CameracamCamera;
    public bool imActive, inTrigg, inBox;
    // Start is called before the first frame update
    void Start()
    {
        imActive = false;
        inTrigg= false;
        inBox = false;
    }

    // Update is called once per frame
    void Update() {
        //camra controles
        if(imActive) {
            CameracamCamera.transform.position = camObjPos.transform.position;
            CameracamCamera.transform.rotation = camObjPos.transform.rotation;
        }
        // interaction check
        if(inTrigg && playerScript.interactionAsk)
        {
            if (!imActive) { 
                //Set the tool bools
                playerScript.indoors = true; playerScript.interactionAsk = false;
                //Active bools 
                imActive = true;
            }
            else {
                //Set the tool bools
                playerScript.indoors = false; playerScript.interactionAsk = false;
                //Active bools 
                imActive = false;
            }
        }
        
    }

    //ontigger
    private void OnTriggerEnter(Collider other)
    {
        inTrigg= true;
        
    }
    private void OnTriggerExit(Collider other)
    {
        inTrigg= false;
    }
}
