using UnityEngine;

public class IdleState : IState
{
    private PlayerController player;

    // 생성자에서 필요한 매개변수를 전달받음
    public IdleState(PlayerController player) { this.player = player; }
    public void Enter()
    {
        Debug.Log("기본 상태 진입");
    }
    // 프레임마다 실행되는 로직, 상태 전환 조건 포함
    public void Update()
    {
        // 좌/우 입력 감지 (A/D 또는 ←/→)
        float horizontal = Input.GetAxis("Horizontal");
        if (Mathf.Abs(horizontal) > 0.1f)
        {
            player.PlayerStateMachine.TransitionTo(
                player.PlayerStateMachine.walkState);
        }
    }
    public void Exit()
    {
        Debug.Log("기본 상태 탈출");
    }
}

