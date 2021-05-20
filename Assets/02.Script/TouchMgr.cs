using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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


    public Transform[] spadeTrs;
    public Transform[] diamonds;
    public Transform[] hearts;
    public Transform[] clovers;

#region SpadeCardTr
//--------------------------------


    
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
    public Transform Spade11Tr;
    public Transform Spade12Tr;
    public Transform Spade13Tr;



#endregion

//----------------------------------------

    public int PlayerPoint;
    public int APoint;
    public int NotAPoint;










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




        SpadeCardCtrl();


        PlayerPoint = APoint + NotAPoint;
        if(PlayerPoint > 21)
        {
            SceneManager.LoadScene("LoseScene");
        }

    }





    void SpadeCardCtrl()
    {

    #region SpadeCardCtrl











        if (Physics.Raycast(ray, out hit, 10.0f, 1 << 6))
        {

            if (Input.GetMouseButtonDown(0))
            {

                GameObject BackColor_Black_Spade01 = GameObject.Find("BackColor_Black_Spade01");
                BackColor_Black_Spade01.SetActive(false);


                GameObject Spade01 = GameObject.Find("Mark_Spade01");
                var cards = Spade01.GetComponentsInChildren<Transform>(true);
                foreach (var card in cards)
                {
                    if (card.gameObject.name == "Spade01")
                    {
                        card.gameObject.SetActive(true);

                        GameObject FaEffect = Instantiate(FairyEffect, spadeTrs[0].transform.position, spadeTrs[0].transform.rotation);
                        GameObject PlEffect = Instantiate(PlasEffect, Spade01Tr.transform.position, Spade01Tr.transform.rotation);
                        Destroy(FaEffect, 5.0f);
                        Destroy(PlEffect, 0.6f);

                        if(PlayerPoint < 11)
                        {   
                            APoint = 11;
                        }
                        else
                        {
                            APoint = 1;
                        }
                        OnCardOpen();

                        break;
                    }
                }
            }

        }



        if (Physics.Raycast(ray, out hit, 10.0f, 1 << 7))
        {

            if (Input.GetMouseButtonDown(0))
            {

                GameObject BackColor_Black_Spade02 = GameObject.Find("BackColor_Black_Spade02");
                BackColor_Black_Spade02.SetActive(false);


                GameObject Spade02 = GameObject.Find("Mark_Spade02");
                var cards = Spade02.GetComponentsInChildren<Transform>(true);
                foreach (var card in cards)
                {
                    if (card.gameObject.name == "Spade02")
                    {
                        card.gameObject.SetActive(true);

                        GameObject FaEffect = Instantiate(FairyEffect, Spade02Tr.transform.position, Spade02Tr.transform.rotation);
                        GameObject PlEffect = Instantiate(PlasEffect, Spade02Tr.transform.position, Spade02Tr.transform.rotation);
                        Destroy(FaEffect, 5.0f);
                        Destroy(PlEffect, 0.6f);

                        NotAPoint += 2;
                        OnCardOpen();

                        break;
                    }
                }
            }
        }


        if (Physics.Raycast(ray, out hit, 10.0f, 1 << 8))
        {

            if (Input.GetMouseButtonDown(0))
            {

                GameObject BackColor_Black_Spade03 = GameObject.Find("BackColor_Black_Spade03");
                BackColor_Black_Spade03.SetActive(false);


                GameObject Spade03 = GameObject.Find("Mark_Spade03");
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

                        NotAPoint += 2;
                        OnCardOpen();

                        break;
                    }
                }
            }
        }
        if (Physics.Raycast(ray, out hit, 10.0f, 1 << 9))
        {

            if (Input.GetMouseButtonDown(0))
            {

                GameObject BackColor_Black_Spade04 = GameObject.Find("BackColor_Black_Spade04");
                BackColor_Black_Spade04.SetActive(false);


                GameObject Spade04 = GameObject.Find("Mark_Spade04");
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

                        NotAPoint += 2;
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

                GameObject BackColor_Black_Spade05 = GameObject.Find("BackColor_Black_Spade05");
                BackColor_Black_Spade05.SetActive(false);


                GameObject Spade05 = GameObject.Find("Mark_Spade05");
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

                        NotAPoint += 2;
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

                GameObject BackColor_Black_Spade06 = GameObject.Find("BackColor_Black_Spade06");
                BackColor_Black_Spade06.SetActive(false);


                GameObject Spade06 = GameObject.Find("Mark_Spade06");
                var cards = Spade06.GetComponentsInChildren<Transform>(true);
                foreach (var card in cards)
                {
                    if (card.gameObject.name == "Spade06")
                    {
                        card.gameObject.SetActive(true);

                        GameObject FaEffect = Instantiate(FairyEffect, Spade06Tr.transform.position, Spade06Tr.transform.rotation);
                        GameObject PlEffect = Instantiate(PlasEffect, Spade06Tr.transform.position, Spade06Tr.transform.rotation);
                        Destroy(FaEffect, 5.0f);
                        Destroy(PlEffect, 0.6f);

                        NotAPoint += 2;
                        OnCardOpen();

                        break;
                    }
                }
            }
        }
        if (Physics.Raycast(ray, out hit, 10.0f, 1 << 12))
        {

            if (Input.GetMouseButtonDown(0))
            {

                GameObject BackColor_Black_Spade07 = GameObject.Find("BackColor_Black_Spade07");
                BackColor_Black_Spade07.SetActive(false);


                GameObject Spade07 = GameObject.Find("Mark_Spade07");
                var cards = Spade07.GetComponentsInChildren<Transform>(true);
                foreach (var card in cards)
                {
                    if (card.gameObject.name == "Spade07")
                    {
                        card.gameObject.SetActive(true);

                        GameObject FaEffect = Instantiate(FairyEffect, Spade07Tr.transform.position, Spade07Tr.transform.rotation);
                        GameObject PlEffect = Instantiate(PlasEffect, Spade07Tr.transform.position, Spade07Tr.transform.rotation);
                        Destroy(FaEffect, 5.0f);
                        Destroy(PlEffect, 0.6f);

                        NotAPoint += 2;
                        OnCardOpen();

                        break;
                    }
                }
            }
        }
        if (Physics.Raycast(ray, out hit, 10.0f, 1 << 13))
        {

            if (Input.GetMouseButtonDown(0))
            {

                GameObject BackColor_Black_Spade08 = GameObject.Find("BackColor_Black_Spade08");
                BackColor_Black_Spade08.SetActive(false);


                GameObject Spade08 = GameObject.Find("Mark_Spade08");
                var cards = Spade08.GetComponentsInChildren<Transform>(true);
                foreach (var card in cards)
                {
                    if (card.gameObject.name == "Spade08")
                    {
                        card.gameObject.SetActive(true);

                        GameObject FaEffect = Instantiate(FairyEffect, Spade08Tr.transform.position, Spade08Tr.transform.rotation);
                        GameObject PlEffect = Instantiate(PlasEffect, Spade08Tr.transform.position, Spade08Tr.transform.rotation);
                        Destroy(FaEffect, 5.0f);
                        Destroy(PlEffect, 0.6f);

                        NotAPoint += 2;
                        OnCardOpen();

                        break;
                    }
                }
            }
        }
        if (Physics.Raycast(ray, out hit, 10.0f, 1 << 14))
        {

            if (Input.GetMouseButtonDown(0))
            {

                GameObject BackColor_Black_Spade09 = GameObject.Find("BackColor_Black_Spade09");
                BackColor_Black_Spade09.SetActive(false);


                GameObject Spade09 = GameObject.Find("Mark_Spade09");
                var cards = Spade09.GetComponentsInChildren<Transform>(true);
                foreach (var card in cards)
                {
                    if (card.gameObject.name == "Spade09")
                    {
                        card.gameObject.SetActive(true);

                        GameObject FaEffect = Instantiate(FairyEffect, Spade09Tr.transform.position, Spade09Tr.transform.rotation);
                        GameObject PlEffect = Instantiate(PlasEffect, Spade09Tr.transform.position, Spade09Tr.transform.rotation);
                        Destroy(FaEffect, 5.0f);
                        Destroy(PlEffect, 0.6f);

                        NotAPoint += 2;
                        OnCardOpen();

                        break;
                    }
                }
            }
        }
        if (Physics.Raycast(ray, out hit, 10.0f, 1 << 15))
        {

            if (Input.GetMouseButtonDown(0))
            {

                GameObject BackColor_Black_Spade10 = GameObject.Find("BackColor_Black_Spade10");
                BackColor_Black_Spade10.SetActive(false);


                GameObject Spade10 = GameObject.Find("Mark_Spade10");
                var cards = Spade10.GetComponentsInChildren<Transform>(true);
                foreach (var card in cards)
                {
                    if (card.gameObject.name == "Spade10")
                    {
                        card.gameObject.SetActive(true);

                        GameObject FaEffect = Instantiate(FairyEffect, Spade10Tr.transform.position, Spade10Tr.transform.rotation);
                        GameObject PlEffect = Instantiate(PlasEffect, Spade10Tr.transform.position, Spade10Tr.transform.rotation);
                        Destroy(FaEffect, 5.0f);
                        Destroy(PlEffect, 0.6f);

                        NotAPoint += 2;
                        OnCardOpen();

                        break;
                    }
                }
            }
        }
        if (Physics.Raycast(ray, out hit, 10.0f, 1 << 16))
        {

            if (Input.GetMouseButtonDown(0))
            {

                GameObject BackColor_Black_Spade11 = GameObject.Find("BackColor_Black_Spade11");
                BackColor_Black_Spade11.SetActive(false);


                GameObject Spade11 = GameObject.Find("Mark_Spade11");
                var cards = Spade11.GetComponentsInChildren<Transform>(true);
                foreach (var card in cards)
                {
                    if (card.gameObject.name == "Spade11")
                    {
                        card.gameObject.SetActive(true);

                        GameObject FaEffect = Instantiate(FairyEffect, Spade11Tr.transform.position, Spade11Tr.transform.rotation);
                        GameObject PlEffect = Instantiate(PlasEffect, Spade11Tr.transform.position, Spade11Tr.transform.rotation);
                        Destroy(FaEffect, 5.0f);
                        Destroy(PlEffect, 0.6f);

                        NotAPoint += 2;
                        OnCardOpen();

                        break;
                    }
                }
            }
        }
        if (Physics.Raycast(ray, out hit, 10.0f, 1 << 17))
        {

            if (Input.GetMouseButtonDown(0))
            {

                GameObject BackColor_Black_Spade12 = GameObject.Find("BackColor_Black_Spade12");
                BackColor_Black_Spade12.SetActive(false);


                GameObject Spade12 = GameObject.Find("Mark_Spade12");
                var cards = Spade12.GetComponentsInChildren<Transform>(true);
                foreach (var card in cards)
                {
                    if (card.gameObject.name == "Spade12")
                    {
                        card.gameObject.SetActive(true);

                        GameObject FaEffect = Instantiate(FairyEffect, Spade12Tr.transform.position, Spade12Tr.transform.rotation);
                        GameObject PlEffect = Instantiate(PlasEffect, Spade12Tr.transform.position, Spade12Tr.transform.rotation);
                        Destroy(FaEffect, 5.0f);
                        Destroy(PlEffect, 0.6f);

                        NotAPoint += 2;
                        OnCardOpen();

                        break;
                    }
                }
            }
        }
        if (Physics.Raycast(ray, out hit, 10.0f, 1 << 18))
        {

            if (Input.GetMouseButtonDown(0))
            {

                GameObject BackColor_Black_Spade13 = GameObject.Find("BackColor_Black_Spade13");
                BackColor_Black_Spade13.SetActive(false);


                GameObject Spade13 = GameObject.Find("Mark_Spade13");
                var cards = Spade13.GetComponentsInChildren<Transform>(true);
                foreach (var card in cards)
                {
                    if (card.gameObject.name == "Spade13")
                    {
                        card.gameObject.SetActive(true);

                        GameObject FaEffect = Instantiate(FairyEffect, Spade13Tr.transform.position, Spade13Tr.transform.rotation);
                        GameObject PlEffect = Instantiate(PlasEffect, Spade13Tr.transform.position, Spade13Tr.transform.rotation);
                        Destroy(FaEffect, 5.0f);
                        Destroy(PlEffect, 0.6f);

                        NotAPoint += 2;
                        OnCardOpen();

                        break;
                    }
                }
            }
        }

















        // if (Physics.Raycast(ray, out hit, 10.0f, 1 << 9))
        // {

        //     if (Input.GetMouseButtonDown(0))
        //     {
            
        //         GameObject BackColor_Black_Spade03 = GameObject.Find("BackColor_Black_Spade03");
        //         BackColor_Black_Spade03.SetActive(false);


        //         GameObject Spade03 = GameObject.Find("Spade03_Earth");
        //         var cards = Spade03.GetComponentsInChildren<Transform>(true);
        //         foreach (var card in cards)
        //         {
        //             if (card.gameObject.name == "Spade03")
        //             {
        //                 card.gameObject.SetActive(true);
        //                 GameObject FaEffect = Instantiate(FairyEffect, Spade03Tr.transform.position, Spade03Tr.transform.rotation);
        //                 GameObject PlEffect = Instantiate(PlasEffect, Spade03Tr.transform.position, Spade03Tr.transform.rotation);
        //                 Destroy(FaEffect, 5.0f);
        //                 Destroy(PlEffect, 0.6f);

        //                 NotAPoint += 3;
        //                 OnCardOpen();

        //                 break;
        //             }
        //         }

        //     }
        // }



        // if (Physics.Raycast(ray, out hit, 10.0f, 1 << 10))
        // {

        //     if (Input.GetMouseButtonDown(0))
        //     {

        //         GameObject BackColor_Black_Spade04 = GameObject.Find("BackColor_Black_Spade04");
        //         BackColor_Black_Spade04.SetActive(false);


        //         GameObject Spade04 = GameObject.Find("Sun_Spade04");
        //         var cards = Spade04.GetComponentsInChildren<Transform>(true);
        //         foreach (var card in cards)
        //         {
        //             if (card.gameObject.name == "Spade04")
        //             {
        //                 card.gameObject.SetActive(true);

        //                 GameObject FaEffect = Instantiate(FairyEffect, Spade04Tr.transform.position, Spade04Tr.transform.rotation);
        //                 GameObject PlEffect = Instantiate(PlasEffect, Spade04Tr.transform.position, Spade04Tr.transform.rotation);
        //                 Destroy(FaEffect, 5.0f);
        //                 Destroy(PlEffect, 0.6f);


        //                 NotAPoint += 4;
        //                 OnCardOpen();


        //                 break;
        //             }
        //         }


        //     }





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


