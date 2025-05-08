using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballProjectile : MonoBehaviour
{
    Vector3 direction;
    [SerializeField] float speed;
    [SerializeField] int damage;

    public void SetDirection(float dir_x, float dir_y)
    {
        direction = new Vector3(dir_x, dir_y);

        if(dir_x < 0) // flips the object towards the same direction the player is facing
        {
            Vector3 scale = transform.localScale;
            scale.x = scale.x * -1;
            transform.localScale = scale;
        }
    }

    bool hitDetected = false;
    void Update()
    {
        transform.position += direction * speed * Time.deltaTime; //makes the object move, uses Time so that it synchronizes with the frame rate of the game

        if (Time.frameCount % 6 == 0) // makes it so that it only triggers every 6 frames, the larger and faster the object is, the more times you need to check otherwise it would skip over objects, this means that you have to lower the number 6 so it checks more frequently. this is for optimization so that it doesn't waste resources checking constantly
        { 
            Collider2D[] hit = Physics2D.OverlapCircleAll(transform.position, 0.7f);

            foreach (Collider2D c in hit) // continuously checks if the fireball hit an enemy and calls upon the Enemy script so they take damage
            {
                Enemy enemy = c.GetComponent<Enemy>();
                if (enemy != null)
                {
                    enemy.TakeDamage(damage);
                    hitDetected = true;
                    break;
                }
            }

            if (hitDetected == true)
            {
                Destroy(gameObject);
            }

        }

    }
}
