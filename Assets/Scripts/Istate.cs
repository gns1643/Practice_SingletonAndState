public interface IState
{

    public void Enter()
    {
        // 처음 그 상태에 진입할 때 실행할 코드
    }

    public void Update()
    {
        // 그 상태에서 프레임당 실행되는 코드
        // 특정 전환을 만족시에 다른 상태로 전이
    }

    public void Exit()
    {
        // 그 상태에서 빠져 나올 때 실행할 코드
    }
}
