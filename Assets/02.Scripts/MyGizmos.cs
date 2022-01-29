using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGizmos : MonoBehaviour {

    public float _radius = 0.3f;
    public Color _color = Color.yellow;

    void OnDrawGizmos(){ //Call back Function / Event Function, run mode가 아니더라도 실행.
        Gizmos.color = _color;
        Gizmos.DrawSphere(transform.position, _radius);

    }
}
