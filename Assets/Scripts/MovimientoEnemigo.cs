using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    public Transform Primerobjetivo; // El primer objetivo hacia el que se dirige
    public Transform segundoObjetivo; // El segundo objetivo al que se dirigirá después de la colisión con el primer objetivo
    public Transform tercerObjetivo; // El tercer objetivo al que se dirigirá después de la colisión con el segundo objetivo
    public Transform cuartoObjetivo; // El tercer objetivo al que se dirigirá después de la colisión con el segundo objetivo
    public Transform quintoObjetivo; // El tercer objetivo al que se dirigirá después de la colisión con el segundo objetivo
    public Transform sextoObjetivo; // El tercer objetivo al que se dirigirá después de la colisión con el segundo objetivo
    public Transform septimoObjetivo; // El tercer objetivo al que se dirigirá después de la colisión con el segundo objetivo
    public Transform octavoObjetivo; // El tercer objetivo al que se dirigirá después de la colisión con el segundo objetivo
    public Transform novenoObjetivo; // El tercer objetivo al que se dirigirá después de la colisión con el segundo objetivo
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
        // PRIMER CARRIL MOVIMIENTO DE ENEMIGO 
    
        if (direccion == 1 && gameObject.layer == LayerMask.NameToLayer("EnemigoCarril1"))
        {
            // Calcula la dirección hacia el primer objetivo
            Vector2 direccion = (cuartoObjetivo.position - transform.position).normalized;

            // Lanza un rayo hacia abajo para detectar la posición del suelo
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distanciaSuelo);

            // Calcula la nueva posición del jugador ajustando la altura
            Vector2 nuevaPosicion = transform.position + new Vector3(direccion.x, direccion.y * hit.distance, 0) * velocidad * Time.deltaTime;

            // Aplica la nueva posición
            rb.MovePosition(nuevaPosicion);
        }
              // SEGUNDO CARRIL MOVIMIENTO DE ENEMIGO 
    
        if (direccion == 1 && gameObject.layer == LayerMask.NameToLayer("EnemigoCarril2"))
        {
            // Calcula la dirección hacia el primer objetivo
            Vector2 direccion = (sextoObjetivo.position - transform.position).normalized;

            // Lanza un rayo hacia abajo para detectar la posición del suelo
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distanciaSuelo);

            // Calcula la nueva posición del jugador ajustando la altura
            Vector2 nuevaPosicion = transform.position + new Vector3(direccion.x, direccion.y * hit.distance, 0) * velocidad * Time.deltaTime;

            // Aplica la nueva posición
            rb.MovePosition(nuevaPosicion);
        }

        // TERCER CARRIL MOVIMIENTO ENEMIGO
        if (direccion == 1 && gameObject.layer == LayerMask.NameToLayer("EnemigoCarril3"))
        {
            // Calcula la dirección hacia el primer objetivo
            Vector2 direccion = (Primerobjetivo.position - transform.position).normalized;

            // Lanza un rayo hacia abajo para detectar la posición del suelo
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distanciaSuelo);

            // Calcula la nueva posición del jugador ajustando la altura
            Vector2 nuevaPosicion = transform.position + new Vector3(direccion.x, direccion.y * hit.distance, 0) * velocidad * Time.deltaTime;

            // Aplica la nueva posición
            rb.MovePosition(nuevaPosicion);
        }

        // CUARTO CARRIL MOVIMIENTO ENEMIGO
        if (direccion == 1 && gameObject.layer == LayerMask.NameToLayer("EnemigoCarril4"))
        {
            // Calcula la dirección hacia el primer objetivo
            Vector2 direccion = (octavoObjetivo.position - transform.position).normalized;

            // Lanza un rayo hacia abajo para detectar la posición del suelo
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distanciaSuelo);

            // Calcula la nueva posición del jugador ajustando la altura
            Vector2 nuevaPosicion = transform.position + new Vector3(direccion.x, direccion.y * hit.distance, 0) * velocidad * Time.deltaTime;

            // Aplica la nueva posición
            rb.MovePosition(nuevaPosicion);
        }
        
        if(direccion == 2 && gameObject.layer == LayerMask.NameToLayer("Enemigo2Carril3"))
        {
            // Calcula la dirección hacia el siguiente objetivo
            Vector2 direccion = (segundoObjetivo.position - transform.position).normalized;

            // Lanza un rayo hacia abajo para detectar la posición del suelo
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distanciaSuelo);

            // Mueve el personaje hacia el siguiente objetivo
            Vector2 nuevaPosicion = (Vector2)transform.position + direccion * velocidad * Time.deltaTime;
            rb.MovePosition(nuevaPosicion);
        }
          if(direccion == 2 && gameObject.layer == LayerMask.NameToLayer("Enemigo2Carril1"))
        {
            // Calcula la dirección hacia el siguiente objetivo
            Vector2 direccion = (quintoObjetivo.position - transform.position).normalized;

            // Lanza un rayo hacia abajo para detectar la posición del suelo
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distanciaSuelo);

            // Mueve el personaje hacia el siguiente objetivo
            Vector2 nuevaPosicion = (Vector2)transform.position + direccion * velocidad * Time.deltaTime;
            rb.MovePosition(nuevaPosicion);
        }
          if(direccion == 2 && gameObject.layer == LayerMask.NameToLayer("Enemigo2Carril2"))
        {
            // Calcula la dirección hacia el siguiente objetivo
            Vector2 direccion = (septimoObjetivo.position - transform.position).normalized;

            // Lanza un rayo hacia abajo para detectar la posición del suelo
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distanciaSuelo);

            // Mueve el personaje hacia el siguiente objetivo
            Vector2 nuevaPosicion = (Vector2)transform.position + direccion * velocidad * Time.deltaTime;
            rb.MovePosition(nuevaPosicion);
        }
        if(direccion == 2 && gameObject.layer == LayerMask.NameToLayer("Enemigo2Carril4"))
        {
            // Calcula la dirección hacia el siguiente objetivo
            Vector2 direccion = (novenoObjetivo.position - transform.position).normalized;

            // Lanza un rayo hacia abajo para detectar la posición del suelo
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distanciaSuelo);

            // Mueve el personaje hacia el siguiente objetivo
            Vector2 nuevaPosicion = (Vector2)transform.position + direccion * velocidad * Time.deltaTime;
            rb.MovePosition(nuevaPosicion);
        }
         if(direccion == 3 && gameObject.layer == LayerMask.NameToLayer("Enemigo3Carril3"))
        {
            // Calcula la dirección hacia el siguiente objetivo
            Vector2 direccion = (tercerObjetivo.position - transform.position).normalized;

            // Lanza un rayo hacia abajo para detectar la posición del suelo
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distanciaSuelo);

            // Mueve el personaje hacia el siguiente objetivo
            Vector2 nuevaPosicion = (Vector2)transform.position + direccion * velocidad * Time.deltaTime;
            rb.MovePosition(nuevaPosicion);
        }
        
            if(direccion == 3 && gameObject.layer == LayerMask.NameToLayer("Enemigo3Carril1"))
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
        if (collision.transform == Primerobjetivo)
        {
            // Cambia el Layer del personaje al Layer "Enemigo2Nivel"
            enemigo.layer = LayerMask.NameToLayer("Enemigo2Carril3");

            // Cambia la dirección en el eje X por 180 grados
            Vector3 nuevaRotacion = transform.eulerAngles;
            nuevaRotacion.y += 180f;
            transform.eulerAngles = nuevaRotacion;
            direccion = 2;
        }
        if (collision.transform == segundoObjetivo)
        {
            // Cambia el Layer del personaje al Layer "Enemigo3Nivel"
            enemigo.layer = LayerMask.NameToLayer("Enemigo3Carril3");

            // Cambia la dirección en el eje X por 0 grados (dirección original)
            Vector3 nuevaRotacion = transform.eulerAngles;
            nuevaRotacion.y = 0f;
            transform.eulerAngles = nuevaRotacion;
            direccion = 3; 
        }
        if (collision.transform == cuartoObjetivo)
        {
            // Cambia el Layer del personaje al Layer "Enemigo3Nivel"
            enemigo.layer = LayerMask.NameToLayer("Enemigo2Carril1");

            // Cambia la dirección en el eje X por 0 grados (dirección original)
            Vector3 nuevaRotacion = transform.eulerAngles;
            nuevaRotacion.y += 180f;
            transform.eulerAngles = nuevaRotacion;
            direccion = 2; 
        }
        if (collision.transform == quintoObjetivo)
        {
            // Cambia el Layer del personaje al Layer "Enemigo3Nivel"
            enemigo.layer = LayerMask.NameToLayer("Enemigo3Carril1");

            // Cambia la dirección en el eje X por 0 grados (dirección original)
            Vector3 nuevaRotacion = transform.eulerAngles;
            nuevaRotacion.y = 0f;
            transform.eulerAngles = nuevaRotacion;
            direccion = 3; 
        }
        if (collision.transform == sextoObjetivo)
        {
            // Cambia el Layer del personaje al Layer "Enemigo3Nivel"
            enemigo.layer = LayerMask.NameToLayer("Enemigo2Carril2");

            // Cambia la dirección en el eje X por 0 grados (dirección original)
            Vector3 nuevaRotacion = transform.eulerAngles;
            nuevaRotacion.y += 180f;
            transform.eulerAngles = nuevaRotacion;
            direccion = 2; 
        }
            if (collision.transform == septimoObjetivo)
        {
            // Cambia el Layer del personaje al Layer "Enemigo3Nivel"
            enemigo.layer = LayerMask.NameToLayer("EnemigoCarril1");

            // Cambia la dirección en el eje X por 0 grados (dirección original)
            Vector3 nuevaRotacion = transform.eulerAngles;
            nuevaRotacion.y = 0f;
            transform.eulerAngles = nuevaRotacion;
            direccion = 1; 
        }
        if (collision.transform == octavoObjetivo)
        {
            // Cambia el Layer del personaje al Layer "Enemigo3Nivel"
            enemigo.layer = LayerMask.NameToLayer("Enemigo2Carril4");

            // Cambia la dirección en el eje X por 0 grados (dirección original)
            Vector3 nuevaRotacion = transform.eulerAngles;
            nuevaRotacion.y += 180f;
            transform.eulerAngles = nuevaRotacion;
            direccion = 2; 
        }
        if (collision.transform == novenoObjetivo)
        {
            // Cambia el Layer del personaje al Layer "Enemigo3Nivel"
            enemigo.layer = LayerMask.NameToLayer("EnemigoCarril3");

            // Cambia la dirección en el eje X por 0 grados (dirección original)
            Vector3 nuevaRotacion = transform.eulerAngles;
            nuevaRotacion.y = 0f;
            transform.eulerAngles = nuevaRotacion;
            direccion = 1; 
        }
        
        
    }
}
