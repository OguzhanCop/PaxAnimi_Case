using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCollectCola : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cola")
        {
            Destroy(other.gameObject);
            CreateInCollector.instance.CreateCola();

        }
    }
}