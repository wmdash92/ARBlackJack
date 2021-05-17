using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class CardCtrl : MonoBehaviour
{


    public GameObject BexplEffect;





    // Start is called before the first frame update.`
    void Start()
    {
            Debug.Log("hello");
        
    }






    // Update is called once per frame
    void Update()
    {
        
    }






    void OnTriggerEnter(Collider coll)
    {

        if ( coll.CompareTag("CARD"))
        {
            GameObject obj = Instantiate(BexplEffect, this.transform.position, this.transform.rotation);
            Destroy(obj, 3.0f);
        }
    }





}
