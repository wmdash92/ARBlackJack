using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowCtrl : MonoBehaviour
{





    private Transform ThrowTr;
    public Transform ThrowPos;
    public Transform FacePos;
    public GameObject CakePrefab;








    void Start()
    {
        // FaceTr = GameObject.FindGameObjectWithTag("FACE").GetComponent<Transform>();
        ThrowTr = GetComponent<Transform>();
    
    }





    void Update()
    {

        // Vector3 FaceVec = new Vector3(FaceTr.position.x, ThrowTr.position.y, FaceTr.position.z);

        // ThrowTr.LookAt(FacePos);

        // Debug.Log(FacePos.position);
    

    }



    public void NewBlack()
    {
    faceColor.GetComponent<FaceColor>().BlackColor();

    }
    public void NewWhite()
    {
        
    faceColor.GetComponent<FaceColor>().WhiteColor();
    }




    public GameObject faceColor;

    public void OnClickThrow()
    {
        Instantiate(CakePrefab,transform.position, transform.rotation);
        // Instantiate(CakePrefab,ThrowPos.position, ThrowPos.rotation);

        Invoke("NewBlack", 0.5f);
        Invoke("NewWhite", 1.5f);
        // faceColor.GetComponent<FaceColor>().BlackColor()


    }








}
