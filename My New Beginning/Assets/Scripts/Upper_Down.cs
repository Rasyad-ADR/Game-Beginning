using UnityEngine;

public class Upper_Down : MonoBehaviour
{
    public Collider2D[] upperCollider;
    public Collider2D[] edgeCollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            foreach (Collider2D upper in upperCollider)
            {
                upper.enabled = true;
            }

            foreach (Collider2D edge in edgeCollider)
            {
                edge.enabled = false;
            }

            collision.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 10;
        }

    }
}
