using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject GameOverPanel;    
    public void gameOver()
    {
        GameOverPanel.SetActive(true);
    }
}
