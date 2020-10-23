using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Asteroides : MonoBehaviour
{
    public float speed = 8;
    private Rigidbody rb;
    //public Vidas vidass;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.back * speed+ Vector3.right*Random.Range(-1,1);
        rb.angularVelocity = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5));
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            Destroy(gameObject);
            //vidass.Daño();
            col.SendMessage("Daño", SendMessageOptions.DontRequireReceiver);
           
        }
    }
}
