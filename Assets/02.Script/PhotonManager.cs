using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine.UI;





public class PhotonManager : MonoBehaviourPunCallbacks
{



    private readonly string gameVersion = "v1.0";
    private string userId = "User_07";

    public TMP_InputField roomNameText;













    void Awake()
    {


        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.GameVersion = gameVersion;
        

        PhotonNetwork.ConnectUsingSettings();


    }



    void Start()
    {
        userId = PlayerPrefs.GetString("USER_ID", $"USER_{Random.Range(0,100) :00}");
        
    }








    public override void OnConnectedToMaster()
    {
        Debug.Log("서버 접속!!");

        PhotonNetwork.JoinLobby();

    }



    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();
        {
            Debug.Log("로비 접속!!");
        }
    }



    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log($"code={returnCode}, msg ={message}");
        
        RoomOptions ro = new RoomOptions();
        ro.IsOpen =true;
        ro.IsVisible = true;
        ro.MaxPlayers = 4;


        if (string.IsNullOrEmpty(roomNameText.text))
        {
            roomNameText.text = $"ROOM_{Random.Range(1,100):000}";
        }
        
        PhotonNetwork.CreateRoom(roomNameText.text, ro);
    }



    public override void OnCreatedRoom()
    {
        Debug.Log("방 생성!!");
    }



    public override void OnJoinedRoom()
    {
        Debug.Log("방 접속!!");
        // Debug.Log(PhotonNetwork.CurrentRoom.Name);


        // if(PhotonNetwork.IsMasterClient)
        // {

        PhotonNetwork.LoadLevel("PlayScene");
        // }

    }



    public void OnLoginClick()
    {

        PhotonNetwork.CreateRoom(roomNameText.text);

        PhotonNetwork.JoinRandomRoom();

    }





}
