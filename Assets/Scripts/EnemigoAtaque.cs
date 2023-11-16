using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoAtaque : MonoBehaviour
{
    public Animator animator;
    public int estado;



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
                Debug.Log("SI SE DETECTO MALDITASEA ");
                estado = 1;
                animator.SetInteger("Estado", estado); 
        }
    }
}
