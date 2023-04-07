public class PlaySound : MonoBehaviour
{
    public AudioClip sound;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Activate()
    {
        audioSource.PlayOneShot(sound);
    }
}