using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyCake : MonoBehaviour
{

    private Rigidbody rb;
    public GameObject throwCakeEffect;

    // public Transform CakeCtrl;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // CakeCtrl = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ThrowCakeHigh()
    {
        rb.AddRelativeForce(Vector3.up * 300.0f);
        Instantiate(throwCakeEffect, transform.position, transform.rotation);

    }



}
