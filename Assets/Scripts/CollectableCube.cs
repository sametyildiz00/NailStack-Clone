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
        if(isCollected == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(index, 0, 0);
            }
        }
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

    public void setIndex (int index)
    {
        this.index = index;
    }

}
