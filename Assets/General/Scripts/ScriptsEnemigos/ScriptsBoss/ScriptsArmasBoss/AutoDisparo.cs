using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDisparo : MonoBehaviour {

    
    public Transform Disparador;
    public GameObject Proyectil;
    private float timePassed = 0f;
    public float delay = 0.2f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        timePassed += Time.deltaTime;

        if (timePassed > delay)
        {
            Invoke("Disparar", 0);
            timePassed = 0f;


        }


    }




    void Disparar()
    {

        
            Instantiate(Proyectil, Disparador.position, Disparador.rotation);

        }
    }
