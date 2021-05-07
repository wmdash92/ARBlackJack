using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class CardCtrl : MonoBehaviour
{


    public GameObject FairyEffect;

    private Transform CardTr;




    // Start is called before the first frame update
    void Start()
    {
            Debug.Log("hello");
        
    }






    // Update is called once per frame
    void Update()
    {
        
    }



    void OnCollisionEnter(Collision coll)
    {
        if ( coll.collider.CompareTag("CARD"))
        {
            Debug.Log("coll");
            Instantiate(FairyEffect, CardTr.position, CardTr.rotation);
        }
    }





}
