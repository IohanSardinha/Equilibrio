using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ovo : MonoBehaviour {

    public Text pontos;
    float score = 0;
    float time = 0;
    float realTime = 0;
    SpriteRenderer currentSprite;
    public Sprite ovo1;
    public Sprite ovo2;
    public Sprite ovo3;
    void Start()
    {
        currentSprite = gameObject.GetComponent<SpriteRenderer>();
    }
    void FixedUpdate()
    {
        time += Time.deltaTime;
        realTime += Time.deltaTime;
        float curScore = Mathf.Abs((180 - transform.eulerAngles.z) / 10);
        if(curScore >= 12)
        {
            currentSprite.sprite = ovo1;
        }
        else if(curScore >= 6)
        {
            currentSprite.sprite = ovo2;
        }
        else
        {
            currentSprite.sprite = ovo3;
        }
        if (time >= 2)
        {
            score += curScore;
            pontos.text = Mathf.RoundToInt(score).ToString();
            time = 0;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "chao")
        {
            PlayerPrefs.SetInt("score", Mathf.RoundToInt(score * realTime/4));
            SceneManager.LoadScene("GameOver");
        }
    }
}
