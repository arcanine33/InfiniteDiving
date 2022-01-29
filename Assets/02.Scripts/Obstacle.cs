using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Obstacle : MonoBehaviour {

    void OnCollisionEnter(Collision coll){

        //TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
        TextMeshPro textmeshPro = GameObject.FindWithTag("Endpoint").GetComponent<TextMeshPro>();

        if (coll.collider.tag == "Player")
        {
            MoveCtrl.instance.canvasObj.SetActive(true);
            //Time.timeScale = 0.0f;
            GameMgr.instance.isGameOver = true;
            Debug.Log("Game Over");
            MoveCtrl.instance.totalPoint += PointCal.instance.point;
            Debug.Log("Total Point: " + MoveCtrl.instance.totalPoint);

            textmeshPro.SetText("Game Over!! \n Total Point: " + MoveCtrl.instance.totalPoint);

        }
    }
}
