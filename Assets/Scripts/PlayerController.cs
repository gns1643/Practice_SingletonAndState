using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    public StateMachine PlayerStateMachine { get; private set; }
    public CharacterController CharController { get; private set; }


    void Start()
    {
        // 필수 컴포넌트 초기화
        CharController = GetComponent<CharacterController>();

        // 상태 머신 생성 및 초기 상태 설정
        PlayerStateMachine = new StateMachine(this);
        PlayerStateMachine.Initialize(PlayerStateMachine.idleState);
    }

    void Update()
    {
        // 현재 상태의 Update() 호출
        PlayerStateMachine.Update();
    }
}
