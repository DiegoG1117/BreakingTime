using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCarta : MonoBehaviour
{
    private bool moviendo = false;
    public GameObject objetoACrear; // Arrastra el prefab que deseas crear en el Inspector
    private bool creandoObjeto = false;

    public GameObject Carta;
    private Vector3 posicionOriginalCarta; // Guarda la posición original de la carta

    private void Start()
    {
        // Al inicio, guarda la posición original de la carta
        posicionOriginalCarta = Carta.transform.position;
    }

    void OnMouseDrag()
    {
        if (moviendo)
        {
            // Obtiene la posición actual del mouse en el mundo
            Vector3 posicionMouseEnWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            posicionMouseEnWorld.z = 1; // Asegúrate de la profundidad adecuada
            // Mueve el cuadrado hacia la posición del mouse
            transform.position = posicionMouseEnWorld;
        }
    }

    void OnMouseDown()
    {
        if (creandoObjeto == false)
        {
            creandoObjeto = true;
        }
        moviendo = true;
    }

    void OnMouseUp()
    {
        if (creandoObjeto == true)
        {
            CreandoPersonaje();
            creandoObjeto = false;

            // Restaura la posición original de la carta
            Carta.transform.position = posicionOriginalCarta;
        }
        moviendo = false;
    }

    public void CreandoPersonaje()
    {
        Vector3 posicionMouseEnWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        posicionMouseEnWorld.z = 0; // Asegúrate de la profundidad adecuada

        // Crea el objeto en la posición del mouse con rotación en el eje Y de 180 grados
        GameObject nuevoPersonaje = Instantiate(objetoACrear, posicionMouseEnWorld, Quaternion.Euler(0f, 180f, 0f));
    }
    
}
