using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScrpit : MonoBehaviour
{
    private float dammage = 1;
    public bool isActive = false;
    public List<AliveScrpipt> targetlist= new List<AliveScrpipt>();  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void Attack()
	{
		
	}
	private void OnTriggerEnter(Collider other)
	{
        if (other.gameObject.TryGetComponent<AliveScrpipt>(out AliveScrpipt target)) {
            target.TakeDamage(dammage);
        }   
	}
}
