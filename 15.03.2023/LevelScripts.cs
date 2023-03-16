using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScripts : MonoBehaviour
{
    public List<GameObject> GameLevel;
    private int levelCount;
    void Start()
    {
        Instantiate(GameLevel[levelCount]);
    }
    public void Next_Level_Load()
    {
        levelCount++;
        Instantiate(GameLevel[levelCount]);
    }
}
