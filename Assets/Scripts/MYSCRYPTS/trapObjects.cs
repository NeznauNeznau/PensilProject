using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapObjects : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.constraints = RigidbodyConstraints.None;
            }
        }
    }
}
