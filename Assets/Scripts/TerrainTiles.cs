using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainTiles : MonoBehaviour
{
    [SerializeField] Vector2Int tilePosition;
    [SerializeField] List<SpawnObject> spawnObjects;
    void Start() // Start is called before the first frame update
    {
        GetComponentInParent<WorldScrolling>().Add(gameObject, tilePosition); 
    }

    public void Spawn()
    {
        for(int i = 0; i < spawnObjects.Count; i++)
        {
            spawnObjects[i].Spawn();
        }
    }
}