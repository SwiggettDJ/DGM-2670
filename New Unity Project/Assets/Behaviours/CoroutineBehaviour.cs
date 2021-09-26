using System.Collections;
using UnityEngine.Events;
using UnityEngine;

public class CoroutineBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEvent startEvent;
    public bool canRun = true;
    public float holdTime = 2f;
    private WaitForSeconds wfs;
    IEnumerator Start()
    {
        wfs = new WaitForSeconds(holdTime);
        while (canRun)
        {
            yield return wfs;
            startEvent.Invoke();
        }
    }
}
