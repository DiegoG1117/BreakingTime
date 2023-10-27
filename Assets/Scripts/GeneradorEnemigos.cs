using System.Collections;
using UnityEngine;

public class GeneradorEnemigos : MonoBehaviour
{
    public GameObject enemigoPrefab;
    public float tiempoEntreGeneraciones = 3f;

    private void Start()
    {
        // Comienza a generar enemigos en intervalos regulares
        StartCoroutine(GenerarEnemigos());
    }

    IEnumerator GenerarEnemigos()
    {
        while (true) // Genera enemigos infinitamente
        {
            // Instancia un enemigo en la posición del generador
            GameObject nuevoEnemigo = Instantiate(enemigoPrefab, transform.position, Quaternion.identity);

            // Asigna aleatoriamente uno de los cuatro layers
            int layerAleatorio = Random.Range(0, 4);
            switch (layerAleatorio)
            {
                case 0:
                    nuevoEnemigo.layer = LayerMask.NameToLayer("EnemigoCarril1");
                    break;
                case 1:
                    nuevoEnemigo.layer = LayerMask.NameToLayer("EnemigoCarril2");
                    break;
                case 2:
                    nuevoEnemigo.layer = LayerMask.NameToLayer("EnemigoCarril3");
                    break;
                case 3:
                    nuevoEnemigo.layer = LayerMask.NameToLayer("EnemigoCarril4");
                    break;
                default:
                    break;
            }

            yield return new WaitForSeconds(tiempoEntreGeneraciones);
        }
    }
}
