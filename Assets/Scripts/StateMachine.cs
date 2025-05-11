using System;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

[Serializable]
public class StateMachine
{
    public IState CurrentState { get; private set; }

    public WalkState walkState;
    public IdleState idleState;

    public StateMachine(PlayerController player)
    {
        this.walkState = new WalkState(player);
        this.idleState = new IdleState(player);
    }
    //처음 시작할때 시작 상태 진입
    public void Initialize(IState startingState)
    {
        CurrentState = startingState;
        startingState.Enter();
    }
    // 상태 전환 조건 충족시 상태 전이
    public void TransitionTo(IState nextState)
    {
        CurrentState.Exit();
        CurrentState = nextState;
        nextState.Enter();
    }
    // 현재 상태가 존재하면 그 상태의 update 호출
    public void Update()
    {
        if (CurrentState != null)
        {
            CurrentState.Update();
        }
    }
}

