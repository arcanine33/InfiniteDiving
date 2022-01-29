using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class MoveCtrl : MonoBehaviour {

    public static MoveCtrl instance = null;
    public float totalPoint = 0.0f;

    void Awake()
    {
        instance = this;
    }

    public enum MoveType
    {
        LOOK_AT,
        DAYDREAM
    }

    public MoveType moveType = MoveType.LOOK_AT;
    public float speed = 10.0f;
    //public bool isStopped = false;
    //public bool isLookAtBlock = false;
    private GameObject Player;

    private Transform camTr;
    private Transform playerTr;
    private CharacterController cc;

    //private Rigidbody rb;
    public float damage = 20.0f;
    public Vector3 dir;

    public bool isJump = false;
    public GameObject canvasObj;


    void Start () {
        camTr = Camera.main.transform; //GetComponentInChildren<Transform>();
    }

    void Update () {
        if (GameMgr.instance.isGameOver)
        {
            this.enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            return;
        }
        
        if (isJump) Move();
        

    }

    public void Move(){


        Vector3 dir = transform.TransformDirection(camTr.forward);
        dir = new Vector3(-dir.x, dir.y, dir.z);
        transform.Translate(dir * Time.deltaTime * -5.0f);
    }


}
