using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCtrl2 : MonoBehaviour {


    void OnTriggerEnter(Collider coll){
        if (coll.tag == "Player")
        {
            //posRandomPoints = GameObject.Find("SpawnPointGroup");

            //posRandomPoints.transform.Translate(0, -150, 0);
            GameObject.Find("SpawnPointGroup2").transform.Translate(0, -150, 0);
            Debug.Log("check2");
            //posRandomPoints.transform.Translate(0, -150, 0);

        }
    }
}
