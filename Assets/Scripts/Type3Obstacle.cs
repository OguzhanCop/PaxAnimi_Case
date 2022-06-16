using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Type3Obstacle : Obstacle
{
    private void Start()
    {
        GetComponent<Obstacle>().lostScoreAmount = 40;
    }
}
