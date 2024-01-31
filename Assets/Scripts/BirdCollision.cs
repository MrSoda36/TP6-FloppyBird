using UnityEngine;

public class BirdCollision : MonoBehaviour
{
    [SerializeField]
    private BirdMain _birdMain;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle") || collision.gameObject.CompareTag("Floor"))
        {
            _birdMain.BirdMovement.enabled = false;
            GameManager.Instance.GameOver();
        }
    }
}
