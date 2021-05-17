using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;


using Hashtable = ExitGames.Client.Photon.Hashtable;


public class TouchMgr : MonoBehaviourPunCallbacks
{



    private Ray ray;
    private RaycastHit hit;

    public GameObject FairyEffect;
    public GameObject PlasEffect;

    public Hashtable ht = new Hashtable();
    private PhotonView pv;



#region SpadeCardTr
//--------------------------------


    public Transform[] spades;
    
    public Transform Spade01Tr;
    public Transform Spade02Tr;
    public Transform Spade03Tr;
    public Transform Spade04Tr;
    public Transform Spade05Tr;
    public Transform Spade06Tr;
    public Transform Spade07Tr;
    public Transform Spade08Tr;
    public Transform Spade09Tr;
    public Transform Spade10Tr;



#endregion

//----------------------------------------

    public int PlayerPoint;







    // Start is called before the first frame update
    void Start()
    {





    PhotonNetwork.SetPlayerCustomProperties(ht);







        // GameObject Spade02C = GameObject.FindGameObjectWithTag("CARD");


        // EffectManager a = new EffectManager();
        // a.Effect();


    }




    void Update()
    {

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 10.0f, Color.green);



    #region SpadeCardCtrl

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

                        PlayerPoint += 3;
                        OnCardOpen();

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


                        PlayerPoint += 4;
                        OnCardOpen();


                        break;
                    }
                }


            }
        }



        if (Physics.Raycast(ray, out hit, 10.0f, 1 << 11))
        {

            if (Input.GetMouseButtonDown(0))
            {

                GameObject BackColor_Black_Spade05 = GameObject.Find("BackColor_Black_Spade05");
                BackColor_Black_Spade05.SetActive(false);


                GameObject Spade05 = GameObject.Find("Sun_Spade05");
                var cards = Spade05.GetComponentsInChildren<Transform>(true);
                foreach (var card in cards)
                {
                    if (card.gameObject.name == "Spade05")
                    {
                        card.gameObject.SetActive(true);

                        GameObject FaEffect = Instantiate(FairyEffect, Spade05Tr.transform.position, Spade05Tr.transform.rotation);
                        GameObject PlEffect = Instantiate(PlasEffect, Spade05Tr.transform.position, Spade05Tr.transform.rotation);
                        Destroy(FaEffect, 5.0f);
                        Destroy(PlEffect, 0.6f);



                        PlayerPoint += 5;
                        OnCardOpen();

                    
                    


                        break;
                    }
                }


            }
        }

#endregion





    }



    public void OnCardOpen()
    {

    

        // ht.Add("Score",(int)PlayerPoint); // 스코어가 겹치는 버그 발생
        ht["Score"] = (int)PlayerPoint; 

        PhotonNetwork.SetPlayerCustomProperties(ht);
        Debug.Log($"plyaer score is {ht["Score"]}");

    }



//     public override void OnPlayerPropertiesUpdate(Photon.Realtime.Player targetPlayer,
//                                                 ExitGames.Client.Photon.Hashtable changedProps)
//         {
//             Debug.Log("");

//             Debug.Log($"target = {targetPlayer}, change = {changedProps}");



//                     if ( pv.Owner == targetPlayer )
//                     {
//                         // Instantiate<GameObject>(character, tr);
//                     }

//         }


// // 커런트 룸 플레이어 배열, 커스텀 프로퍼티, 포인트값만, foreach
// // PhotonNetwork.CurrentRoom.Player












}


