using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarPosicion : MonoBehaviour
{
    public float tiempoEspera = 10f;
    public Vector3 nuevaPosicion;
    void Start()
    {
        StartCoroutine(MoverContinuamente());
    }
    IEnumerator MoverContinuamente()
    {
        while (true) 
        {
            yield return new WaitForSeconds(tiempoEspera);

            if (this != null)
            {
                float nuevoX = Random.Range(-10f, 10f);
                float nuevoZ = Random.Range(-10f, 10f);
                nuevaPosicion = new Vector3(nuevoX, transform.position.y, nuevoZ);
                transform.position = nuevaPosicion;
            }
            else
            {
                GameObject newObject = Instantiate(gameObject);
                float nuevoX = Random.Range(-5f, 5f);
                float nuevoZ = Random.Range(-5f, 5f);
                newObject.transform.position = new Vector3(nuevoX, transform.position.y, nuevoZ);
            }
        }
    }
}
