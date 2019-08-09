using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class ScoreTracker
{
    private static int score;
    public static bool increment = false;

    public static void increaseScore()
    {
        score = score + 1;
    }

    public static int getScore()
    {
        return score;
    }

    public static void setScore(int newScore)
    {
        score = newScore;
    }

    public static void setHighScore(int newScore)
    {

        if (newScore > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", newScore);
        }
    }

    public static int getHighScore()
    {
        return PlayerPrefs.GetInt("highScore");
    }

}
