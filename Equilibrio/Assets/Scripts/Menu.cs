using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }
}
