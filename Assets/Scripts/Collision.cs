using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cola")
        {
            Destroy(other.gameObject);
            CreateInCollector.instance.CreateCola();           

        }
        if (other.gameObject.tag == "colamachine")
        {
            CreateInCollector.instance.RemoveColaList();
            Destroy(gameObject);
        }
    }
}
