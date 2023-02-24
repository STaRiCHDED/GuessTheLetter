using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptableObject : MonoBehaviour
{
    [SerializeField] 
    private GameObject _letterPrefab;
    
    private string _setName;
    private LevelDifficulty _levelDifficulty;
    public Image _letterIcon;

    private Dictionary<int, Sprite> _playableLetters;

    public void Initialize(Sprite[] sprites,LevelDifficulty levelDifficulty)
    {
        _levelDifficulty = levelDifficulty;
        //_letterIcon = Instantiate(Random.Range(minElement, maxElement)); мб что-то ещё
        CreatePlayableSymbols(sprites);
    }

    private void CreatePlayableSymbols(Sprite[] sprites)
    {
        for (int i = 0; i < (int)_levelDifficulty*3; i++)
        {
            var index = Random.Range(0, sprites.Length - i);
            _playableLetters.Add(index,sprites[index]);
            if (i == 0)
            {
                _setName = sprites[index].name;
            }
            (sprites[index], sprites[sprites.Length - 1 - i]) = (sprites[sprites.Length - 1 - i], sprites[index]);
        }
    }
}