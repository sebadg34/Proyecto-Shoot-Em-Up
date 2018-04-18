using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparadorLaser : MonoBehaviour {

    public GameObject Proyectil1;
    public GameObject Proyectil2;
    public GameObject Proyectil3;
    public GameObject Proyectil4;
    public Transform Disparador;
    private float timePassed = 0f;
    public float delay = 0.2f;
    public int mejora = 1;

    // Use this for initialization
    void Start () {

        

    }
	
	// Update is called once per frame
	void Update () {

        timePassed += Time.deltaTime;

        if (Input.GetKey(KeyCode.Mouse0) && timePassed > delay)
        {
            Invoke("Disparar",0);
            AudioSource Disparo = GetComponent<AudioSource>();
           timePassed = 0f;
            Disparo.Play();
            
        }

        if (Input.GetKey(KeyCode.Alpha1)) //Mejora 1 con input 1
        {
            mejora = 1;
        }
        if (Input.GetKey(KeyCode.Alpha2)) //Mejora 2 con input 2
        {
            mejora = 2;
        }
        if (Input.GetKey(KeyCode.Alpha3)) //Mejora 3 con input 3
        {
            mejora = 3;
        }
        if (Input.GetKey(KeyCode.Alpha4)) //Mejora 4 con input 4
        {
            mejora = 4;
        }

    }

    void Disparar() {

        if (mejora == 1)
        {
            Instantiate(Proyectil1, Disparador.position, Disparador.rotation);
            
        }
        if (mejora == 2)
        {
            Instantiate(Proyectil2, Disparador.position, Disparador.rotation);
           
        }
        if (mejora == 3)
        {
            Instantiate(Proyectil3, Disparador.position, Disparador.rotation);
          
        }
        if (mejora == 4)
        {
            Instantiate(Proyectil4, Disparador.position, Disparador.rotation);
          
        }
    }
}
