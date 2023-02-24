using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SessionGameController : MonoBehaviour
{
    [SerializeField] 
    private Sprite[] _words;
    [SerializeField] 
    private Sprite[] _numbers;
    [SerializeField] 
    private Sprite[] _other;
    [SerializeField]
    private ScriptableObject _scriptableObject;
    public void Initilize(SetName name,LevelDifficulty difficulty,Action OnGameEnded)
    {
        Sprite[] sprites = null;
        switch (name)
        {
            case SetName.Words:
            {
                sprites = _words;
                break;
            }
            case SetName.Numbers:
            {
                sprites = _numbers;
                break;
            }
            case SetName.Signs:
            {
                sprites = _other;
                break;
            }
        }
        _scriptableObject.Initialize(sprites,difficulty);
    }
}
