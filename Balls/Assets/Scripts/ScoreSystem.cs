using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] int score = 100;
    [SerializeField] int points = 10;
    [SerializeField] Text scoreTxt;
    [SerializeField] GameObject spawnObject;
    float speedValue = 2f;
    float minSpeedPossible;

    void Start()
    {
        if (scoreTxt.text == null)
        {
            return;
        }
        else
        {
            scoreTxt.text = score.ToString();
        }

        
        minSpeedPossible = spawnObject.GetComponent<BallSpawn>().returnMinSpeed();
    }

    public void increaseScore()
    {
        score += points;
        scoreTxt.text = score.ToString();
        if (speedValue >= minSpeedPossible) 
        {
            speedValue = spawnObject.GetComponent<BallSpawn>().decreaseSpawnTime();
        }
        
    }

}
