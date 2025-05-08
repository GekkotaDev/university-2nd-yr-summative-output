using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    [SerializeField] GameObject toSpawn;
    [SerializeField] [Range(0f,1f)]float probability;

    public void Spawn() // make sure that the exact Spawner prefab object you have placed inside a TerrainTile is dragged  into the Spawn Object list, don't use the Spawner prefab asset itself. Because TerrainTiles only recognize the prefabs inside it
    {
        if(Random.value < probability)
        {
            GameObject go = Instantiate(toSpawn, transform.position, Quaternion.identity);
        }
    }

}
