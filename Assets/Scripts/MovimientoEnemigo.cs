using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    public Transform objetivo; // El objeto vacío al que quieres moverte
    public float velocidad = 5f; // La velocidad de movimiento

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (objetivo != null)
        {
            // Calcula la dirección hacia el objetivo
            Vector2 direccion = (objetivo.position - transform.position).normalized;

            // Aplica la velocidad para moverse hacia el objetivo
            rb.velocity = direccion * velocidad;
        }
        else
        {
            // Si el objetivo es nulo, detén el movimiento
            rb.velocity = Vector2.zero;
        }
    }
}
