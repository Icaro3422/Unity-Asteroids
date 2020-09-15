using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject asteroidPrefab;
    // Start is called before the first frame update
    void Start()
    {
        SpawnAseroids(6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnAseroids(int count)
    {
        for(int i=0;i<count;i++)
        {
            Object.Instantiate(asteroidPrefab, transform);
        }
    }
}
