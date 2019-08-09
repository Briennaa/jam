using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClicks : MonoBehaviour
{
    public GameObject pauseMenu;

    public void loadMugWorld()
    {
        SceneManager.LoadScene("MugWorld");
        ScoreTracker.setScore(0);
        Pause.setPause(false);
    }

    public void loadMenuWorld()
    {
        ScoreTracker.setScore(0);
        SceneManager.LoadScene("MenuWorld");
    }

    public void loadLoserWorld()
    {
        ScoreTracker.setScore(0);
        SceneManager.LoadScene("LoserWorld");
    }

    public void loadShopWorld()
    {
        SceneManager.LoadScene("ShopWorld");
    }

    public void loadSettingsWorld()
    {
        SceneManager.LoadScene("SettingsWorld");
    }

    public void loadTrophyWorld()
    {
        SceneManager.LoadScene("TrophyWorld");
    }

    public void onPauseButtonClick()
    {
        Pause.setPause(true);
        pauseMenu.SetActive(true);
    }

    public void onPauseButtonClose()
    {
        Pause.setPause(false);
        pauseMenu.SetActive(false);
    }
}
