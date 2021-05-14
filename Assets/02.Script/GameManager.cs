using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

using Photon.Pun;
using Photon.Realtime;

using System.Linq;
using Hashtable = ExitGames.Client.Photon.Hashtable;






public class GameManager : MonoBehaviourPunCallbacks
{

    

    public Hashtable ht = new Hashtable();
    PhotonView pv;
    


    



    void Start()
    {
            if(PhotonNetwork.IsMasterClient)
            {
                Debug.Log("you are MASTER");
            }
            else
            {
                Debug.Log("you are not MASTER");
            }



        pv = GetComponent<PhotonView>();




    }







    void Update()
    {
        



    }


    private Dictionary <int, Player> roomPlayers = new Dictionary<int, Player>();




    public void CardCount()
    {




            Debug.Log($"current player is = {PhotonNetwork.CountOfPlayers}");
            Debug.Log($"now room player is = {PhotonNetwork.PlayerList.Count()}");




        List<Player> playerList = PhotonNetwork.CurrentRoom.Players.Values.ToList<Player>();
        Debug.Log($"hello {playerList}");
        
        int maxScore = -1;
        Player winPlayer = null;

            foreach (var player in playerList)
            {
                Hashtable htTemp = player.CustomProperties;
                Debug.Log($"your score is now {htTemp["Score"]}");
                
                if(maxScore < (int)htTemp["Score"])
                {
                    maxScore = (int)htTemp["Score"];
                    winPlayer = player;
                
                }
            }

                Debug.Log($"player {winPlayer} is High Score");
                
                    Debug.Log($"playerList  = {playerList[0]}");
                    Debug.Log($"winplayer Actornumber  = {winPlayer.ActorNumber}");




                    Debug.Log($"owner Actornumber  = {pv.Owner.ActorNumber}");


    }







        public void OnGameEndButton()
        {

            if(PhotonNetwork.IsMasterClient)

            {

                List<Player> playerList = PhotonNetwork.CurrentRoom.Players.Values.ToList<Player>();

                Debug.Log($"hello {playerList}");
                
                int maxScore = -1;
                Player winPlayer = null;

                    foreach (var player in playerList)
                    {
                        Hashtable htTemp = player.CustomProperties;
                        Debug.Log($"your score is now {htTemp["Score"]}");
                        
                        if(maxScore < (int)htTemp["Score"])
                        {
                            maxScore = (int)htTemp["Score"];
                            winPlayer = player;
                        }
                    }

                    Debug.Log($"player {winPlayer} is Win");

                    pv.RPC("EndEvent", RpcTarget.All, winPlayer.ActorNumber);

                    // EndEvent(winPlayer.ActorNumber);

            }
        }





        [PunRPC]
        void EndEvent(int winnerId)
        {


            if(winnerId == pv.Owner.ActorNumber)

                {
                    PhotonNetwork.LoadLevel("EndScene");
                }
            // else{

            // }
        }





        public UnityEvent Win;


        public void WinCake()
        {
            Win.Invoke();
        }



        public void WinScene()
        {
            // PhotonNetwork.LoadLevel("EndScene");

        }








    public override void OnPlayerPropertiesUpdate(Photon.Realtime.Player targetPlayer,
                                                ExitGames.Client.Photon.Hashtable changedProps)
        {
            Debug.Log("hello");

            Debug.Log($"target = {targetPlayer}, change = {changedProps}");

        

        }









}
