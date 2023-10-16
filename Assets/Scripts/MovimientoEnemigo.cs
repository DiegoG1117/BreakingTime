using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    public Transform objetivo; // El primer objetivo hacia el que se dirige
    public Transform segundoObjetivo; // El segundo objetivo al que se dirigirá después de la colisión
    public float velocidad = 5f; // La velocidad de movimiento
    public float distanciaSuelo = 0.1f; // Distancia mínima desde el suelo
    public LayerMask capaSuelo; // Capa de suelo

    public GameObject enemigo;

    private Rigidbody2D rb;
    private bool cambiaDireccion = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!cambiaDireccion)
        {
            // Calcula la dirección hacia el primer objetivo
            Vector2 direccion = (objetivo.position - transform.position).normalized;

            // Lanza un rayo hacia abajo para detectar la posición del suelo
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distanciaSuelo, capaSuelo);

            // Calcula la nueva posición del jugador ajustando la altura
            Vector2 nuevaPosicion = transform.position + new Vector3(direccion.x, direccion.y * hit.distance, 0) * velocidad * Time.deltaTime;

            // Aplica la nueva posición
            rb.MovePosition(nuevaPosicion);
        }
        else
        {
            // Calcula la dirección hacia el segundo objetivo
            Vector2 direccion = (segundoObjetivo.position - transform.position).normalized;

            // Mueve el personaje hacia el segundo objetivo
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

            cambiaDireccion = true;
        }
    }
}
