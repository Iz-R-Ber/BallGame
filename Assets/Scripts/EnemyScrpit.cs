using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class EnemyScrpit : MonoBehaviour
{
    public float health = 1;
    public float maxHealth = 10;
    public bool isAlive = true;
    private bool unbead = false;
    private float mortality = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        life();
    }

    private void life() {
        
        if(health < 0)
            isAlive= true;
        if (health < -maxHealth * mortality) {
            isAlive = false; 
        }
        if(!isAlive && mortality > 1){
            mortality -= 1; 
            isAlive= true;
        }
        if (!isAlive) {
            Destroy(gameObject);
        }
    }
}
