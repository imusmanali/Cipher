using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CONNECTER : MonoBehaviour
{
    public bool connected = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Connecter")
        {
            connected = true;
            GameManager.Instance.check();
        }
    }
}
