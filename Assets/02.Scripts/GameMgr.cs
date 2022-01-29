using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour {

    public static GameMgr instance = null;
    public Transform[] randomPoints;
    public Transform[] randomPoints2;
    public Transform[] randomPoints3;
    private GameObject setPrefab1;
    private GameObject setPrefab2;
    private GameObject setPrefab3;
    private GameObject[] setArrayList = new GameObject[3];
    private GameObject randomSet;
    int i=0;
    int i2=0;
    int i3=0;

    public bool isGameOver = false;

	// Use this for initialization
	void Start () {
        instance = this;
        randomPoints = GameObject.Find("SpawnPointGroup").GetComponentsInChildren<Transform>();
        randomPoints2 = GameObject.Find("SpawnPointGroup2").GetComponentsInChildren<Transform>();
        randomPoints3 = GameObject.Find("SpawnPointGroup3").GetComponentsInChildren<Transform>();

        setPrefab1 = Resources.Load("Set1") as GameObject;
        setPrefab2 = Resources.Load("Set2") as GameObject;
        setPrefab3 = Resources.Load("Set3") as GameObject;

        //Debug.Log("setPrefab1: " + Resources.Load("Prefabs/Set1").name);

        setArrayList[0] = Instantiate<GameObject>(setPrefab1);
        setArrayList[1] = Instantiate<GameObject>(setPrefab2);
        setArrayList[2] = Instantiate<GameObject>(setPrefab3);
        Debug.Log("setArrayList[0] : " + setArrayList[0]);

    
        //StartCoroutine(CreateSet());

        for (int i = 0; i < randomPoints.Length; i++)
        {
            CreateSet(i);
            CreateSet2(i);
            CreateSet3(i);
        } 


	}
    void CreateSet(int idx){
       // yield return new WaitForSeconds(2.0f);
       

        //int idx = Random.Range(1, randomPoints.Length);
        int randomSetNumber = Random.Range(0, setArrayList.Length);
        randomSet = setArrayList[randomSetNumber];
        i = Random.Range(0, 4);
        Quaternion rot = Quaternion.Euler(0, i * 90, 0);
        Debug.Log("randomSetNumber: " + randomSetNumber);
        Debug.Log("setArrayList[randomSetNumber] : " + setArrayList[randomSetNumber].name);

        GameObject obj = Instantiate<GameObject>(randomSet, randomPoints[idx].position, rot ); 
        obj.transform.SetParent(randomPoints[0]);
    }

    void CreateSet2(int idx){
        // yield return new WaitForSeconds(2.0f);


        //int idx = Random.Range(1, randomPoints.Length);
        int randomSetNumber = Random.Range(0, setArrayList.Length);
        randomSet = setArrayList[randomSetNumber];
        i2 = Random.Range(0, 4);
        Quaternion rot = Quaternion.Euler(0, i * 90, 0);
        Debug.Log("randomSetNumber: " + randomSetNumber);
        Debug.Log("setArrayList[randomSetNumber] : " + setArrayList[randomSetNumber].name);

        GameObject obj = Instantiate<GameObject>(randomSet, randomPoints2[idx].position, rot );   
        obj.transform.SetParent(randomPoints2[0]);
    }

    void CreateSet3(int idx){
        // yield return new WaitForSeconds(2.0f);


        //int idx = Random.Range(1, randomPoints.Length);
        int randomSetNumber = Random.Range(0, setArrayList.Length);
        randomSet = setArrayList[randomSetNumber];
        i3 = Random.Range(0, 4);
        Quaternion rot = Quaternion.Euler(0, i * 90, 0);
        Debug.Log("randomSetNumber: " + randomSetNumber);
        Debug.Log("setArrayList[randomSetNumber] : " + setArrayList[randomSetNumber].name);

        GameObject obj = Instantiate<GameObject>(randomSet, randomPoints3[idx].position, rot );  
        obj.transform.SetParent(randomPoints3[0]);
    }
	
	// Update is called once per frame
//	void Update () {
//		
//	}

}
