using UnityEngine;
using System.Collections;

public class SoundAndScriptActivation : MonoBehaviour
{
    public AudioClip sound;
    public float delayTime = 5f;
    public MonoBehaviour scriptToActivate;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Play sound and activate script after delay time
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.PlayOneShot(sound);
            Invoke("ActivateScript", delayTime);
        }
    }

    void ActivateScript()
    {
        scriptToActivate.enabled = true;
    }
}