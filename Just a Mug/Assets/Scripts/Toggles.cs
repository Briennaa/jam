using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggles : MonoBehaviour
{
    public Toggle musicBox;
    public Toggle soundBox;

    // Start is called before the first frame update
    void Start()
    {
        //Prefs start out 0 but we want the music to start out on so 0 = on for toggles, deal with it
        if(PlayerPrefs.GetInt("Sound") != 1)
        {
            soundBox.isOn = true;
        }
        else
        {
            soundBox.isOn = false;
        }

        if (PlayerPrefs.GetInt("Music") != 1)
        {
            musicBox.isOn = true;
        }
        else
        {
            musicBox.isOn = false;
        }

        soundBox.onValueChanged.AddListener((value) =>
        {
            MySoundListener(value);
        });
        musicBox.onValueChanged.AddListener((value) =>
        {
            MyMusicListener(value);
        });
    }

    public void MySoundListener(bool value)
    {
        if (value)
        {
            //do the stuff when the toggle is on
            PlayerPrefs.SetInt("Sound", 0);
        }
        else
        {
            //do the stuff when the toggle is off
            PlayerPrefs.SetInt("Sound", 1);
        }

    }

    public void MyMusicListener(bool value)
    {
        if (value)
        {
            //do the stuff when the toggle is on
            PlayerPrefs.SetInt("Music", 0);
        }
        else
        {
            //do the stuff when the toggle is off
            PlayerPrefs.SetInt("Music", 1);
        }

    }
}
