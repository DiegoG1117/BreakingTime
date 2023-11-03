using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Asegúrate de importar el espacio de nombres TextMeshPro

public class CambioTemporal : MonoBehaviour
{
    public GameObject Amedieval;
    public GameObject Aguerra;
    public GameObject Afuturista;
    public TextMeshProUGUI tiempoText; // Asigna el objeto TextMeshPro en el Inspector

    private float tiempoRestante = 300.0f; // 5 minutos en segundos

    // Start is called before the first frame update
    void Start()
    {
        Amedieval.SetActive(true);
        Aguerra.SetActive(false);
        Afuturista.SetActive(false);
        
        // Iniciar la corutina para generar un número aleatorio después de esperar 10 segundos
        StartCoroutine(GenerarNumeroDespuesDeEsperar());

        // Actualizar el TextMeshPro con el tiempo restante
        ActualizarTiempoText();
    }

    void Update()
    {
        // Actualizar el tiempo restante
        tiempoRestante -= Time.deltaTime;

        // Verificar si el tiempo ha llegado a cero
        if (tiempoRestante <= 0.0f)
        {
            tiempoRestante = 0.0f;
            // Aquí puedes realizar alguna acción una vez que el tiempo llegue a cero
        }

        // Actualizar el TextMeshPro con el tiempo restante
        ActualizarTiempoText();
    }

    void ActualizarTiempoText()
    {
        int minutos = (int)(tiempoRestante / 60);
        int segundos = (int)(tiempoRestante % 60);

        // Formatear el tiempo restante como un string y mostrarlo en el TextMeshPro
        tiempoText.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }

    IEnumerator GenerarNumeroDespuesDeEsperar()
    {
        // Esperar 30 segundos antes de generar un número aleatorio
        yield return new WaitForSeconds(30f);

        // Generar un número aleatorio del 1 al 3
        int numeroAleatorio = Random.Range(1, 4);
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
