using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefensorKnight : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
        // Obtén el componente Rigidbody2D del objeto
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Camino"))
        {
        
                rb.simulated = false;
                Debug.Log("Se quito rb");
            
        }
    }
}
