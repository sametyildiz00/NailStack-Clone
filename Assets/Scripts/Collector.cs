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
        transform.localPosition = new Vector3(collectorPos, 0, 0);
    }

    public void decreaseCollecterPos()
    {
        collectorPos--;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CollectableCube" && other.gameObject.GetComponent<CollectableCube>().GetIsCollected()==false)
        {
            collectorPos++;
            other.GetComponent<CollectableCube>().Collected();
            other.GetComponent<CollectableCube>().setIndex(collectorPos);
            other.gameObject.transform.parent = player.transform;
        }
    }
}
