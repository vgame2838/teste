using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class o : MonoBehaviour {

        public GameObject bala;
        public GameObject cano;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                Instantiate(bala, new Vector3(cano.transform.position.x, cano.transform.position.y, cano.transform.position.z), cano.transform.rotation);
            }
        }
    }