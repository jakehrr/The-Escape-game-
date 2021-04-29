using UnityEngine.Audio;
using UnityEngine;

public class AccelerationAudio : MonoBehaviour
{
    private AudioSource accelerationAudio;

    private void Start()
    {
        accelerationAudio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            accelerationAudio.Play();
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            accelerationAudio.Stop();
        }
        
    }
}
