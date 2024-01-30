using UnityEngine;

public class BirdCollision : MonoBehaviour
{
    public BirdMain BirdMain;
    private bool _isAlive = true;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            _isAlive = false;
            BirdMain.BirdMovement.enabled = false;
            GameManager.Instance.GameOver();
        }
    }
}
