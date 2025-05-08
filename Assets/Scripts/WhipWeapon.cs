using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhipWeapon : MonoBehaviour
{
    [SerializeField] float timeToAttack = 4f; // 4f = 4 seconds, this is how often this weapon attacks
    float timer;
    
    [SerializeField] GameObject leftWhipObject; //creates a field in the main wpn_Whip where you can put the left and right child whip objects in them
    [SerializeField] GameObject rightWhipObject;
    [SerializeField] Vector2 whipAttackSize = new Vector2(4f, 2f);
    [SerializeField] int whipDamage = 1;
    PlayerMove playerMove;

    private void Awake()
    {
        playerMove = GetComponentInParent<PlayerMove>();
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0f)
        {
            Attack();
        }
    }

    private void Attack()
    {
       // Debug.Log("Attack"); turn this on to see if this is working
        timer = timeToAttack; // resets the timer whenever the attack executes so that you can attack again

        if(playerMove.lastHorizontalVector > 0) //when player moves right the right whip is set to activate
        {
            rightWhipObject.SetActive(true);
            Collider2D [] colliders = Physics2D.OverlapBoxAll(rightWhipObject.transform.position, whipAttackSize, 0f); // detects if something is colliding with this object
            ApplyDamage(colliders);
        }
        else // otherwise the left is activated
        {
            leftWhipObject.SetActive(true);
            Collider2D[] colliders = Physics2D.OverlapBoxAll(leftWhipObject.transform.position, whipAttackSize, 0f);
            ApplyDamage(colliders);
        }

    }

    private void ApplyDamage(Collider2D[] colliders)
    {
        for (int i = 0; i < colliders.Length; i++)
        {
            // Debug.Log(colliders[i].gameObject.name) to see in the console if this weapon is colliding properly
            IDamageable e = colliders[i].GetComponent<IDamageable>(); // checks if the weapon is colliding with an object with the Enemy.cs script
            if (e != null) 
            {
                e.TakeDamage(whipDamage); // applies whipDamage when the weapon is colliding
            }
            
        }
    }
}
