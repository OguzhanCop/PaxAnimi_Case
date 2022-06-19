using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCollectCola : MonoBehaviour
{
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "colaclone"|| other.gameObject.tag == "colacloneend"||other.gameObject.tag=="collector")
        {
            Destroy(gameObject);
            CreateInCollector.instance.CreateCola();

        }
    }
}