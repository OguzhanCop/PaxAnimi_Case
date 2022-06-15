using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CreateInCollector : MonoBehaviour
{
    public static CreateInCollector instance;
    public List<GameObject> cola = new List<GameObject>();
    public GameObject colaPrefab;
    public GameObject colaBottlePrefab;
    void Start()
    {
        instance = this;
        DOTween.Init();
        
        
    }

    
    void Update()
    {
        MoveColaPrefab();
    }
    public void CreateCola()
    {
        GameObject stackColaClone = Instantiate(colaPrefab,transform.position+new Vector3(0,0,cola.Count+1), transform.rotation);
        stackColaClone.transform.parent = gameObject.transform;
        cola.Add(stackColaClone);
        UI.instance.AddScore(10);
        StartCoroutine(CreateColaAnim());
    }
    IEnumerator CreateColaAnim()
    {
        for (int i = cola.Count-1; i >= 0; i--)
        {
            int index = i;
            if (cola[index].transform.GetChild(0).gameObject.activeSelf)
            {
                Vector3 scale = new Vector3(117, 117, 117);

                cola[index].transform.GetChild(0).GetChild(2).DOScale(scale * 2, 0.2f).OnComplete(() =>
                cola[index].transform.GetChild(0).GetChild(2).DOScale(scale, 0.2f));
                yield return new WaitForSecondsRealtime(0.05f);
            }

            if (cola[index].transform.GetChild(1).gameObject.activeSelf)
            {
                Vector3 scale = new Vector3(0.3f, 0.3f, 0.3f);

                cola[index].transform.GetChild(1).DOScale(scale * 2, 0.2f).OnComplete(() =>
                cola[index].transform.GetChild(1).DOScale(scale, 0.2f));
                yield return new WaitForSecondsRealtime(0.05f);
            }

            if (cola[index].transform.GetChild(2).gameObject.activeSelf)
            {
                Vector3 scale = new Vector3(0.1f, 0.1f, 0.1f);

                cola[index].transform.GetChild(2).GetChild(0).DOScale(scale * 2, 0.2f).OnComplete(() =>
                cola[index].transform.GetChild(2).GetChild(0).DOScale(scale, 0.2f));
                yield return new WaitForSecondsRealtime(0.05f);
            }



        }
    }
    
    void MoveColaPrefab()
    {
            for (int i = 1; i < cola.Count; i++)
            {
                cola[i].GetComponent<MoveCollectorChild>().MovePos(cola[i - 1].transform.position.x);
            }
        
       
    }
    public void RemoveColaList()
    {
        cola.RemoveAt(cola.Count - 1);
    }
    public void UpgradeColaBottle(Transform pos)
    {
        int index = (int)(pos.localPosition.z / 3.3f);
        if (cola[index - 1].transform.GetChild(1).gameObject.activeSelf)
        {
            UI.instance.AddScore(20);
            cola[index - 1].transform.GetChild(1).gameObject.SetActive(false);
            cola[index - 1].transform.GetChild(2).gameObject.SetActive(true);
        }
        if (cola[index - 1].transform.GetChild(0).gameObject.activeSelf)
        {
            UI.instance.AddScore(10);
            cola[index - 1].transform.GetChild(0).gameObject.SetActive(false);
            cola[index - 1].transform.GetChild(1).gameObject.SetActive(true);
        }
      


    }
}
