using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


//this allows the ui to change 
public class gameController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI lineCount;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private TextMeshProUGUI gameOverPoints;

    private int linecount = 0;
    private int score = 0;
    public int tolalScore = 0;
    private int level = 1;
    private int levelCounter = 1;
    private int levelPoints = 2500;

    public int lines;

    public Piece p;

    //controls the line counter
    private void UpdateLineCountText()
    {
        lineCount.text = ("LINES: " + linecount.ToString("000"));
    }

    public void UpdateLineCount(int LinesCleared)
    {
        linecount += LinesCleared;
        UpdateLineCountText();
        lines = linecount;
        UpdateLevel();
    }

    //controlls the score 
    private void UpdateScoreText()
    {
        scoreText.text = (score.ToString("00000000"));
        print(score);
    }

    public void UpdateScore(int points)
    {
        score += points;
        tolalScore = tolalScore + points;
        UpdateScoreText();
    }

    //level controller
    private void UpdateLevelText()
    {
        levelText.text = ("LEVEL: "+level.ToString("000"));

        //will up speed untill level 10
        //then the speed will stop increassing
        if(level <= 10)
        {
            p.stepDelay = p.stepDelay - 0.1f;
        }
        else
        {

        }
        
    }

    private void UpdateLevel()
    {
        if (linecount == levelCounter + 10)
        {
            level += 1;
            UpdateLevelText();
            levelCounter = linecount;
            UpdateScore(levelPoints);
        }

    }

    public void returnScore()
    {
        gameOverPoints.text = ("Score : "+score.ToString("00000000"));
        print("Last Score " + score);
    }


}
