using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class HandSO : ScriptableObject
{
    public List<CardSO> contents;
    public int maxHandSize;

    public void ClearHand()
    {
        contents.Clear();
    }
    public void AddToHand (CardSO obj)
    {
        contents.Add(obj);
    }

    public void SubtractFromHand(int index)
    {
        contents.RemoveAt(index);
    }
}
