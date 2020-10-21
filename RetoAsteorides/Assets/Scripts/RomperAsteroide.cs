using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RomperAsteroide : MonoBehaviour
{
    public bool AsteroideGrande;
    public GameObject AsteroidepequeñoPrefab;
    // Start is called before the first frame update
    void Colision()
    {
        if (AsteroideGrande)
        {
            Instantiate(AsteroidepequeñoPrefab, transform.position+ Random.onUnitSphere*.3f, Quaternion.identity);
            Instantiate(AsteroidepequeñoPrefab, transform.position + Random.onUnitSphere*.3f, Quaternion.identity);
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
