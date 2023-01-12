using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public Slider bgmVolume;
    public Slider effectVolume;
    public static SoundManager SoundEffect;
    public AudioMixer audioMixer;
    public AudioSource musicSource;
    public AudioSource effectSource;
    public AudioSource bossMusicSource;
    //public AudioSource bgm;
    private void Awake()
    {
        if (SoundEffect == null)
        {
            SoundEffect = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
    }
    private void Update()
    {
    }
    public void SoundPlay(string sound, AudioClip clip)
    {
        GameObject soundStart = new GameObject(sound + "Sound");
        AudioSource audioSource = soundStart.AddComponent<AudioSource>();
        audioSource.volume = effectVolume.value;
        audioSource.outputAudioMixerGroup = audioMixer.FindMatchingGroups("EffectSound")[0];
        audioSource.clip = clip;
        audioSource.Play();
        Destroy(soundStart, clip.length);
    }
    public void SetMusicVolume()
    {
        musicSource.volume = bgmVolume.value;
        bossMusicSource.volume = bgmVolume.value;
    }
    public void SetEffectVolume()
    {
        effectSource.volume = effectVolume.value;
    }
}
