using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    //initial gameSetup
    public GameObject mainLevel;
    public GameObject[] usedPoligons;
    public GameObject[] unusedPoligons;
    public int[] rotatonAngles;
    public int[] levelOrentationn = new int[] { 1,-1 };


    //conditoin check
    public GameObject[] connectors;
    public bool condition = false;


    //singleton
    private static GameManager instance = null;
    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }



    private void Awake()
    {
        
        // if the singleton hasn't been initialized yet
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);
        InitialConditions();
    }
    // Use this for initialization
    void Start()
    {
        connectors = GameObject.FindGameObjectsWithTag("Connecter");

       
    }

    // Update is called once per frame
    void Update()
    {


        //if (Input.GetMouseButtonUp(0))
        //{
        //    check();
        //}
    }



    public void check()
    {
        if (condition == true)
        {
            return;
        }


        Debug.Log("Test Complete");
        foreach (GameObject connector in connectors)
        {
            if (connector.GetComponent<CONNECTER>().connected == false)
            {
                condition = false;
                return;
            }

        }

        condition = true;
    }

    void InitialConditions()
    {
        int i = Random.Range(0, levelOrentationn.Length);
        int j = Random.Range(0, levelOrentationn.Length);

        Vector3 newScale=mainLevel.transform.localScale;
        newScale.x *= levelOrentationn[i];
        newScale.y *= levelOrentationn[j];
        mainLevel.transform.localScale = newScale;


        foreach (GameObject poligon in usedPoligons)
        {
            int k = Random.Range(0, rotatonAngles.Length);

           poligon.transform.Rotate(new Vector3(0, 0, 1), rotatonAngles[k]);
        }
    }
}
