using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem.XR;
using TMPro;

public class InputCharacterName : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputFieldBox;
    private string playerName = null;
    [SerializeField] private TMP_Text InputText;
    [SerializeField] private TMP_Text SetName;
    public GameObject CharacterName;
    public GameObject InputBox;

    private void Awake()
    {
        //inputFieldBox = GetComponent<TMP_InputField>();
    }
    
     
    //¸¶¿ì½º
    public void InputName()
    {
        //if(inputFieldBox.text.Length < 2)
        //{
        //    return;
        //}
        playerName = inputFieldBox.text;
        InputText.text = playerName;

        SettingName(InputText.text);
        //PlayerPrefs.SetString("CurrentPlayerName", playerName);
        //.instance.ScoreSet(GameManager.instance.score, playerName);
    }

    public void SettingName(string name)
    {
        SetName.text = name;
        InputBox.SetActive(false);
        CharacterName.SetActive(true);
    }
}
