using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public float scoreIncrease = 100;
    private float highScore;
    private float score;
    private float startDelay = 2;
    private float scoreInterval = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CountScore", startDelay, score Interval);
    }

    // Update is called once per frame
    void Update()
    {
     //Check to see if game object is still exisisting 
     // if not print high score
     // if so do nothing   
    }

    void CountScore(){
        score = score + scoreInterval;
    }
}
}
