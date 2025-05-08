using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballWeapon : MonoBehaviour
{
    [SerializeField] float timeToAttack;
    float timer;

    PlayerMove playerMove;

    [SerializeField] GameObject fireballPrefab;

    private void Awake()
    {
        playerMove = GetComponentInParent<PlayerMove>();
    }
    private void Update()
    {
        if (timer < timeToAttack)
        {
            timer += Time.deltaTime;
            return;
        }
        timer = 0;
        SpawnFireball();
    }

    private void SpawnFireball()
    {
        GameObject thrownFireball = Instantiate(fireballPrefab);
        thrownFireball.transform.position = transform.position;
        thrownFireball.GetComponent<FireballProjectile>().SetDirection(playerMove.lastHorizontalVector, 0f); //spawns the fireball based on where the player is facing and initiates the fireball projectile script for it to move
    }
}
