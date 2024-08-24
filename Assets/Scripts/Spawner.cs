using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objetoPrefab; // El prefab del objeto que quieres reaparecer
    public float tiempoEspera = 10f;
    private GameObject objetoActual;

    void Start()
    {
        StartCoroutine(ReaparecerObjeto());
    }

    public void DestruirObjetoActual()
    {
        if (objetoActual != null)
        {
            Destroy(objetoActual);
        }
    }

    IEnumerator ReaparecerObjeto()
    {
        while (true) // Bucle infinito para seguir reapariciendo el objeto
        {
            // Esperar antes de reaparecer
            yield return new WaitForSeconds(tiempoEspera);

            if (objetoActual == null) // Solo reaparece si el objeto ha sido destruido
            {
                // Crear una nueva instancia del objeto en una posición aleatoria
                float nuevoX = Random.Range(-5f, 5f);
                float nuevoZ = Random.Range(-5f, 5f);
                Vector3 nuevaPosicion = new Vector3(nuevoX, 0, nuevoZ);
                objetoActual = Instantiate(objetoPrefab, nuevaPosicion, Quaternion.identity);
            }
        }
    }
}