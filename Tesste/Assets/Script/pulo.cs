using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulo : MonoBehaviour {
    public float forca = 500;
    public int duplo = 2;
    public Rigidbody2D bola;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(duplo > 0)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                bola.AddForce(new Vector2(0, forca * Time.deltaTime), ForceMode2D.Impulse);
                duplo--;
            }
        }
	}
    private void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("chao"))
        {
            duplo = 2;
        }
    }
}
