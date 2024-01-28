using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _obstaclePrefab;
    private GameObject _obstacle;

    private void CreateObstacle()
    {
        _obstacle = Instantiate(_obstaclePrefab, transform.position, Quaternion.identity);
    }

    private void DestroyObstacle(GameObject obstacle)
    {
        Destroy(obstacle);
    }

    private void Update()
    {
        if (_obstacle == null)
        {
            CreateObstacle();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            DestroyObstacle(collision.gameObject);
        }
    }
}
