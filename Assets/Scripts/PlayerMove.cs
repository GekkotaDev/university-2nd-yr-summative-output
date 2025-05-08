using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rgbd2d;
    [HideInInspector] public Vector3 movementVector; //hide in inspector makes it so you can't see it in the property inspector field but it's still public

    [SerializeField] float speed = 3f; // makes a text field that allows you to edit speed

    [HideInInspector] public float lastHorizontalVector;
    [HideInInspector] public float lastVerticalVector;

    Animate animate;
        
   private void Awake()
    {
        rgbd2d = GetComponent<Rigidbody2D>();
        movementVector = new Vector3();
        animate = GetComponent<Animate>();
    }

    // Update is called once per frame
    void Update()
    {
        movementVector.x = Input.GetAxisRaw("Horizontal");
        movementVector.y = Input.GetAxisRaw("Vertical");

        if (movementVector.x != 0) // stores the last movement input of the player which would be used by other scripts
        {
            lastHorizontalVector = movementVector.x;
        }
        if(movementVector.y != 0)
        {
            lastVerticalVector = movementVector.y;
        }


        animate.horizontal = movementVector.x;

        movementVector *= speed;
        rgbd2d.velocity = movementVector;

    }
}
