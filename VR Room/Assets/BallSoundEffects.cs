using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSoundEffects : MonoBehaviour
{
    [System.Serializable]
    public class BallSound
    {
        public string name;
        public AudioClip clip;
        [HideInInspector] public AudioSource source;
        [Range(0f,1f)] public float volume = 1;
        public float pitch = 1f;
    }

    public BallSound[] sounds;

    private void Awake()
    {
        foreach (var ballSound in sounds)
        {
            ballSound.source = gameObject.AddComponent<AudioSource>();
            ballSound.source.clip = ballSound.clip;
            ballSound.source.volume = ballSound.volume;
            ballSound.source.pitch = ballSound.pitch;
            ballSound.source.playOnAwake = false;
        }
    }

    private void Play(string name)
    {
        var sound = System.Array.Find(sounds, x => x.name == name);
        if (sound == null) return;
        sound.source.Play();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pin"))
        {
            Play("Pins");
        }
        if (collision.gameObject.CompareTag("Alley"))
        {
            Play("Alley");
        }
    }
}
