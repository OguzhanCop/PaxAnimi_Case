using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionUpgradeGate : MonoBehaviour
{
    public GameObject colaMachine;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "colaclone"|| other.gameObject.tag == "colacloneend")
        {
          
            CreateInCollector.instance.UpgradeColaBottle(other.transform);
            colaMachine.transform.position = new Vector3(colaMachine.transform.position.x, -2, colaMachine.transform.position.z);

        }
    }
}
