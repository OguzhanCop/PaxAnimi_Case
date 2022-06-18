using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CollisionFinish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "colaclone"|| other.gameObject.tag == "colacloneend")
        {

            other.transform.SetParent(null);
            other.GetComponent<MoveCollectorChild>().MoveFinish();

        }
        if (other.gameObject.tag == "collector")
        {
            UI.instance.WinPanel();

        }
    }
}
