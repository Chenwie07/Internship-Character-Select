using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Character_Data", menuName ="Character Data")]
public class Character : ScriptableObject
{
    public Char_Profile _Profile; 
    public Char_Appearance _Appearance;
    public Char_Parameters _Parameters; 
}

[System.Serializable]
public class Char_Profile
{
    public string id; // our ID will be string for Name. 
    public int age; 
    [TextArea(2, 4)] public string background; 
}

[System.Serializable]
public class Char_Appearance
{
    [SerializeField] Sprite portrait; 
    [SerializeField] private Color skinTone; 

    public Sprite Portrait
    {
        get { return portrait; }
    }
    public Color SkinTone { 
        get { return skinTone; }
    }
}

[System.Serializable]
public class Char_Parameters
{
    public enum Char_Class
    { Warrior, Shaman, Witch}

    public Char_Class characterClass;
    [SerializeField] int HP;
    [SerializeField] int MP; 
}