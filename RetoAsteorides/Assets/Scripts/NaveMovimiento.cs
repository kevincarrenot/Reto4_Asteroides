using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveMovimiento : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 8f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Direccionx = Input.GetAxis("Horizontal") * Vector3.right;
        Vector3 Direccionz = Input.GetAxis("Vertical") * Vector3.forward;

        Vector3 Direccion = Direccionx + Direccionz;
        Vector3 VectorVelocidad = Direccion * speed;
        rb.velocity = VectorVelocidad;
    }
}
