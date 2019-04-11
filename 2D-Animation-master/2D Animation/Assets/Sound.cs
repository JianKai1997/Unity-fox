using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{
    public string name;

    public AudioClip clip;

    [HideInInspector] //hide in unity bar there cannot see
    public AudioSource source;
}
