using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct SMovimiento
{
    public float rotacion;
    public float tiempo;
    public float velocidad;
    public float velRotacion;

    public SMovimiento(float pRotacion, float pTiempo, float pVelocidad, float pVelRotacion)
    {
        rotacion= pRotacion;
        tiempo= pTiempo;
        velocidad= pVelocidad; ;
        velRotacion = pVelRotacion;
    }
}

public class MovPatron : MonoBehaviour
{
    private int cantidadPasos;
    private List<SMovimiento> patron = new List<SMovimiento>();
    private float Tiempo = 0;
    private int indice = 0;
    private Vector3 direccion;

    void Start()
    {
        //Creamos el patron
        patron.Add(new SMovimiento(30,2,5,3));
        patron.Add(new SMovimiento(-30, 2, 5, 2));
        patron.Add(new SMovimiento(0, 3, 5, 0));
        patron.Add(new SMovimiento(0,2,2,0));
        patron.Add(new SMovimiento(15, 5, 0, 5));
        cantidadPasos = patron.Count;
        indice = 0;
    }

    void Update()
    {
        Tiempo += Time.deltaTime;
        if(Tiempo > patron[indice].tiempo)
        {
            //reseteamos tiempo y avanzamos movimiento
            Tiempo = 0;
            indice++;
            if(indice >= cantidadPasos) 
            {
                indice = 0;
            }
        }

        direccion = Quaternion.AngleAxis(patron[indice].rotacion, Vector3.up) * transform.forward;
        Quaternion rotOjetivo = Quaternion.LookRotation(direccion);
        transform.rotation = Quaternion.Lerp(transform.rotation,
            rotOjetivo, patron[indice].velRotacion * Time.deltaTime);
        transform.Translate(transform.forward * patron[indice].velocidad * Time.deltaTime);

    }
}
