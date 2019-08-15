using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fuzz : MonoBehaviour
{
    Transform target;
    GameObject Mug;
    CharacterController _controller;

    [SerializeField]
    float _moveSpeed = 5.0f;

    public float taps = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
        Mug = GameObject.FindWithTag("Mug");
        target = Mug.transform;
        Physics.IgnoreLayerCollision(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Pause.getPaused() == false)
        {
            Vector3 direction = target.position - transform.position;
            direction = direction.normalized;
            Vector3 velocity = direction * _moveSpeed;
            _controller.Move(velocity * Time.deltaTime);
        }
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Mug")
        {
            Debug.Log("HIT");
            ScoreTracker.setHighScore(ScoreTracker.getScore());
            SceneManager.LoadScene("LoserWorld");
        }
    }

    public bool killed()
    {
        //returning true means the taps killed it
        taps = taps - 1;
        if (taps > 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
