using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private float _speed = 2f;

    public void Update()
    {
        transform.Translate(_speed * Time.deltaTime * Vector2.left);
    }
}
