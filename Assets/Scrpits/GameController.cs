using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
        [Header("Wave Settings")]
        public GameObject hazard;
        public Vector2 spawnValue;
        public int hazardCount;

        [Header("Wave Time Settings")]
        public float startWait;
        public float spawnWait;
        public float waveWait;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnWaves());


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //coroutine to spwan waves of harzds
    IEnumerator SpawnWaves()
    {
        //Intial delay before the First Wave
        yield return new WaitForSeconds(startWait);

        //Start spawning the waves
        while(true)
        {
            //Spawn some hazards
            for(int i =0; i < hazardCount; i++)
            {
                //Spawn a single hazrd
                Vector2 spawnPosition = new Vector2(spawnValue.x, Random.Range(-spawnValue.y, spawnValue.y));

                Instantiate(hazard, spawnPosition,Quaternion.identity);
                yield return new WaitForSeconds(spawnWait); //Wait for the next hazard
            }

            yield return new WaitForSeconds(waveWait);
        }
    }
}
