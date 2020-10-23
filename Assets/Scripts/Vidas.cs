using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vidas : MonoBehaviour
{
    public int cantidadVida;
    public Image imagenVida;
    public GameObject gameover;

    public Sprite tresvidas;
    public Sprite dosvidas;
    public Sprite unavida;
    AudioSource aud;
    void Start()
    {
        aud = Camera.main.GetComponent<AudioSource>();
        cantidadVida = 3;
        imagenVida.sprite = tresvidas;
    }

    // Start is called before the first frame update
    public void Daño()
    {
        
        aud.Play();
        cantidadVida--;
        if (cantidadVida == 3)
        {
            imagenVida.sprite = tresvidas;
        }
        else if (cantidadVida == 2)
        {
            imagenVida.sprite = dosvidas;
        }
        else if (cantidadVida == 1)
        {
            imagenVida.sprite = unavida;
        }
        else
        {
            gameover.SetActive(true);
            SceneManager.LoadScene(0);
        }
    }

}
