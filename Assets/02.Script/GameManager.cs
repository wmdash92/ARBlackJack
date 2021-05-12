using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using System.Linq;
using Hashtable = ExitGames.Client.Photon.Hashtable;






public class GameManager : MonoBehaviourPunCallbacks
{

    

    public Hashtable ht = new Hashtable();




    void Start()
    {
        
    }







    void Update()
    {
        



    }


    private Dictionary <int, Player> roomPlayers = new Dictionary<int, Player>();




    public void CardCount()
    {




        Debug.Log($"current player is = {PhotonNetwork.CountOfPlayers}");

        Debug.Log($"now room player is = {PhotonNetwork.PlayerList.Count()}");



        


        Debug.Log($"player  {PhotonNetwork.CurrentRoom.Players.Values} hello s");



        List<Player> playerList = PhotonNetwork.CurrentRoom.Players.Values.ToList<Player>();
        Debug.Log($"hello {playerList}");


        

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
        

            Debug.Log($"win {winPlayer}");

    }






    public override void OnPlayerPropertiesUpdate(Photon.Realtime.Player targetPlayer,
                                                ExitGames.Client.Photon.Hashtable changedProps)
        {
            Debug.Log("hello");

            Debug.Log($"target = {targetPlayer}, change = {changedProps}");


        }


}
