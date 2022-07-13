using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] flags;
    public float time;
    public float repeatTime;
    private float spawnPositionX=11.64f;
    void Start()
    {
        InvokeRepeating("SpawnRandom",time,repeatTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandom(){
        int index=Random.Range(0,flags.Length);
        Vector2 spawnPosition=new Vector2(Random.Range(-spawnPositionX,spawnPositionX),7.5f);
        Instantiate(flags[index],spawnPosition,flags[index].transform.rotation);
    }
}
