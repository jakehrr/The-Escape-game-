using UnityEngine.Audio;
using UnityEngine;

public class EffectDestroy : MonoBehaviour
{
    [SerializeField] float time;

    private AudioSource explosionSound;
    // Start is called before the first frame update
    void Start()
    {
        explosionSound.Play();
        Destroy(gameObject, time); 
    }
}
