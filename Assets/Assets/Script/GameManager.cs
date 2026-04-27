using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public CharacterDatabase characterDB;

    public Image portraitUI;
    public TextMeshProUGUI nameText;
    public Image skillIcon;

    public Animator animator;

    public AudioSource audioSource;

    private Character character;

    void Start()
    {
        // int index = PlayerPrefs.GetInt("selectedOption");
        int index = 5;

        character = characterDB.GetCharacter(index);

        // UI
        portraitUI.sprite = character.characterPotrait;
        nameText.text = character.characterName;
        skillIcon.sprite = character.skillIcon;

        // default animasi
        PlayIdle();
    }

    public void PlayIdle()
    {
        animator.Play("Idle");
        // PlaySound(character.idleSound);
    }

    public void PlayRun()
    {
        animator.Play("Run");
        // PlaySound(character.runSound);
    }

    public void PlayAttack()
    {
        animator.SetTrigger("Attack");
        // PlaySound(character.attackSound);
    }

    public void PlaySkill()
    {
        animator.SetTrigger("Skill");
        // PlaySound(character.skillSound);
    }

    void PlaySound(AudioClip clip)
    {
        audioSource.Stop();

        if (clip != null)
        {
            audioSource.clip = clip;
            audioSource.Play();
        }
    }
}