using UnityEngine.Events;
using UnityEngine;

public class MonoEventsBehavior : MonoBehaviour
{
    public UnityEvent startEvent, destroyEvent;
    {
        void Start()
        {
            startEvent.Invoke();
        }
    }

}
