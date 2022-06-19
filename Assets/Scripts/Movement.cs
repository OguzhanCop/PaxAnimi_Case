using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Movement : MonoBehaviour
{
    public static Movement instance;
    public float speed =2;  


    void Start()
    {
        DOTween.Init();
        instance = this;

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
    public void death()
    {
        transform.GetChild(2).GetComponent<Animator>().SetTrigger("death");
        speed = 0;
        Invoke("FailedLevel", 2f);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "colamachine")
        {           
            transform.DOMoveZ(transform.position.z - 20, 1f, false);
        }
    }
    public void FailedLevel()
    {
        UI.instance.LosePanel();

    }
}
