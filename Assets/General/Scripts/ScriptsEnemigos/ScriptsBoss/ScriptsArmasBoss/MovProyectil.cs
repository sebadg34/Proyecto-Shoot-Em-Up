using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovProyectil : MonoBehaviour {


    public float Rapidez = 0.4f; //Creamos una variable publica para modificar la Rapidez de forma accesible

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(0, Rapidez, 0); //Aplica un transform dependiendo de la rapidez inicializada anteriormente.
        Destroy(gameObject, 4.0f);
    }
}
