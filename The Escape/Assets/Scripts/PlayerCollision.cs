using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Public Variables
    public ParticleSystem explosionParticle;
    public GameObject menuContainer;

    // Create a collision function
    private void OnCollisionEnter(Collision collision)
    {
        // Create a collision for the enemy
        if (collision.collider.CompareTag("Enemy"))
        {
            Destroy();
            gameObject.SetActive(false);
            FindObjectOfType<GameManager>().EndGame();
            menuContainer.SetActive(true);
        }
        // Create a collsion for environment objects
        if (collision.collider.CompareTag("Environment"))
        {
            Destroy();
            gameObject.SetActive(false);
            FindObjectOfType<GameManager>().EndGame();
            menuContainer.SetActive(true);
        }
    }
    private void Destroy()
    {
        Instantiate(explosionParticle, transform.position, Quaternion.identity);
    }
}
