using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    int score = 0;

    public int getScore()
    {
        return score;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void incrementScore()
    {
        score += 1;
        Debug.Log(score);
    }
}
