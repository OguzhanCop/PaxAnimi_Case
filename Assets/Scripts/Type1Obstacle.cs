using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Type1Obstacle : Obstacle
{
    
    private void Start()
    {
        GetComponent<Obstacle>().lostScoreAmount = 20;
        InvokeRepeating("turnAxe", 0,10f);
    }
   void turnAxe()
    {
        transform.DORotateQuaternion(Quaternion.Euler(180, 90, 90), 5f).OnComplete(() => transform.DORotateQuaternion(Quaternion.Euler(0, 90, 90), 5f));
    }
}
