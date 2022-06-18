using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDispersedCola : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (transform.parent != null)
        {
            if (other.gameObject.tag == "disperedcola")
            {
                Debug.Log("asd");
                CreateInCollector.instance.DispersedColaAdd(other.gameObject);
            }

        }
    }
}
