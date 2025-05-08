using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    Transform targetDestination;

    [SerializeField] float speed;
    [SerializeField] int hp;
    [SerializeField] int damage;
    [SerializeField] int exp_reward;

    Rigidbody2D rgdbd2d;
    GameObject targetGameobject;
    Character targetCharacter;
    private void Awake()
    {
        rgdbd2d = GetComponent<Rigidbody2D>();
        
    }

    public void SetTarget(GameObject target)
    {
        targetGameobject = target;
        targetDestination = target.transform;
    }

    private void FixedUpdate() /* deals with any physics calculation for the rigidbody2d */
    {
        Vector3 direction = (targetDestination.position - transform.position).normalized; /* makes a field in the properties of the enemy to allow you to set a target, so we drag the playercharacter object into the field */
        rgdbd2d.velocity = direction * speed; /* makes the enemy chase after the target */

    }

    private void OnCollisionStay2D(Collision2D collision) //detects if the enemy is colliding with the target
    {
        if (collision.gameObject == targetGameobject)
        {
            Attack();
        }
    }

    private void Attack ()
    {
        if (targetCharacter == null)
        {
            targetCharacter = targetGameobject.GetComponent<Character>(); //detects if the gameobject has the Character script
        }
        targetCharacter.TakeDamage(damage); //activates the TakeDamage class inside Character script
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;

        if (hp < 1)
        {
            targetGameobject.GetComponent<Level>().AddExperience(exp_reward);
            Destroy(gameObject);
        }
    }
}
