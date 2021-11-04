using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCube : MonoBehaviour
{
    bool isCollected;
    public int index;
    public Collector collector;

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            collector.decreaseCollecterPos();
            Destroy(this.gameObject);
        }
    }

    public bool GetIsCollected()
    {
        return isCollected;
    }

    public void Collected()
    {
        isCollected = true;
    }
    public void setIndex(int index)
    {
        this.index = index;
    }

}
