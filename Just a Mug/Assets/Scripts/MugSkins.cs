using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MugSkins : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int children = transform.childCount;
        for (int i = 0; i < children; ++i)
            if(transform.GetChild(i).name == PlayerPrefs.GetInt("MugSkin").ToString())
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }
            else
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
