using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioSource music;

    void Awake()
    {

        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if (objs.Length > 1)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Music") == 1)
        {
            music.volume = 0;
        }
        else
        {
            music.volume = 1;
        }

        Debug.Log(music.volume);
    }
}
