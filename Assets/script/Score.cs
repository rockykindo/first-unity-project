using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    int myScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = myScore.ToString();
    }

    public void AddScore(int score)
    {
        myScore = myScore + score;
    }
}
