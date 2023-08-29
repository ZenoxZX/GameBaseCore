using UnityEngine;

namespace ZenoxZX.Core
{
    public abstract class MonoBehaviourSingletonDDL<T> : MonoBehaviour where T : Component
    {
        public static T Instance { get; private set; }

        public virtual void Awake()
        {
            if (Instance == null)
            {
                Instance = this as T;
                DontDestroyOnLoad(this);
            }
            else Destroy(gameObject);
        }
    }

    public abstract class MonoBehaviourSingleton<T> : MonoBehaviour where T : Component
    {
        public static T Instance { get; private set; }

        public virtual void Awake()
        {
            if (Instance == null) Instance = this as T;
            else Destroy(gameObject);
        }
    }
}
