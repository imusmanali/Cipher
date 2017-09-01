using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poligon : MonoBehaviour
{

    Quaternion newRotation;
    



    float Speed = 1f;
    public Transform fromRotation;
    public Transform toRotation;
    int angle = -60;
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 0.8f);
        Debug.Log("Rotating");
    }

    public void Rotate()
    {
        transform.Rotate(new Vector3(0, 0, -1) * Speed * Time.deltaTime, 60);
    }

    public void SmoothRotate()
    {
        newRotation = transform.rotation * Quaternion.AngleAxis(60, Vector3.back);
       // Debug.Log(newRotation.eulerAngles.z % 60);
    }
}
