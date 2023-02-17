using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 


/*
 * Our character selection 
 * Choose Characters by Tapping on their portraits
 */ 

public class CharacterSelect : MonoBehaviour
{
    public List<Character> characterList = new List<Character>();

    private Image[] portraits; 

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
                print("Murdoc"); 
                break;
            case "Judi":
                print("Judi");
                break;
            case "Amunga":
                print("Amunga");
                break; 
        }
    }
}
