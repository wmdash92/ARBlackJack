using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceColor : MonoBehaviour
{

    Renderer faceColor;


        public static FaceColor instance;



    void Start()
    {
        faceColor = gameObject.GetComponent<Renderer>();
    }





    // Update is called once per frame
    void Update()
    {
        


        


    }


    public void BlackColor()
    {
        
        faceColor.material.color = new Color(94/255f,43/255f,21/255f);
        // faceColor.material.color = Color.black;
    }

    public void WhiteColor()
    {
        
        // faceColor.material.color = Color.white;
        faceColor.material.color = new Color(251/255f,206/255f,177/255f);

    }







}
