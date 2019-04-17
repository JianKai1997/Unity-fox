using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{
    public string name;

    public AudioClip clip;

    [Range(0f,20f)]
    public float volume;
    [Range(.1f,3)]
    public float pitch;

    [HideInInspector] //hide in unity bar there cannot see
    public AudioSource source;
}
