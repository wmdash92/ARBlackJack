using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMgr : MonoBehaviour
{



    private Ray ray;
    private RaycastHit hit;

    public GameObject FairyEffect;

    public Transform CardTr1;

    public GameObject Close;
    public GameObject OpenSpade;
    public GameObject Back;
    public GameObject Spade02D;
    





    // Start is called before the first frame update
    void Start()
    {
        

        // GameObject Spade02C = GameObject.FindGameObjectWithTag("CARD");





    }





    void Update()
    {
        
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 10.0f, Color.green);



        if(Physics.Raycast(ray, out hit, 10.0f, 1<<6))
        {

            Debug.Log("hello");

            if (Input.GetMouseButtonDown(0))
            {Debug.Log("touch");
            GameObject obj = Instantiate(FairyEffect, CardTr1.transform.position, CardTr1.transform.rotation);
            Destroy(obj, 3.0f);

        }


        }





        if(Physics.Raycast(ray, out hit, 10.0f, 1<<7))
        {

            if (Input.GetMouseButtonDown(0))
            {
            
            Close.SetActive(false);
            OpenSpade.SetActive(true);
            }

        }


        if(Physics.Raycast(ray, out hit, 10.0f, 1<<8))
        {

            if (Input.GetMouseButtonDown(0))
            {
            
            GameObject Spade02D = GameObject.Find("Spade02");
            Spade02D.SetActive(false);

            }

        }








    }

}
