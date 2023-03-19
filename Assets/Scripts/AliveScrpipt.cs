using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AliveScrpipt : MonoBehaviour
{

	public float health = 1;
	public float maxHealth = 10;
	public bool isAlive = true;
	private bool unbead = false;
	private float mortality = 0.5f;
	//bool colider
	private bool colide = false;
	private AttackScrpit takingDamage;

	// Start is called before the first frame update
	void Start()
    {
		health = maxHealth; 
    }

    // Update is called once per frame
    void Update()
    {
		life();
    }

	private void life()
	{

		if (health < 0)
			isAlive = true;
		else if (health < -maxHealth * mortality)
		{
			isAlive = false;
		}
		if (!isAlive && mortality > 1)
		{
			mortality -= 1;
			isAlive = true;
		}
		if (!isAlive)
		{
			Destroy(gameObject);
		}
	}

	public void TakeDamage(float dammage) {
	 health -= dammage;
	}


	private void OnTriggerEnter(Collider other)
	{
		other.GetComponent<AttackScrpit>();
		colide= true;
		//AttackScrpit.Attack();
	}
	private void OnTriggerExit(Collider other)
	{
		colide= false;
	}
}
