using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioTemporal : MonoBehaviour
{
    public GameObject Amedieval;
    public GameObject Aguerra;
    public GameObject Afuturista;
    int numeroAleatorio = 1;

    // Start is called before the first frame update
    void Start()
    {
        Amedieval.SetActive(true);
        Aguerra.SetActive(false);
        Afuturista.SetActive(false);

        // Iniciar la corutina para generar un número aleatorio después de esperar 10 segundos
        StartCoroutine(GenerarNumeroDespuesDeEsperar());
    }

    // Update is called once per frame
    void Update()
    {
        // La lógica para cambiar entre los objetos debe estar en GenerarNumeroDespuesDeEsperar
    }

    IEnumerator GenerarNumeroDespuesDeEsperar()
    {
        // Esperar 10 segundos antes de generar un número aleatorio
        yield return new WaitForSeconds(10f);

        // Generar un número aleatorio del 1 al 3
        numeroAleatorio = Random.Range(1, 4);
        Debug.Log("Número aleatorio: " + numeroAleatorio);

        // Lógica para cambiar entre los objetos según el número aleatorio
        if (numeroAleatorio == 1)
        {
            Amedieval.SetActive(true);
            Aguerra.SetActive(false);
            Afuturista.SetActive(false);
        }
        else if (numeroAleatorio == 2)
        {
            Amedieval.SetActive(false);
            Aguerra.SetActive(true);
            Afuturista.SetActive(false);
        }
        else if (numeroAleatorio == 3)
        {
            Amedieval.SetActive(false);
            Aguerra.SetActive(false);
            Afuturista.SetActive(true);
        }

        // Reiniciar la corutina para generar otro número después de esperar 10 segundos nuevamente
        StartCoroutine(GenerarNumeroDespuesDeEsperar());
    }
}
