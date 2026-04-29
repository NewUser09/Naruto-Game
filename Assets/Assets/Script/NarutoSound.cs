using UnityEngine;

public class NarutoSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip skill1;
    public AudioClip attack;

    public void NarutoSound1()
    {
        audioSource.clip = skill1;
        audioSource.Play();
    }

    public void NarutoAttackSound()
    {
        audioSource.PlayOneShot(attack);
    }
}