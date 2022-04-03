using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    [SerializeField] GameObject ball;
    [SerializeField] float maxRange = 16;
    [SerializeField] float minRange = 0;
    [SerializeField] float spawnTime = 1f;
    [SerializeField] float timeDecreaseFactor = 0.10f;
    [SerializeField] float minSpeedPossible = 0.50f;
    [SerializeField] bool canDrop = true;


    void Start()
    {
        Cursor.visible = false;
    }
    
    void Update()
    {
        if (canDrop)
        {
            StartCoroutine(randomSpawn());
        }
        
    }

    public float returnMinSpeed()
    {
        return minSpeedPossible;
    }

    public float decreaseSpawnTime()
    {
            spawnTime -= timeDecreaseFactor;
            return spawnTime;
    }

    IEnumerator randomSpawn()
    {
        canDrop = false;
        float randomPoint = Random.Range(minRange, maxRange);
        Instantiate(ball, new Vector2(randomPoint, 6), Quaternion.identity);
        yield return new WaitForSeconds(spawnTime);
        canDrop = true;
    }

}
