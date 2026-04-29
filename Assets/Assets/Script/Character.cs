using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Character
{
    public string characterName;
    public Sprite characterSprite;
    public Sprite characterPotrait;

    public RuntimeAnimatorController animatorController;

    [TextArea(3,5)]
    public string description;

    public Sprite skillIcon;

    public AudioClip voiceClip;
}