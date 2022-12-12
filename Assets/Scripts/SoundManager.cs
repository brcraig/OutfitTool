using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SoundManager : MonoBehaviour
{
    // the audio source 
    public AudioSource AudioSource;
    public AudioClip BackgroundMusicAudioSource;
    public AudioClip ClickSound;
    public void Start(){
        PlayBackgroundMusic(); 
    }
    public void PlayBackgroundMusic() {
        AudioSource = GetComponent<AudioSource>();
        AudioSource.clip = BackgroundMusicAudioSource;
        AudioSource.loop = true;
        AudioSource.Play();
    }

    public void PlayClickSound() {
        
        AudioSource.PlayOneShot(ClickSound);
    }
}
