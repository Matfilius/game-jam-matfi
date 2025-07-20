using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("--------Audio Source--------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("---------Audio Clip--------")]
    public AudioClip background;
    public AudioClip door;
    public AudioClip generator;
    public AudioClip itempickup;
    public AudioClip wire;
    public AudioClip success;
    public AudioClip victoryalt;
    public AudioClip generatornovi;
    public AudioClip enternumber;
    public AudioClip back;
    public AudioClip victory;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

}
