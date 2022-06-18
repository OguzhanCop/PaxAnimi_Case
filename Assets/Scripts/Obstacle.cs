using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Obstacle : MonoBehaviour
{
    public float lostScoreAmount;
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "colacloneend")
        {
            other.transform.GetChild(3).GetComponent<ParticleSystem>().Play();
            Destroy(other.gameObject,0.5f);
            CreateInCollector.instance.RemoveColaList();
            DecreaseScore();
        }
        if (other.gameObject.tag == "colaclone")
        {
            CreateInCollector.instance.CollisionObstacleDispersionCola(other.transform);

        }
    }
    public void DecreaseScore()
    {
        UI.instance.DecreaseScoreText(lostScoreAmount);
        
    }
}
