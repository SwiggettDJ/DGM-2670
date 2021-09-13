using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnInstance(GameObject obj)
    {
        Instantiate(obj);
    }
}
