using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ForceBumper : MonoBehaviour
{
    public float bumperForce = 10;
    void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

        rb.AddForce(-bumperForce * rb.velocity.normalized, ForceMode.Impulse);

    }
   

}