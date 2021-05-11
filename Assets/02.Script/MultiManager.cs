using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hashtable = ExitGames.Client.Photon.Hashtable;
using Photon.Pun;
using Photon.Realtime;




public class MultiManager : MonoBehaviourPunCallbacks
{


    public Hashtable ht = new Hashtable();
    private PhotonView pv;



    void Start()
    {
        


    // ht.Add($"Player1 {0}번째 카드",$"Drow {0}");
    // ht.Add($"Player2 {0}번째 카드",$"Drow {0}");
    // ht.Add($"Player3 {0}번째 카드",$"Drow {0}");
    // ht.Add($"Player4 {0}번째 카드",$"Drow {0}");


        ht.Add("Player1", $"Drow {0}");





    PhotonNetwork.SetPlayerCustomProperties(ht);

    }





    public override void OnPlayerPropertiesUpdate(Photon.Realtime.Player targetPlayer,
                                                ExitGames.Client.Photon.Hashtable changedProps)
    {
        Debug.Log("");

        Debug.Log($"target = {targetPlayer}, change = {changedProps}");

	// if (변경된 값의 사람 것만 찾아서 변경? 저도 이건 디버그 로그보면서 변경했어욤)

Hashtable ht = targetPlayer.CustomProperties;
    // playerPoint = ht["Point"]

        if ( pv.Owner == targetPlayer )
        {
            // Instantiate<GameObject>(character, tr);
        }
    



    }







}
