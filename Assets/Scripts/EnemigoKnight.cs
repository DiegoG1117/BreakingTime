using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoKnight : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Camino"))
        {
            // Desactiva el collider del objeto "Camino"
            other.enabled = false;

            Debug.Log("Colisión con 'Camino'");
        }
    }
}
