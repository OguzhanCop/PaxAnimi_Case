using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Movement : MonoBehaviour
{
    public GameObject collector;
    public GameObject characterRig;
    public float speed = 2;
    bool jumpPosCheck = false;


    void Start()
    {
        DOTween.Init();


    }
    void Update()
    {
        Move();

        TouchSlide();


    }
    void Move()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
    void TouchSlide()
    {
        if (Input.touchCount > 0)
        {
            Touch finger = Input.GetTouch(0);
            Turn(finger.deltaPosition.x);
            ClampX(transform.position);
            
        }

    }
    void ClampX(Vector3 pos)
    {
        pos.x = Mathf.Clamp(transform.position.x, 44, 52);
        transform.position = pos;
    }
    void Turn(float fingerdiff)
    {
        if (fingerdiff != 0)
        {
            transform.Translate(Mathf.Lerp(0, fingerdiff / 2, 1f * Time.deltaTime), 0, 0);
        }

    }
}
