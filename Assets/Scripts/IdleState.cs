using UnityEngine;

public class IdleState : IState
{
    private PlayerController player;

    // �����ڿ��� �ʿ��� �Ű������� ���޹���
    public IdleState(PlayerController player) { this.player = player; }
    public void Enter()
    {
        Debug.Log("�⺻ ���� ����");
    }
    // �����Ӹ��� ����Ǵ� ����, ���� ��ȯ ���� ����
    public void Update()
    {
        // ��/�� �Է� ���� (A/D �Ǵ� ��/��)
        float horizontal = Input.GetAxis("Horizontal");
        if (Mathf.Abs(horizontal) > 0.1f)
        {
            player.PlayerStateMachine.TransitionTo(
                player.PlayerStateMachine.walkState);
        }
    }
    public void Exit()
    {
        Debug.Log("�⺻ ���� Ż��");
    }
}

