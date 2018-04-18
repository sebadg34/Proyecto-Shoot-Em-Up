using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApuntadorArmas : MonoBehaviour {
//Funcion que permite mantener el canon en la mira del player u cualquier objeto.



    public Transform objetivo; //Creamos un objeto objetivo

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.up =transform.position   -  objetivo.position  ;


       
    }



}
