using UnityEngine;

public class TestSingleton : Singleton<TestSingleton>
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("��ü�� �����Ǿ����ϴ�.");
    }
    
}
