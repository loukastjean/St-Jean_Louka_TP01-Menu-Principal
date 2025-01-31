using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovements2D : MonoBehaviour
{

    float horizontal;
    float vertical;
    float moveLimiter = 0.5f;

    public float movementSpeed = 20.0f;

    Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Récupérer les valeurs des inputs
        horizontal = Input.GetAxisRaw("Horizontal"); // -1 est left, 1 est right
        vertical = Input.GetAxisRaw("Vertical"); // -1 est down, 1 est up
    }

    void FixedUpdate()
    {
        if (horizontal != 0 && vertical != 0) // Check for diagonal movement
        {
            // limite la vitesse de mouvement diagonale
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }

        body.velocity = new Vector2(horizontal * movementSpeed, vertical * movementSpeed);
    }
}
