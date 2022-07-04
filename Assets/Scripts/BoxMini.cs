using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class BoxMini : MonoBehaviour
{

    public GameObject prefabs;

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Bola")
        {
            
            

            StartCoroutine(Respawn(3));
        }
    }

    IEnumerator Respawn(float sec)
    {
        
        yield return new WaitForSeconds(sec);
        Instantiate(prefabs, new Vector2(Random.Range(6.32f, -6.32f), Random.Range(3.37f, -3.37f)), Quaternion.identity);
    }
}
