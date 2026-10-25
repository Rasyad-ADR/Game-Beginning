using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics.Geometry;
using UnityEngine.Tilemaps;
using UnityEngine;
using UnityEngine.Assemblies;

public class PMovement : MonoBehaviour
{
    public float speed = 5;
    public int fDirection = 1;
    public Rigidbody2D rb;
    public Animator anima;


    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (
            horizontal > 0 && transform.localScale.x < 0 ||
            horizontal < 0 && transform.localScale.x > 0
            )
        {
            Flip();
        }

        Vector2 movement = new Vector2(horizontal, vertical);
        anima.SetFloat("movementS", movement.magnitude);

        rb.linearVelocity = new Vector2(horizontal, vertical) * speed;
    }

    void Flip()
    {
        Vector3 currentScale = transform.localScale;
        currentScale.x *= -1;
        transform.localScale = currentScale;
    }

}
