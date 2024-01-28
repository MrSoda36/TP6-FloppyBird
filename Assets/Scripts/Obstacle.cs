using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private float _speed = 2f;

    public void Update()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime);
    }
}
