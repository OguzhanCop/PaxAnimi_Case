using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveCollectorChild : MonoBehaviour
{
    bool finish=false;
    public void Start()
    {
        
    }
    public void MovePos(float moveX)
    {
        if(!finish)
        transform.DOMoveX(moveX, 0.2f);

    }
    public void MoveFinish()
    {
        finish = true;
        transform.DOMoveX(50, 2f);
    }
}
