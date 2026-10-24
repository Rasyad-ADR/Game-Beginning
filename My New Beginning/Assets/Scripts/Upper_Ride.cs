using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upper_Rider : MonoBehaviour
{
    public Collider2D[] upperCollider;
    public Collider2D[] edgeCollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            {
                foreach (Collider2D upper in upperCollider)
                {
                    upper.enabled = false;
                }

                foreach (Collider2D edge in edgeCollider)
                {
                    edge.enabled = true;
                }

            collision.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 15;
            }
        
    }
}

