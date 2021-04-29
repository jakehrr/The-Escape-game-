using UnityEngine.Audio;
using UnityEngine;

public class EngineIdle : MonoBehaviour
{
    private AudioSource engineIdle;

    private void Start()
    {
        engineIdle = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.W))
        {
            engineIdle.Play();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            engineIdle.Stop();
        }

    }
}