using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using System.Linq;






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


            roomPlayers = PhotonNetwork.CurrentRoom.Players;
        



        List<Player> a = PhotonNetwork.CurrentRoom.Players.Values.ToList<Player>();

        Debug.Log($"{roomPlayers}");

    }







}
