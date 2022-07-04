using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    int scoreValue;
    public GameObject prefabs;

    public void Update()
    {
        scoreText.text = scoreValue.ToString();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "BoxMini")
        {
            Destroy(col.gameObject);
            scoreValue++;
            StartCoroutine(Respawn(3));
        }
    }

    IEnumerator Respawn(float sec)
    {
        yield return new WaitForSeconds(sec);
        Instantiate(prefabs, new Vector2(Random.Range(6.32f, -6.32f), Random.Range(3.37f, -3.37f)), Quaternion.identity);
    }
}
