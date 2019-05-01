using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private List<GOSpawner> spawnerList;


    private void Start()
    {
        foreach(GOSpawner spawner in spawnerList)
        {
            spawner.Spawn();
        }
    }

}
