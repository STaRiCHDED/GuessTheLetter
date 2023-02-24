using System;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    private readonly Dictionary<Type, IState> _states;
    private IState _currentState;
    
    public StateMachine(params IState[] states)
    {
        _states = new Dictionary<Type, IState>();
        foreach (var state in states)
        {
            state.Initialize(this);
            _states[state.GetType()] = state;
        }
    }

    public void Enter<TState>(params GameObject[] objects) where TState : IState
    {
        _currentState?.Exit();
        var type = typeof(TState);
        var state = _states[type];
        state.Enter(objects);
        _currentState = state;
    }
}