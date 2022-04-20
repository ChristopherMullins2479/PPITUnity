using UnityEngine;

public class gameMusicLoop : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioClip gameMusic;

    // Start is called before the first frame update
    void Start()
    {
        musicSource = GetComponent<AudioSource>();
        musicSource.loop = true;
        musicSource.PlayOneShot(gameMusic);
    }

    // Update is called once per frame
    void Update()
    {

    }
}