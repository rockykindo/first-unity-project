using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject GameOverPanel;    
    public void gameOver()
    {
        GameOverPanel.SetActive(true);
    }

    public void restart()
    {
        SceneManager.LoadScene("GameScene");
    }
}
