using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    public Transform objetivo; // El primer objetivo hacia el que se dirige
    public Transform segundoObjetivo; // El segundo objetivo al que se dirigirá después de la colisión con el primer objetivo
    public Transform tercerObjetivo; // El tercer objetivo al que se dirigirá después de la colisión con el segundo objetivo
    public float velocidad = 5f; // La velocidad de movimiento
    public float distanciaSuelo = 0.1f; // Distancia mínima desde el suelo
    public GameObject enemigo;


    private Rigidbody2D rb;
    private int direccion = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Debug.Log(direccion);
        if (direccion == 1)
        {
            // Calcula la dirección hacia el primer objetivo
            Vector2 direccion = (objetivo.position - transform.position).normalized;

            // Lanza un rayo hacia abajo para detectar la posición del suelo
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distanciaSuelo);

            // Calcula la nueva posición del jugador ajustando la altura
            Vector2 nuevaPosicion = transform.position + new Vector3(direccion.x, direccion.y * hit.distance, 0) * velocidad * Time.deltaTime;

            // Aplica la nueva posición
            rb.MovePosition(nuevaPosicion);
        }
        if(direccion == 2)
        {
            // Calcula la dirección hacia el siguiente objetivo
            Vector2 direccion = (segundoObjetivo.position - transform.position).normalized;

            // Lanza un rayo hacia abajo para detectar la posición del suelo
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distanciaSuelo);

            // Mueve el personaje hacia el siguiente objetivo
            Vector2 nuevaPosicion = (Vector2)transform.position + direccion * velocidad * Time.deltaTime;
            rb.MovePosition(nuevaPosicion);
        }
         if(direccion == 3)
        {
            // Calcula la dirección hacia el siguiente objetivo
            Vector2 direccion = (tercerObjetivo.position - transform.position).normalized;

            // Lanza un rayo hacia abajo para detectar la posición del suelo
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distanciaSuelo);

            // Mueve el personaje hacia el siguiente objetivo
            Vector2 nuevaPosicion = (Vector2)transform.position + direccion * velocidad * Time.deltaTime;
            rb.MovePosition(nuevaPosicion);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform == objetivo)
        {
            // Cambia el Layer del personaje al Layer "Enemigo2Nivel"
            enemigo.layer = LayerMask.NameToLayer("Enemigo2Nivel");

            // Cambia la dirección en el eje X por 180 grados
            Vector3 nuevaRotacion = transform.eulerAngles;
            nuevaRotacion.y += 180f;
            transform.eulerAngles = nuevaRotacion;

            // Cambia el objetivo al segundo objetivo
            objetivo = segundoObjetivo;

           direccion = 2;
        }
        if (collision.transform == segundoObjetivo)
        {
            // Cambia el Layer del personaje al Layer "Enemigo3Nivel"
            enemigo.layer = LayerMask.NameToLayer("Enemigo3Nivel");

            // Cambia la dirección en el eje X por 0 grados (dirección original)
            Vector3 nuevaRotacion = transform.eulerAngles;
            nuevaRotacion.y = 0f;
            transform.eulerAngles = nuevaRotacion;

            // Cambia el objetivo al tercer objetivo
            objetivo = tercerObjetivo; // Cambia objetivo al tercer objetivo solo si colisiona con el segundo objetivo

            direccion = 3; 
        }
    }
}
