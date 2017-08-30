using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poligon : MonoBehaviour
{
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

    }

    public void Rotate()
    {
        transform.Rotate(new Vector3(0, 0, -1) * Speed * Time.deltaTime, 60);
    }
}
