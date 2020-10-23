using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullAsteroides : MonoBehaviour
{
    public float tiempo =5;
    public GameObject AsteroidePrefab;

    IEnumerator Start()
    {
        while (true)
        {
            Instantiate(AsteroidePrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(tiempo);
        }
    }
   
}
