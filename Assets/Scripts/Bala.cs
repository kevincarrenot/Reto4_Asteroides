using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float speed = 20f;

    // Update is called once per frame
    private void Start()
    {
        Destroy(gameObject, 5);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Asteroide"))
        {
            Destroy(gameObject);
            other.SendMessage("Colision", SendMessageOptions.DontRequireReceiver);
        }
    }
    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }
}
