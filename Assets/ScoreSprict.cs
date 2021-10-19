using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSprict : MonoBehaviour
{



    private GameObject Scoretext ;
    private int score = 0;

    void Start()
    {
        

        this.Scoretext = GameObject.Find("ScoreText");
        
    }

    void OnCollisionEnter(Collision other)
    {
        string tag = other.gameObject.tag;
        if (tag == "SmallStarTag")
        {
            this.score += 1;
        }
        else if (tag == "LargeStarTag")
        {
            this.score += 3;
        }
        else if (tag == "SmallCloudTag")
        {
            this.score += 2;
        }
        else if (tag == "LargeCloudTag")
        {
            this.score += 5;
        }
        SetScore();
    }

    void SetScore()
    {
        this.Scoretext.GetComponent<Text>().text = "Score : " + score;
    }
    // Update is called once per frame
    void Update()
    {

    }

    
}