using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueEnemigo : MonoBehaviour
{
    [SerializeField] private Transform controladorGolpe;
    [SerializeField] private float radioGolpe;
    [SerializeField] private float dañoGolpe;

    private void Update()
    {
        // No necesitas el código de golpe en el Update si estás usando OnTriggerEnter2D
        // Mantén esto solo si quieres un ataque manual también
        // if (Input.GetButtonDown("Fire1"))
        // {
        //     Golpe();
        // }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Colisión detectada");
        if (other.CompareTag("EnemigoKnight"))
        {
            // Atacar automáticamente cuando el jugador se acerca al enemigo
            Golpe(other.gameObject);
        }
    }

    private void Golpe(GameObject enemigo)
    {
        Debug.Log("Golpeando al enemigo");
        enemigo.GetComponent<Enemigo>().TomarDaño(dañoGolpe);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(controladorGolpe.position, radioGolpe);
    }
}
