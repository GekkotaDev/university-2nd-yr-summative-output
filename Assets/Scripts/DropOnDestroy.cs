using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropOnDestroy : MonoBehaviour
{
    [SerializeField] GameObject dropItemPrefab; // so that you can drag the any pickup prefabs into this field
    [SerializeField] [Range(0f,1f)] float chance = 1f;

    bool isQuitting = false;
    private void OnApplicationQuit()
    {
        isQuitting = true;
    }
    private void OnDestroy()
    {
        if (isQuitting) { return; }
        if(Random.value < chance)
        {
            Transform t = Instantiate(dropItemPrefab).transform;
            t.position = transform.position; // makes it drop spawn on the same place as the parent gameobject  
        }
        
    }
}
