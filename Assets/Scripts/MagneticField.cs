using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagneticField : MonoBehaviour
{
    [SerializeField] float magneticForce = default;
    int collectorPos;
    private void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("CollectableCube"))
        {
            other.attachedRigidbody.AddForce((transform.position - other.transform.position) * magneticForce * Time.deltaTime);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CollectableCube"))
        {
            collectorPos++;
        }
    }

}
