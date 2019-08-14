using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MugController : MonoBehaviour
{
    GameObject mugSpriteObj;
    SpriteRenderer spriteRenderer;
    public Sprite scaredSprite;
    public Sprite defaultSprite;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in transform)
        {
            if (child.tag == "scaredZone")
            {
                child.gameObject.SetActive(false);
                //mugSpriteObj = child.gameObject;
            }
        }
        //spriteRenderer = mugSpriteObj.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        GetClosestObject("Fuzz");
    }

    void GetClosestObject(string tag) {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(tag);
        bool found = false;
     foreach (GameObject obj in objectsWithTag)
     {
            if (Vector3.Distance(transform.position, obj.transform.position) < 2)
            {
                found = true;
                //spriteRenderer.sprite = scaredSprite;
                foreach (Transform child in transform)
                {
                    if (child.tag == "scaredZone")
                    {
                        child.gameObject.SetActive(true);
                        //mugSpriteObj = child.gameObject;
                    }
                    else
                    {
                        child.gameObject.SetActive(false);
                    }
                }
            }
        }
        if (!found)
        {
            foreach (Transform child in transform)
            {
                if (child.tag == "scaredZone")
                {
                    child.gameObject.SetActive(false);
                    //mugSpriteObj = child.gameObject;
                }
                else
                {
                    child.gameObject.SetActive(true);
                }
            }
        }

    }
}
