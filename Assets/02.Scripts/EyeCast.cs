using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EyeCast : MonoBehaviour {

    //public static EyeCast instance = null;

    private Transform camTr;
    private Animator anim;

    public Ray ray;
    private RaycastHit hit;

    private int setLayer;
    private int restartLayer;
    private int gazeHash;

    private GameObject Set;

    public float selectTime = 1.0f;
    private float passedTime = 0.0f;
    private Image crossHair;

    public bool isLookAtBlock = false;
    public bool firstTime = true;

    private GameObject Player;
    private Collider startCollider;


    void Start () {
        camTr = Camera.main.transform; // transform     
        anim = GameObject.Find("CrossHair").GetComponent<Animator>();
 
        gazeHash = Animator.StringToHash("isGaze");
        Player = GameObject.Find("Player");
        startCollider = GameObject.Find("Start").GetComponent<Collider>();
        setLayer = 1 << LayerMask.NameToLayer("SET");
        restartLayer = 1 << LayerMask.NameToLayer("RESTART");


        LookAtBlock();

    }

    // Update is called once per frame
    void Update () {
       ray = new Ray(camTr.position, camTr.forward * 15.0f);
        Debug.DrawRay(ray.origin, ray.direction * 15.0f, Color.green);

       LookAtBlock();
       LookRestart();

    }

    void LookAtBlock(){
        PointerEventData data = new PointerEventData(EventSystem.current);

        if (Physics.Raycast(ray, out hit, 15.0f, setLayer))
        {
            Set = hit.collider.gameObject;
            isLookAtBlock = true;
            crossHair = GameObject.Find("CrossHair").GetComponent<Image>();

            if (isLookAtBlock = true && firstTime == true)
            {
                //Player.transform.Rotate(90, 0, 0);
                Debug.Log("gaze block");
                passedTime += Time.deltaTime;
                crossHair.fillAmount = passedTime / selectTime;
                Debug.Log("gaze block2");
                if (passedTime >= selectTime)
                {
                    Debug.Log("gaze block finish");
                    startCollider.isTrigger = true; 
                    firstTime = false;
                    MoveCtrl.instance.isJump = true;
                   // ExecuteEvents.Execute(crossHair, data, ExecuteEvents.pointerClickHandler );
                }


            }
        }
    }

    void LookRestart(){
        if (Physics.Raycast(ray, out hit, 15.0f, restartLayer))
        {
            Debug.Log("Restart1");
            Restart.instance.onRestart();
            Debug.Log("Restart2");
        }

    }

}
