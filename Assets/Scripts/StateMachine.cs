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
    //ó�� �����Ҷ� ���� ���� ����
    public void Initialize(IState startingState)
    {
        CurrentState = startingState;
        startingState.Enter();
    }
    // ���� ��ȯ ���� ������ ���� ����
    public void TransitionTo(IState nextState)
    {
        CurrentState.Exit();
        CurrentState = nextState;
        nextState.Enter();
    }
    // ���� ���°� �����ϸ� �� ������ update ȣ��
    public void Update()
    {
        if (CurrentState != null)
        {
            CurrentState.Update();
        }
    }
}

