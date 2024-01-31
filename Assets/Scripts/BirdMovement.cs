using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    [SerializeField]
    private BirdMain _birdMain;
    private Rigidbody2D _rigidbody2D;
    private float _jumpForce = 5f;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody2D.velocity = Vector2.up * _jumpForce;
        }

        transform.rotation = Quaternion.Euler(0f, 0f, _rigidbody2D.velocity.y * 2f);
    }
}
