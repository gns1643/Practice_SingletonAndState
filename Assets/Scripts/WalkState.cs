using UnityEngine;

public class WalkState : IState
{
    private PlayerController player;
    public WalkState(PlayerController player) { this.player = player; }

    public void Enter() { Debug.Log("�ȱ� ����"); }
    public void Update() { 
        Debug.Log("�ȴ���~~");
        // �Է��� ������ Idle�� ��ȯ
        float horizontal = Input.GetAxis("Horizontal");
        if (Mathf.Abs(horizontal) < 0.1f)
        {
            player.PlayerStateMachine.TransitionTo(
                player.PlayerStateMachine.idleState
            );
        }
    }
    public void Exit() { Debug.Log("�ȱ� Ż��"); }
}