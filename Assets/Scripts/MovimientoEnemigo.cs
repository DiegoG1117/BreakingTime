using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    public Transform objetivo; // El objeto vacío al que quieres moverte
    public float velocidad = 5f; // La velocidad de movimiento
    public float distanciaSuelo = 0.1f; // Distancia mínima desde el suelo

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
            // Calcula la dirección hacia el objetivo
            Vector2 direccion = (objetivo.position - transform.position).normalized;

            // Lanza un rayo hacia abajo para detectar la posición del suelo
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, Mathf.Infinity, LayerMask.GetMask("Camino"));

            // Calcula la nueva posición del jugador ajustando la altura
            Vector2 nuevaPosicion = transform.position + new Vector3(direccion.x, direccion.y * hit.distance, 0) * velocidad * Time.deltaTime;

            // Aplica la nueva posición
            rb.MovePosition(nuevaPosicion);
    }
}
