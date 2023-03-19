using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerscript : MonoBehaviour
{
    //movement vaiables
    public Rigidbody mybody;
    public GameObject mybodyObject;
    Vector3 movment;
    //stats

    public float speed = 3, upspeed = 2, jumpforce = 3, stepForce = 3;
    
    //interaction objects
    public GroundColideScript jumpCheck;
    public TopStepColider topcplider;
    public BottomColiderScrip botCollider;

    //Status bools
    private bool jumpAsk;
    public bool indoors;
    public bool interactionAsk;
    private bool left;

    //Objects
    Camera Cameracam;
    //player data variables


    // Start is called before the first frame update
    void Start()
    {
        mybody.useGravity= false;
        jumpAsk = false;
        indoors = false;
        left = false;
    }

    // Update is called once per frame
    void Update()
    {
        //movement input
        movment.x = Input.GetAxisRaw("Horizontal");
        movment.y = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.Space)
            || Input.GetKeyDown("joystick button 0"))
            jumpAsk = true;

        if (Input.GetKeyDown(KeyCode.E)
           || Input.GetKeyDown("joystick button 2")) { 
            interactionAsk = true;
            Debug.Log("Interaction Ask");
           }

        DirectionCheck(mybodyObject);
		

	}

    private void FixedUpdate()
    {
        //movment
        if (movment.x > 0.1f || movment.x < -0.1) {
            mybody.AddForce(new Vector3((movment.x * speed), 0f), ForceMode.Impulse);
            if (movment.x < 0.1f)
                left = true;
            else if(movment.x > 0.1f)
				left = false;
		}
        if (movment.y > 0.1f || movment.y < -0.1) {
            mybody.AddForce(new Vector3(0f, 0f, (movment.y * upspeed)), ForceMode.Impulse);
        }
        //Jump
        if ( jumpAsk && !jumpCheck.inAir) {
            mybody.AddForce(new Vector3(0f, jumpforce, 0f), ForceMode.Impulse);
            jumpAsk = false;
        }
        //Envorement and stairs
        if (botCollider.atfeet && !topcplider.tooHigh && !jumpCheck.inAir) {
            mybody.AddForce(new Vector3(0f, stepForce, 0f), ForceMode.Impulse);
        }
        interactionAsk= false;
    }
	private void DirectionCheck(GameObject mybodyObject)
	{
		if (left) { mybodyObject.transform.localScale = new Vector3(-1.0f, 1f, 1f); }
		else { mybodyObject.transform.localScale = new Vector3(1.0f,1f,1f); }
	}
    public bool getLeft() {
    return left;
    }
}
