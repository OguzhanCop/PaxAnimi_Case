using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveCollectorChild : MonoBehaviour
{
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MovePos(float moveX)
    {
        transform.DOMoveX(moveX, 0.2f);

    }
}
