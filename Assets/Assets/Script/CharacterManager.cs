using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CharacterManager : MonoBehaviour
{
    public CharacterDatabase characterDB;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public Image artworkImage;

    public AudioSource audioSource;

    public AudioSource sfxSource;
    public AudioClip clickSound;

    private int selectedOption = 0;

    void Start()
    {
        if(!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }

        else
        {
            Load();
        }

        UpdateCharacter(selectedOption, false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            NextOption();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            BackOption();
        }
    }

    public void NextOption()
    {
        selectedOption++;
        
        if(selectedOption >= characterDB.CharacterCount)
        {
            selectedOption = 0;
        }

        UpdateCharacter(selectedOption);
        Save();
    }

    public void BackOption()
    {
        selectedOption--;

        if(selectedOption < 0)
        {
            selectedOption = characterDB.CharacterCount - 1;
        }

        UpdateCharacter(selectedOption);
        Save();
    }

    public void PlayClicksound()
    {
        if (clickSound != null)
        {
            sfxSource.PlayOneShot(clickSound);
        }
    }

    public void PlayVoice()
    {
        if (audioSource.clip != null)
        {
            if (!audioSource.isPlaying)
                audioSource.Play();
        }
    }

    public void StopVoice()
    {
        audioSource.Stop();
    }

    private void UpdateCharacter(int selectedOption, bool playAudio = true)
    {
        Character character = characterDB.GetCharacter(selectedOption);
        artworkImage.sprite = character.characterSprite;
        nameText.text = character.characterName;
        descriptionText.text = character.description;

        audioSource.Stop();

        if (character.voiceClip != null)
        {
            audioSource.clip = character.voiceClip;

            if (playAudio)
            {
                audioSource.Play();
            }
        }
    }

    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }

    private void Save()
    {
        PlayerPrefs.SetInt("selectedOption", selectedOption);
    }

    public void ChangeScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}