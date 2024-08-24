using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showHide : MonoBehaviour
{
    public GameObject[] bottl;
    public int bottleObject;
   
 void Start()
    {
       
       StartCoroutine(hideAllCards());
        
    }
    IEnumerator hideAllCards()
    {
        bool active = true;
        while(active){
            foreach (var bott in bottl)
            {
                bott.SetActive(!bott.activeSelf);
                yield return new WaitForSeconds(Random.Range(0f, 1f));
            }

        }

    }
}
