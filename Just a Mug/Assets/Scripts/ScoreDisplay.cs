using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text MyText;
    public Text HighText;
    private int score;
    public AudioClip pop;
    private int highScore;

    // Start is called before the first frame update
    void Start()
    {
        MyText.text = "";
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            
            if (Physics.Raycast(ray, out hit, 100.0f) && hit.transform.gameObject != null)
            {
                ScoreTracker.increaseScore();
                if (PlayerPrefs.GetInt("Sound") != 1)
                {
                    GetComponent<AudioSource>().PlayOneShot(pop);
                }
                GameObject.Destroy(hit.transform.gameObject);
            }
        }



        score = ScoreTracker.getScore();
        ScoreTracker.setHighScore(score);
        highScore = ScoreTracker.getHighScore();
        MyText.text = "" + score;
        HighText.text = "" + highScore;
        //determineSpawnTimer();
    }

    IEnumerator Timer()
    {
        while (true)
        {
            determineSpawnTimer();
            yield return new WaitForSeconds(10f);
        }
    }

    void determineSpawnTimer()
    {
        float hi = SpawnTimer.getSpawnTimer() - 0.01f;
        SpawnTimer.setSpawnTimer(hi);
        Debug.Log(SpawnTimer.getSpawnTimer());      
    }

}
