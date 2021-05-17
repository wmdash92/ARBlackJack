using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CakeCtrl : MonoBehaviour
{
    
    

    private Rigidbody rb;
    // public Transform EffectPos;
    public GameObject Spark;




    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.forward * 80.0f);

        Invoke("SparkEffect",0.5f);
        Destroy(this.gameObject,0.5f);
    
    


    }








    void SparkEffect()
    {
        Instantiate(Spark,transform.position, transform.rotation);

    }





}
