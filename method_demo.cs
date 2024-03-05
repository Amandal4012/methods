using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class method_demo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int characterLevel = 32;
        int NextSkillLevel = GenerateCharacter("Spongebob", characterLevel);
        //Debug.Log(NextSkillLevel);
        Debug.Log(GenerateCharacter("Patrick", characterLevel));
        GenerateCharacter("Spongebob", characterLevel);
    }

    public int GenerateCharacter(string name, int level)
    {
        Debug.LogFormat("Character: {0} - Level: {1}", name, level);
        return level += 5;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
