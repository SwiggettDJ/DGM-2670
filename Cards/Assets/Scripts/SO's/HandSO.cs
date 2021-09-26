using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class HandSO : ScriptableObject
{
    public List<CardSO> Hand;

    public void AddToHand (CardSO obj)
    {
        Hand.Add(obj);
        obj.inHand = true;
    }
}
