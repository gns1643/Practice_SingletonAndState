using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : UnityEngine.Component
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindFirstObjectByType<T>();
                if (instance == null)
                {
                    SetupInstance();
                }
            }
            return instance;
        }
    }

    private static void SetupInstance()
    {
        instance = FindFirstObjectByType<T>();
        if (instance == null)
        {
            GameObject gameObj = new GameObject();
            gameObj.name = typeof(T).Name;
            instance = gameObj.AddComponent<T>();
            DontDestroyOnLoad(gameObj);
        }
    }

    public virtual void Awake()
    {
        RemoveDuplicates();
    }

    private void RemoveDuplicates()
    {
        if (instance == null)
        {
            instance = this as T;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
