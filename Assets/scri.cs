using UnityEngine;

public class TouchMusicPlayer : MonoBehaviour
{
    private AudioSource audioSource;
    private bool isPlaying = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogError("No AudioSource on object!");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // tag "Player" was added
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
            isPlaying = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (audioSource.isPlaying)
            {
                audioSource.Pause(); // music paused but remember the last moment of playing
            }
            isPlaying = false;
        }
    }
}
