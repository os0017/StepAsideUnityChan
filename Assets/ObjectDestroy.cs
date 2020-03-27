using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour{
    //Unityちゃんとオブジェクト
    private GameObject unitychan;
    //Unityちゃんとカメラの距離
    private float difference;

    // Use this for initialization
    void Start (){

    }
	
	// Update is called once per frame
	void Update ()    {
        //Unityちゃんが通り越したオブジェクトを破棄（課題）
        if (gameObject.transform.position.z < Camera.main.gameObject.transform.position.z)
        {
            Destroy(gameObject);
        }

    }
}
