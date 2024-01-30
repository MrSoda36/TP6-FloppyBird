using System.Collections;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject _obstaclePrefab;
    private GameObject _obstacle;
    [SerializeField]
    private float _obstacleDelay = 2f;
    [SerializeField]
    private float[] _posY = { -1.5f, 0f, 1.5f };

    private void Update()
    {
        if (_obstacle == null)
        {
            StartCoroutine(CreateObstacle());
        }
    }

    private IEnumerator CreateObstacle()
    {
        transform.position = new Vector3(transform.position.x, _posY[Random.Range(0, _posY.Length)], transform.position.z);
        _obstacle = Instantiate(_obstaclePrefab, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(_obstacleDelay);
        _obstacle = null;
    }
}
