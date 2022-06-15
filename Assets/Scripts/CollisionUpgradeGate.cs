using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionUpgradeGate : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "colaclone")
        {
            Destroy(other.gameObject);
            CreateInCollector.instance.UpgradeColaBottle(other.transform);

        }
    }
}
