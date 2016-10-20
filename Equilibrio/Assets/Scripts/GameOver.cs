using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    public Text score;

    void Start()
    {
        score.text = PlayerPrefs.GetInt("score") + " Pontos";
    }

	public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
