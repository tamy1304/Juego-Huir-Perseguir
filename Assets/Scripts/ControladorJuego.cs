using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControladorJuego : MonoBehaviour
{
    public TMP_Text pts;

    public void actualizarPuntuacion(int puntos)
    {
        pts.text = "Puntuación: " + puntos.ToString();
    }

}
