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

    private Character character;

    void Start()
    {
        // int index = PlayerPrefs.GetInt("selectedOption");
        int index = 0;
        character = characterDB.GetCharacter(index);

        // Animator
        animator.runtimeAnimatorController =  character.animatorController;

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
    }

    public void PlayRun()
    {
        animator.Play("Run");
    }

    public void PlayAttack()
    {
        animator.SetTrigger("Attack");
    }

    public void PlaySkill()
    {
        animator.SetTrigger("Skill");
    }
}