using UnityEngine.Audio;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{
    public ParticleSystem explosionParticle;
    public GameObject player;

    private AudioSource audioSource;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Destroy();
            gameObject.SetActive(false);
            audioSource.Stop();
        }
        if (collision.collider.CompareTag("Enemy"))
        {
            Destroy();
            gameObject.SetActive(false);
        }
        if (collision.collider.CompareTag("Environment"))
        {
            Destroy();
            gameObject.SetActive(false);
        }
    }
    private void Destroy()
    {
        Instantiate(explosionParticle, transform.position, Quaternion.identity);
    }
}
