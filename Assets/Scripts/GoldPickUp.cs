using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldPickUp : MonoBehaviour, IPickUpObject // always add IPickUpObject for pickup object scripts like health and orbexp
{
    [SerializeField] int count;
    public void OnPickUp(Character character)
    {
        character.gold.Add(count);
    }
}
