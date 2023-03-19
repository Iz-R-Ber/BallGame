using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_sprite : MonoBehaviour
{
    //Variables I know do what
    public PersonData playerData;
    private Vector3 camOffset;
    public Playerscript playerScrpit;
    public float camMov = 2.0f, tollarence = 10, ytollarence, Ltollarence, LMovment;
    

    //ssomething idk
    [SerializeField] private Transform target;
    [SerializeField] private float smoothtime;
    private Vector3 currentV = Vector3.zero;

    // Start is called before the first frame update
    public bool lookAttarget = false;
    private void Awake()
    {
        camOffset = transform.position - target.position;    
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosision = target.position + camOffset;
        if (!playerScrpit.indoors)
            MoveCamraTo(newPosision, camMov, tollarence, ytollarence, Ltollarence, LMovment);
            //MoveCamraTo(newPosision, camMov, tollarence);

		if (lookAttarget)
		{
			transform.LookAt(target);
		}
	}

    private void LateUpdate()
    {
        //if (!playerScrpit.indoors) {
            //Vector3 newPosision = target.position + camOffset;

            //Unity's Campra
            //transform.position = Vector3.SmoothDamp(transform.position, targetpos, ref currentV, smoothtime);
            //transform.position = Vector3.Slerp(transform.position, newPosision, smoothtime);

            //Default cam follow
            //transform.position = newPosision;

            //Testing
            /*
               */

        //}
    }

    private void FixedUpdate()
    {
       
    }

    private Vector3 PosDiff;
    private void MoveCamraTo(Vector3 target, float speed, float tollarence) {
        //if (target != transform.position)
        PosDiff = target - transform.position;
        speed = speed / 1000;
        //Y
        if (PosDiff.x > tollarence)
            transform.position += new Vector3(speed, 0.0f, 0.0f);
        else if (PosDiff.x < -tollarence)
            transform.position -= new Vector3(speed, 0.0f, 0.0f);
            
        //X
        if (PosDiff.y > tollarence) 
            transform.position += new Vector3(0.0f, speed, 0.0f);
        else if (PosDiff.y < -tollarence) 
            transform.position -= new Vector3(0.0f, speed, 0.0f);
            
        //Z
        if (PosDiff.z > tollarence) 
            transform.position += new Vector3(0.0f, 0.0f, speed);
        else if (PosDiff.z < -tollarence) 
            transform.position -= new Vector3(0.0f, 0.0f, speed);
            
        
    }

	private void MoveCamraTo(Vector3 target, float speed, float tollarence, float ytollarence, float Ltollarene, float Lspeed)
	{
		//if (target != transform.position)
		PosDiff = target - transform.position;
		speed = speed / 1000;
        Lspeed = Lspeed / 1000;
        tollarence = tollarence / 10;
        ytollarence = ytollarence / 10;
        Ltollarene = Ltollarene / 10;
		//x
		if (PosDiff.x > tollarence)
			transform.position += new Vector3(speed, 0.0f, 0.0f);
		else if (PosDiff.x < -tollarence)
			transform.position -= new Vector3(speed, 0.0f, 0.0f);

		//y
		if (PosDiff.y > tollarence)
			transform.position += new Vector3(0.0f, speed, 0.0f);
		else if (PosDiff.y < -tollarence)
			transform.position -= new Vector3(0.0f, speed, 0.0f);

		//Z
		if (PosDiff.z > ytollarence)
			transform.position += new Vector3(0.0f, 0.0f, speed);
		else if (PosDiff.z < -tollarence)
			transform.position -= new Vector3(0.0f, 0.0f, speed);
        
        //x
		if (PosDiff.x > Ltollarene)
			transform.position += new Vector3(Lspeed, 0.0f, 0.0f);
		else if (PosDiff.x < -Ltollarene)
			transform.position -= new Vector3(Lspeed, 0.0f, 0.0f);

		//y
		if (PosDiff.y > Ltollarene)
			transform.position += new Vector3(0.0f, Lspeed, 0.0f);
		else if (PosDiff.y < -Ltollarene)
			transform.position -= new Vector3(0.0f, Lspeed, 0.0f);

		//Z
		if (PosDiff.z > ytollarence)
			transform.position += new Vector3(0.0f, 0.0f, Lspeed);
		else if (PosDiff.z < -Ltollarene)
			transform.position -= new Vector3(0.0f, 0.0f, Lspeed);


	}
}
