using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreandoPersonaje : MonoBehaviour
{
    public GameObject objetoACrear; // Arrastra el prefab que deseas crear en el Inspector
    private bool creandoObjeto = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Detecta si se presiona el botón izquierdo del mouse
        {
            creandoObjeto = true;
        }
        else if (Input.GetMouseButtonUp(0)) // Detecta si se suelta el botón izquierdo del mouse
        {
            creandoObjeto = false;
        }

        if (creandoObjeto && objetoACrear != null) // Si se está creando un objeto
        {
            // Obtén la posición actual del mouse en el mundo
            Vector3 posicionMouseEnWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            posicionMouseEnWorld.z = 0; // Asegúrate de la profundidad adecuada

            // Crea el objeto en la posición del mouse
            Instantiate(objetoACrear, posicionMouseEnWorld, Quaternion.identity);
        }
    }
}
