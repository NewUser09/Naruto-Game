using UnityEngine;

public class ItachiSound : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip skill1;
    public AudioClip skill2;
    public AudioClip attack;

    public void Skill1Sound()
    {
        if (audioSource.clip == skill1 && audioSource.isPlaying)
            return;

        audioSource.Stop();
        audioSource.clip = skill1;
        audioSource.Play();
    }

    public void Skill2Sound()
    {
        if (audioSource.clip == skill2 && audioSource.isPlaying)
            return;
        
        audioSource.Stop();
        audioSource.clip = skill2;
        audioSource.Play();
    }

    public void AttackSound()
    {
        audioSource.PlayOneShot(attack);
    }
}