using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{

    [SerializeField] private float vida;

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void TomarDa�o(float da�o)
    {
        vida -= da�o;

        if (vida <= 0)
        {
            Muerte();
        }
    }
    // Update is called once per frame
    private void Muerte()
    {
        animator.SetTrigger("Muerte");
    }
}
