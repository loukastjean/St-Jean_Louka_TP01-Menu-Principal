using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterMovements2D : MonoBehaviour
{
    [SerializeField] float movementSpeed = 7.5f;
    
    float horizontal;
    float vertical;

    Rigidbody2D body;
    
    Animator animator;
    
    SpriteRenderer spriteRenderer;

    void Start()
    {
        if (TryGetComponent(out Rigidbody2D rb))
            body = rb;
        else
            body = (Rigidbody2D)gameObject.AddComponent(typeof(Rigidbody2D));

        // Retirer la gravité
        body.gravityScale = 0f;
        
        // Contrainte de rotation
        body.constraints = RigidbodyConstraints2D.FreezeRotation;
        
        animator = GetComponent<Animator>();
        
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetTrigger("attaque");
        }
    }

    void FixedUpdate()
    {
        // Récupérer les valeurs des inputs
        horizontal = Input.GetAxisRaw("Horizontal"); // -1 est left, 1 est right
        vertical = Input.GetAxisRaw("Vertical"); // -1 est down, 1 est up

        body.velocity = new Vector2(horizontal, vertical).normalized * movementSpeed;
        
        // Attribuer la valeur de velocite comme booleen a l'animator
        animator.SetBool("enMovement", body.velocity.magnitude > 0.1f);
        
        // Flip spire selon direction
        if (body.velocity.x > 0.1f)
        {
            spriteRenderer.flipX = false;
        }
        else if (body.velocity.x < -0.1f)
        {
            spriteRenderer.flipX = true;
        }
    }
}
