using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PerseguirContador : MonoBehaviour
{
    public Contador contador;
    private ControladorJuego c;
    void Start()
    {
        contador = GameObject.FindGameObjectWithTag("Player").GetComponent<Contador>();
        c = GameObject.FindObjectOfType<ControladorJuego>();

        if (c == null)
        {
            Debug.LogError("No se pudo encontrar el ControladorJuego en la escena.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            contador.Cantidad = contador.Cantidad + 1;
            if (c != null)
            {
                c.actualizarPuntuacion(contador.Cantidad);
            }
            
        }

    }

}
