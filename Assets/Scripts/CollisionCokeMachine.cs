using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCokeMachine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "colaclone")
        {
            Destroy(other.gameObject);
            CreateInCollector.instance.RemoveColaList();
        }
    }


}
