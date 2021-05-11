using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMgr : MonoBehaviour
{



    private Ray ray;
    private RaycastHit hit;

    public GameObject FairyEffect;
    public GameObject PlasEffect;

    public Transform Spade02Tr;
    public Transform Spade03Tr;
    public Transform Spade04Tr;




//---------------------------------

    public int Player1Point;
    public int Player2Point;
    public int Player3Point;
    public int Player4Point;







    // Start is called before the first frame update
    void Start()
    {


        // GameObject Spade02C = GameObject.FindGameObjectWithTag("CARD");





    }





    void Update()
    {

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 10.0f, Color.green);



        if (Physics.Raycast(ray, out hit, 10.0f, 1 << 6))
        {

            Debug.Log("hello");

            if (Input.GetMouseButtonDown(0))
            {
            Debug.Log("touch");
            GameObject obj = Instantiate(FairyEffect, Spade02Tr.transform.position, Spade02Tr.transform.rotation);
            Destroy(obj, 3.0f);
            }


        }





        if (Physics.Raycast(ray, out hit, 10.0f, 1 << 7))
        {

            if (Input.GetMouseButtonDown(0))
            {


            }

        }





        if (Physics.Raycast(ray, out hit, 10.0f, 1 << 8))
        {

            if (Input.GetMouseButtonDown(0))
            {

                GameObject BackColor_Black_Spade02 = GameObject.Find("BackColor_Black_Spade02");
                BackColor_Black_Spade02.SetActive(false);

                //GameObject Spade02 = GameObject.Find("Spade02_Earth").transform.Find("Spade02").gameObject;

                GameObject Spade02 = GameObject.Find("Spade02_Earth");
                var cards = Spade02.GetComponentsInChildren<Transform>(true);
                foreach (var card in cards)
                {
                    if (card.gameObject.name == "Spade02")
                    {
                    card.gameObject.SetActive(true);
                    GameObject FaEffect = Instantiate(FairyEffect, Spade02Tr.transform.position, Spade02Tr.transform.rotation);
                    Destroy(FaEffect, 5.0f);
                    break;
                    }
                }

            }
        }











        if (Physics.Raycast(ray, out hit, 10.0f, 1 << 9))
        {

            if (Input.GetMouseButtonDown(0))
            {
            
                GameObject BackColor_Black_Spade03 = GameObject.Find("BackColor_Black_Spade03");
                BackColor_Black_Spade03.SetActive(false);


                GameObject Spade03 = GameObject.Find("Spade03_Earth");
                var cards = Spade03.GetComponentsInChildren<Transform>(true);
                foreach (var card in cards)
                {
                    if (card.gameObject.name == "Spade03")
                    {
                        card.gameObject.SetActive(true);
                        GameObject FaEffect = Instantiate(FairyEffect, Spade03Tr.transform.position, Spade03Tr.transform.rotation);
                        GameObject PlEffect = Instantiate(PlasEffect, Spade03Tr.transform.position, Spade03Tr.transform.rotation);
                        Destroy(FaEffect, 5.0f);
                        Destroy(PlEffect, 0.6f);

                        Player1Point += 3;

                        Debug.Log(Player1Point);

                        break;
                    }
                }

            }
        }



        if (Physics.Raycast(ray, out hit, 10.0f, 1 << 10))
        {

            if (Input.GetMouseButtonDown(0))
            {

                GameObject BackColor_Black_Spade04 = GameObject.Find("BackColor_Black_Spade04");
                BackColor_Black_Spade04.SetActive(false);


                GameObject Spade04 = GameObject.Find("Sun_Spade04");
                var cards = Spade04.GetComponentsInChildren<Transform>(true);
                foreach (var card in cards)
                {
                    if (card.gameObject.name == "Spade04")
                    {
                        card.gameObject.SetActive(true);

                        GameObject FaEffect = Instantiate(FairyEffect, Spade04Tr.transform.position, Spade04Tr.transform.rotation);
                        GameObject PlEffect = Instantiate(PlasEffect, Spade04Tr.transform.position, Spade04Tr.transform.rotation);
                        Destroy(FaEffect, 5.0f);
                        Destroy(PlEffect, 0.6f);


                        Player1Point += 4;
                        Debug.Log(Player1Point);

                        break;
                    }
                }


            }
        }











    }

}
