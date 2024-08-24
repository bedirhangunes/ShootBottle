using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Target"))
        {
            //hit object name print
            print("hit " + col.gameObject.name + " !");
            //after destroy
            Destroy(gameObject);
        }
    }
}
