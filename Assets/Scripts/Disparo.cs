using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public AudioSource aud;
    public Transform lanzadorIzq;
    public Transform lanzadorDer;

    public GameObject DisparoPrefab;
   
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            aud.Play();
            Instantiate(DisparoPrefab, lanzadorIzq.position, DisparoPrefab.transform.rotation);
            Instantiate(DisparoPrefab, lanzadorDer.position, DisparoPrefab.transform.rotation);

        }
    }
}
