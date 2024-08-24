using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuirContador : MonoBehaviour
{
    public Contador contador;
    ControladorJuego c;
    void Start()
    {
        contador = GameObject.FindGameObjectWithTag("Player").GetComponent<Contador>();
        c = GameObject.FindObjectOfType<ControladorJuego>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            contador.Cantidad = contador.Cantidad - 1;
            c.actualizarPuntuacion(contador.Cantidad);

        }

    }

}
