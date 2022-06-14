using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CreateInCollector : MonoBehaviour
{
    public static CreateInCollector instance;
    public List<GameObject> cola = new List<GameObject>();
    public GameObject colaPrefab;
    void Start()
    {
        instance = this;
        DOTween.Init();
        
    }

    
    void Update()
    {
       
    }
    public void CreateCola()
    {
        GameObject stackColaClone = Instantiate(colaPrefab,transform.position+new Vector3(0,0,cola.Count+1), transform.rotation);
        stackColaClone.transform.parent = gameObject.transform;
        cola.Add(stackColaClone);
        StartCoroutine(CreateColaAnim());
    }
    IEnumerator CreateColaAnim()
    {
        for (int i = cola.Count-1; i >= 0; i--)
        {
            Vector3 scale = new Vector3(117, 117, 117);
            int index = i;
            cola[index].transform.GetChild(2).DOScale(scale*2, 0.2f).OnComplete(() =>
               cola[index].transform.GetChild(2).DOScale(scale, 0.2f));
            yield return new WaitForSecondsRealtime(0.05f);
            
        }
    }
}
