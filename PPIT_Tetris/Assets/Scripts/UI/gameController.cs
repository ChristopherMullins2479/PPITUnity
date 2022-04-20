using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gameController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI lineCount;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI levelText;

    private int linecount = 0;
    private int score = 0;
    private int level = 1;
    private int levelCounter = 1;

    //controls the line counter
    private void UpdateLineCountText()
    {
        lineCount.text = ("LINES: " + linecount.ToString("000"));
    }

    public void UpdateLineCount(int LinesCleared)
    {
        linecount += LinesCleared;
        UpdateLineCountText();
        UpdateLevel();
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

    //level controller
    private void UpdateLevelText()
    {
        levelText.text = ("LEVEL: "+level.ToString("000"));
    }

    private void UpdateLevel()
    {
        if (linecount == levelCounter+10)
        {
            level += 1;
            UpdateLevelText();
            levelCounter = linecount;
        } 
      
    }

}
