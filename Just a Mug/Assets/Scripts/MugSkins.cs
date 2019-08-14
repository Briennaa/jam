using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MugSkins : MonoBehaviour
{
    int skin = 0;
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

    void Update()
    {
        isScared();

        int children = transform.childCount;
        for (int i = 0; i < children; ++i)
            if (transform.GetChild(i).name == PlayerPrefs.GetInt("MugSkin").ToString())
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }
            else
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
    }

    void isScared()
    {
        Collider[] hitColliders = Physics.OverlapSphere(this.transform.position, 5);
        int i = 0;
        Transform nearest = null;
        float nearDist = 99;
        while (i < hitColliders.Length)
        {
            float thisDist = (transform.position - hitColliders[i].transform.position).sqrMagnitude;
            if (thisDist < nearDist)
            {
                nearDist = thisDist;
                nearest = hitColliders[i].transform;
                if(nearest.position.x < -2)
                {
                    skin = 1; //left
                }
                else if (nearest.position.x > 2)
                {
                    skin = 3; //right
                }
                else
                {
                    skin = 2; //center
                }
            }
        }
        if (nearest != null)
        {
            PlayerPrefs.SetInt("MugSkin", skin);
        }
        else
        {
            PlayerPrefs.SetInt("MugSkin", 0);
        }
    }
}
