﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCtrl : MonoBehaviour {

    //private GameObject posRandomPoints;


    void OnTriggerEnter(Collider coll){
        if (coll.tag == "Player")
        {
            //posRandomPoints = GameObject.Find("SpawnPointGroup");

            //posRandomPoints.transform.Translate(0, -150, 0);
            GameObject.Find("SpawnPointGroup").transform.Translate(0, -150, 0);
            Debug.Log("check");
            //posRandomPoints.transform.Translate(0, -150, 0);

        }
    }
}
