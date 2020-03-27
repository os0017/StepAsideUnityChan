using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {
    //carprefabを入れる
    public GameObject carprefab;
    //coinprefabを入れる
    public GameObject coinprefab;
    //conprefabを入れる
    public GameObject coneprefab;
    //スタート地点
    private float startpos = -160;
    //ゴール地点
    private int goalpos = 120;
    //アイテムを出すX方向の範囲
    private float posRange = 3.4f;

    //Unityちゃんとオブジェクト（発展課題）
    private GameObject unitychan;

    // Use this for initialization
    void Start () {
        //Unityちゃんのオブジェクトを取得（発展課題）
        this.unitychan = GameObject.Find("unitychan");

        startpos = unitychan.transform.position.z;

        ////一定の距離ごとにアイテムを生成
        //for (int i = startpos; i < goalpos; i　+= 15)
        //{
        //    //どのアイテムを出すのかランダムに設定
        //    int num = Random.Range(1, 11);
        //    if(num <= 2)
        //    {
        //        //コーンをX軸方向に一直線に生成
        //        for(float j = -1; j <= 1; j += 0.4f)
        //        {
        //            GameObject cone = Instantiate(coneprefab) as GameObject;
        //            cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
        //        }
        //    }
        //    else
        //    {
        //        //レーンごとにアイテムを生成
        //        for(int j = -1; j <= 1; j++)
        //        {
        //            //アイテムの種類を決める
        //            int item = Random.Range(1, 11);
        //            //アイテムを置くZ座標のオフセットをランダムに設定
        //            int offsetZ = Random.Range(-5, 6);
        //            //60%コイン配置:30%車配置:10%何もなし
        //            if(1 <= item && item <= 6)
        //            {
        //                //コインを生成
        //                GameObject coin = Instantiate(coinprefab) as GameObject;
        //                coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, i + offsetZ);
        //            }else if(7 <= item && item <= 9)
        //            {
        //                //車を生成
        //                GameObject car = Instantiate(carprefab) as GameObject;
        //                car.transform.position = new Vector3(posRange * j, car.transform.position.y, i + offsetZ);
        //            }
        //        }
        //    }
        //}

    }
	
	// Update is called once per frame
	void Update () {
        //UNITYちゃんのスタート位置から15m先にアイテムを生成（発展課題）
        if (unitychan.transform.position.z >= startpos + 15)
        {
            //Unityちゃんが15m進んだら繰り返し40m先にアイテムを生成（発展課題）
            startpos = unitychan.transform.position.z;
            float i = startpos + 40;
                //どのアイテムを出すのかランダムに設定
                int num = Random.Range(1, 11);
            if (num <= 2)
            {
                //コーンをX軸方向に一直線に生成
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(coneprefab) as GameObject;
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                }
            }
            else
            {
                //レーンごとにアイテムを生成
                for (int j = -1; j <= 1; j++)
                {
                    //アイテムの種類を決める
                    int item = Random.Range(1, 11);
                    //アイテムを置くZ座標のオフセットをランダムに設定
                    int offsetZ = Random.Range(-5, 6);
                    //60%コイン配置:30%車配置:10%何もなし
                    if (1 <= item && item <= 6)
                    {
                        //コインを生成
                        GameObject coin = Instantiate(coinprefab) as GameObject;
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if (7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carprefab) as GameObject;
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, i + offsetZ);
                    }
                }
            }

        }
		
	}
}
