using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionUpgradeGate : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "colaclone"|| other.gameObject.tag == "colacloneend")
        {
          
            CreateInCollector.instance.UpgradeColaBottle(other.transform);

        }
    }
}
