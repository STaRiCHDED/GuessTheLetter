using UnityEngine;

public interface IState
{
    void Initialize(StateMachine stateMachine);
    void Enter(params GameObject[] objects);
    void Update();
    void Exit();
}