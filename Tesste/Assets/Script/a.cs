using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a : MonoBehaviour {
    public float vel = 2.5f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(vel * Time.deltaTime, 0));
    }
}
