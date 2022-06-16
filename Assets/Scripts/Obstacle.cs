using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Obstacle : MonoBehaviour
{
    public float lostScoreAmount;
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "cola")
        {
            DecreaseScore();
        }
    }
    public void DecreaseScore()
    {
        UI.instance.DecreaseScoreText(lostScoreAmount);
        Debug.Log(lostScoreAmount);
    }
}
