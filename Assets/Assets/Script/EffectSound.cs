using UnityEngine;

public class EffectSound : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip run;
    public AudioClip attack1;
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