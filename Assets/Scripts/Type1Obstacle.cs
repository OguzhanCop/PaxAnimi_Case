using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Type1Obstacle : Obstacle
{
    
    private void Start()
    {
        GetComponent<Obstacle>().lostScoreAmount = 20;
    }

}
