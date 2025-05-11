using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    public StateMachine PlayerStateMachine { get; private set; }
    public CharacterController CharController { get; private set; }


    void Start()
    {
        // �ʼ� ������Ʈ �ʱ�ȭ
        CharController = GetComponent<CharacterController>();

        // ���� �ӽ� ���� �� �ʱ� ���� ����
        PlayerStateMachine = new StateMachine(this);
        PlayerStateMachine.Initialize(PlayerStateMachine.idleState);
    }

    void Update()
    {
        // ���� ������ Update() ȣ��
        PlayerStateMachine.Update();
    }
}
