using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Type2Obstacle : Obstacle
{
    private void Start()
    {
        GetComponent<Obstacle>().lostScoreAmount = 30;
    }
}
