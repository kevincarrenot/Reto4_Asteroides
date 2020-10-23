using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Puntaje : MonoBehaviour
{
    public Text textoScore;
    int puntos;
    public static Puntaje puntajeActual;
    void Start()
    {
        puntajeActual = this;
    }
   
   public void ActualizarPuntaje()
    {
        puntos++;
        
        textoScore.text = "Score : " + puntos.ToString();

    }
}
