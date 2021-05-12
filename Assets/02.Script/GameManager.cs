using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using System.Linq;
using Hashtable = ExitGames.Client.Photon.Hashtable;






public class GameManager : MonoBehaviourPunCallbacks
{






    void Start()
    {
        
    }







    void Update()
    {
        



    }


    private Dictionary <int, Player> roomPlayers = new Dictionary<int, Player>();
    public void CardCount()
    {


            

            // roomPlayers = PhotonNetwork.CurrentRoom.Players;
            // foreach(var CurrentPlayer in roomPlayers)
            // {
                



            // }
    

        List<Player> playerList = PhotonNetwork.CurrentRoom.Players.Values.ToList<Player>();
        

        int maxScore = -1;
        Player winPlayer = null;

        foreach (var player in playerList)
        {
            Hashtable htTemp = player.CustomProperties;
            
            if(maxScore < (int)htTemp["Score"])
            {
                maxScore = (int)htTemp["Score"];
                winPlayer = player;
            }
        }

        Debug.Log($"{roomPlayers}");

    }







}
