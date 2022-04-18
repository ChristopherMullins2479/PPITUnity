using UnityEngine;

public class gameMusicLoop : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioClip gameMusic;

    // Start is called before the first frame update
    void Start()
    {
        musicSource.PlayOneShot(gameMusic);
        musicSource.PlayScheduled(AudioSettings.dspTime + gameMusic.length);
    }

    // Update is called once per frame
    void Update()
    {

    }
}