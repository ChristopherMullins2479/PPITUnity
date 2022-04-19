using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gameController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI lineCount;
    [SerializeField] private TextMeshProUGUI scoreText;

    private int linecount = 0;
    private int score = 0;


    //controls the line counter
    private void UpdateLineCountText()
    {
        lineCount.text = ("LINES: " + linecount.ToString("000"));
    }

    public void UpdateLineCount(int LinesCleared)
    {
        linecount += LinesCleared;
        UpdateLineCountText();
    }

    //controlls the score 
    private void UpdateScoreText()
    {
        scoreText.text = (score.ToString("00000000"));
    }



    public void UpdateScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

}
