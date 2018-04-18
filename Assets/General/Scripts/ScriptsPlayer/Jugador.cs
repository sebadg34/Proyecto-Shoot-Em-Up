using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour  {


        [SerializeField]private int mejora;
        private int puntaje;
        [SerializeField] private int vida;
        [SerializeField] private GameObject proyectil;
        [SerializeField] private Rigidbody2D cuerpo;
        [SerializeField]private Transform disparador;
        private float rapidez;
        private float tiempoDet = 0f;



        public void SetVida(int vida)
        {
            this.vida = vida;
        }

        public void SetPuntaje(int puntaje)
        {
            this.puntaje = puntaje;
        }

        public int GetMejora()
        {
            return this.mejora;  
        }
    
        public int GetPuntaje()
        {
            return this.puntaje;
        }

        public void Movimiento(float rapidez)
        {
        
        float movX = Input.GetAxisRaw("Horizontal");
        float movY = Input.GetAxisRaw("Vertical");

            this.cuerpo.GetComponent<Rigidbody2D>().velocity = new Vector2(movY*rapidez, this.cuerpo.GetComponent<Rigidbody2D>().velocity.y);
            this.cuerpo.GetComponent<Rigidbody2D>().velocity = new Vector2(movX*rapidez, this.cuerpo.GetComponent<Rigidbody2D>().velocity.x);
        }

        public void Disparo()
        {
        Instantiate(this.proyectil, this.disparador.position, this.disparador.rotation);
    }

        public void DestruirJugador()
        {
           if (this.vida == 0)
        {
            Destroy(gameObject);
        }
        }

        public void CambiarProyectil(int mejora)
        {

        }


    private void Start()
    {
      
    }
    private void Update()
    {

        Movimiento(5f); //Llama la funcion Movimiento de la clase Jugador, El parametro equivale a la velocidad.

        DestruirJugador();
        //Variables Tiempo para el retraso de disparo

        float retraso = 0.2f; //el delay de disparo
        tiempoDet += Time.deltaTime; //Variable auxiliar dependiente del tiempo

        if (Input.GetKey(KeyCode.Mouse0) && tiempoDet > retraso) //si el tiempoDet es mayor a retraso, el proyectil, 
                                                                 //se instancia al invokar la funcion "Disparo", reiniciando el tiempoDet
        {
            Invoke("Disparo", 0);
            tiempoDet = 0f;
        }

    }
       
   

    

}

