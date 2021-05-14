using System.Collections;
using System.Collections.Generic;
using UnityEngine;






public class SpadeCard : MonoBehaviour
{





    private Ray ray;
    private RaycastHit hit;

    public GameObject FairyEffect;

    public GameObject Card;






    void Start()
    {
        
    }







    void Update()
    {
        
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 10.0f, Color.green);



        if(Physics.Raycast(ray, out hit, 10.0f, 1<<7))
        {
            Debug.Log("hello");






    }








    }



}
