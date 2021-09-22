using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{

    public Snake segments;
    public Text scoreText;
    public Text highscoreText;
    public List<int> highScore = new List<int>();

    void Update()
    {
        scoreText.text = "SCORE: " + (segments._segments.Count - 3).ToString();
    }

    public void HighScoreUpdate(int newScore)
    {
        highScore.Add(newScore);
        highScore.Sort();
        highScore.Reverse();
        highscoreText.text = "HIGHSCORE\n" + string.Join("\n", highScore).ToString();
    }
}
