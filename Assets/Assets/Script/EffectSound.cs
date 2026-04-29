using UnityEngine;

public class EffectSound : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip run;
    public AudioClip attack1;
    public AudioClip attack2;
    public AudioClip attack3;
    public AudioClip kuwu;
    public AudioClip rasen;
     public AudioClip katon;

    public void RunSound()
    {
        audioSource.PlayOneShot(run);
    }

    public void Attack1Sound()
    {
        audioSource.PlayOneShot(attack1);
    }

        public void Attack2Sound()
    {
        audioSource.PlayOneShot(attack2);
    }

    public void Attack3Sound()
    {
        audioSource.PlayOneShot(attack3);
    }


    public void KuwuSound()
    {
        audioSource.PlayOneShot(kuwu);
    }


    public void RasenSound()
    {
        audioSource.PlayOneShot(rasen);
    }
    public void KatonSound()
    {
        audioSource.PlayOneShot(katon);
    }
}