using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public Transform lanzadorIzq;
    public Transform lanzadorDer;

    public GameObject DisparoPrefab;
   
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(DisparoPrefab, lanzadorIzq.position, DisparoPrefab.transform.rotation);
            Instantiate(DisparoPrefab, lanzadorDer.position, DisparoPrefab.transform.rotation);

        }
    }
}
