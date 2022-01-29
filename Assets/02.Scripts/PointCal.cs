using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PointCal : MonoBehaviour {

    public static PointCal instance = null;


    void Awake()
    {
        instance = this;
    }

    [HideInInspector]
    public AudioSource getPointSound;
    public AudioClip clipPoint;

    void Start(){
        getPointSound = GetComponent<AudioSource>();
        getPointSound.volume = 0.5f;
    }


    public float point=0.0f;

    void OnTriggerEnter(Collider coll){
        if (coll.tag == "Player")
        {
            getPointSound.PlayOneShot(clipPoint, 0.8f);
            MoveCtrl.instance.totalPoint += 100.0f;
            Debug.Log("point: " + MoveCtrl.instance.totalPoint);
        }
    }
}
