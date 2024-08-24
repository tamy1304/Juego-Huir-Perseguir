using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineaVisionHuir : MonoBehaviour
{
    public float velocidad = 5;
    public Transform objetivo;
    public float limiteX = 10f;
    public float limiteZ = 10f;

    void Update()
    {
        Vector3 direccionHuir = transform.position - objetivo.position;
        direccionHuir.y = 0; 

        Vector3 nuevaDireccion = transform.position + direccionHuir;
        transform.LookAt(nuevaDireccion);

        Vector3 nuevaPosicion = transform.position + direccionHuir.normalized * velocidad * Time.deltaTime;

        nuevaPosicion.x = Mathf.Clamp(nuevaPosicion.x, -limiteX, limiteX);
        nuevaPosicion.z = Mathf.Clamp(nuevaPosicion.z, -limiteZ, limiteZ);

        transform.position = nuevaPosicion;
    }
}

