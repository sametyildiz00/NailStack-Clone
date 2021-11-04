using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    GameObject player;
    int collectorPos;
    

    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        //transform.localPosition = new Vector3(collectorPos, 0, 0);
    }

    public void decreaseCollecterPos()
    {
        collectorPos--;
    }
}
