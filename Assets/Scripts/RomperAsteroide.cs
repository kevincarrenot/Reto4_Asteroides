using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RomperAsteroide : MonoBehaviour
{
    AudioSource aud;
    public bool AsteroideGrande;
    public GameObject AsteroidepequeñoPrefab;
    void Start()
    {
        aud=Camera.main.GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Colision()
    {
        aud.Play();
        Puntaje.puntajeActual.ActualizarPuntaje();
        if (AsteroideGrande)
        {
           
            Instantiate(AsteroidepequeñoPrefab, transform.position+ Random.onUnitSphere*0.1f, Quaternion.identity);
            Instantiate(AsteroidepequeñoPrefab, transform.position + Random.onUnitSphere*0.1f, Quaternion.identity);
            Destroy(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
