using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpingCub : MonoBehaviour {

    Quaternion newRotation;
    int Mousepressed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            newRotation = transform.rotation * Quaternion.AngleAxis(60, Vector3.back);
            Debug.Log(newRotation.eulerAngles.z % 60);


        }
        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, 0.8f);
        Debug.Log("totating");

        //if (Input.GetMouseButtonDown(0))
        //{
        //    Mousepressed++;
        //}

        //if (Mousepressed > 0&& (transform.rotation.eulerAngles.z % 60==0))
        //{
        //    Mousepressed--;
        //    newRotation = transform.rotation * Quaternion.AngleAxis(60, Vector3.back);
        //    Debug.Log(newRotation.eulerAngles.z % 60);
        //}

        //transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, 0.5f);

    }
}
