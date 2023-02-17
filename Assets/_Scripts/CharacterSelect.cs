using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

/*
 * Our character selection 
 * Choose Characters by Tapping on their portraits
 */ 

public class CharacterSelect : MonoBehaviour
{
    public List<Character> characterList = new List<Character>(); // 0 - Murdoc, 1 - Judi , 2 - Amunga

    private Image[] portraits;

    #region UI Fields
    [Header("UI Fields")]
    public TextMeshProUGUI _hp; 
    public TextMeshProUGUI _mp; 
    public TextMeshProUGUI _name; 
    public TextMeshProUGUI _age;
    public TextMeshProUGUI _bio;
    public TextMeshProUGUI _class;
    #endregion


    private void Start()
    {
        int limit = characterList.Count; 
        for (int i = 0; i < limit; i++)
        {
            portraits[i].sprite = characterList[i]._Appearance.Portrait; 
        }
    }
    public void ChooseCharacter(string id)
    {
        switch (id)
        {
            case "Murdoc":
                ConfigureCharacterGUI(0); 
                break;
            case "Judi":
                ConfigureCharacterGUI(1); 
                break;
            case "Amunga":
                ConfigureCharacterGUI(2); 
                break; 
        }
    }

    void ConfigureCharacterGUI(int idx)
    {
        _hp.SetText("Base HP: " + characterList[idx]._Parameters.BaseHP.ToString()); 
        _mp.SetText("Base MP: " + characterList[idx]._Parameters.BaseMP.ToString());
        _class.SetText(characterList[idx]._Parameters.characterClass.ToString()); 
        _bio.SetText(characterList[idx]._Profile.Bio); 
        _name.SetText("Name: " + characterList[idx]._Profile.ID); 
        _age.SetText("Age: " + characterList[idx]._Profile.Age.ToString()); 
    }
}
