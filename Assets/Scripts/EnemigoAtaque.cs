using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoAtaque : MonoBehaviour
{
    public Animator animator;
    public int estado;

    // Este es el nuevo AnimatorController que quieres asignar cuando haya colisión
    public RuntimeAnimatorController nuevoController;

    void Start()
    {
        estado = 0;
        // Obtén el componente Animator del objeto
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        // Verifica si la colisión es con el objeto deseado
        if (other.CompareTag("Defensor"))
        {
                estado = 1;
                animator.SetInteger("Estado", estado); 
        }
    }
}
