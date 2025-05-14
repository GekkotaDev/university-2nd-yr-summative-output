using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FireballWeapon : MonoBehaviour
{
    // [SerializeField]
    public float timeToAttack;
    float timer;

    PlayerMove playerMove;

    public GameObject fireballPrefab;
    public LevelBehaviourModel Level;

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
        if (Level.ReadLevel() < 5)
            return;

        GameObject thrownFireball = Instantiate(fireballPrefab);
        thrownFireball.transform.position = transform.position;
        thrownFireball
            .GetComponent<FireballProjectile>()
            .SetDirection(playerMove.lastHorizontalVector, 0f); //spawns the fireball based on where the player is facing and initiates the fireball projectile script for it to move

        Destroy(thrownFireball, 2);
    }
}
