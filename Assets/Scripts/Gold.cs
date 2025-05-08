using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
    public int goldAcquired;
    [SerializeField] TMPro.TextMeshProUGUI goldCountText;
    public void Add(int count)
    {
        goldAcquired += count;
        goldCountText.text = "Gold: " + goldAcquired;
    }

}
