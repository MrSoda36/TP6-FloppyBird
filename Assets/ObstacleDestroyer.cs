using UnityEngine;

public class ObstacleDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Destroying obstacle");
            Destroy(collision.gameObject.transform.parent.gameObject);
        }
    }
}
