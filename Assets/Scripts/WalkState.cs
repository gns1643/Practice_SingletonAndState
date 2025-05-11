using UnityEngine;

public class WalkState : IState
{
    private PlayerController player;
    public WalkState(PlayerController player) { this.player = player; }

    public void Enter() { Debug.Log("걷기 시작"); }
    public void Update() { 
        Debug.Log("걷는중~~");
        // 입력이 없으면 Idle로 전환
        float horizontal = Input.GetAxis("Horizontal");
        if (Mathf.Abs(horizontal) < 0.1f)
        {
            player.PlayerStateMachine.TransitionTo(
                player.PlayerStateMachine.idleState
            );
        }
    }
    public void Exit() { Debug.Log("걷기 탈출"); }
}