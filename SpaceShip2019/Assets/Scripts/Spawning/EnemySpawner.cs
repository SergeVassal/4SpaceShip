using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : GOSpawner
{
    [SerializeField] private GameObject GOToSpawn;
    [SerializeField] private List<Transform> spawnTransforms;
    [SerializeField] private Transform playerTransform;


    public override void Spawn()
    {
        for (int i = 0; i < spawnTransforms.Count; i++)
        {
            var newGO = Instantiate(GOToSpawn, spawnTransforms[i].position, Quaternion.identity, this.gameObject.transform);
            newGO.GetComponent<EnemyController>().SetPlayerTransform(playerTransform);   
        }
    }
}
