using UnityEngine;
using UnityEngine.UI;

public enum SetName
{
    Signs = 0,
    Words = 1,
    Numbers = 2
}
public enum LevelDifficulty
{
    Easy = 1,
    Medium = 2,
    Hard = 3
}
[RequireComponent(typeof(SessionGameController))]
public class GameController : MonoBehaviour
{
    [SerializeField] 
    private Button[] _buttons;
    
    
    private StateMachine _stateMachine;
    private SessionGameController _sessionGame;
    private ScriptableObject[] _scriptableObjects;
    void Awake()
    {
        _sessionGame = GetComponent<SessionGameController>();
    }
    

    private void GameEnded()
    {
        
    }
    private void GameStart(SetName name, LevelDifficulty level)
    {
        _sessionGame.Initilize(name,level,GameEnded);
    }
}