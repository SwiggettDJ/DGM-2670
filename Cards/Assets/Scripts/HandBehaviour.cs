using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HandBehaviour : MonoBehaviour
{
    public HandSO hand;
    public List<Button> cardSlots;


    void Awake()
    {
        hand.ClearHand();
        hand.maxHandSize = cardSlots.Count;
        foreach (Button slot in cardSlots)
        {
            DisableEnable(slot.image,false);
        }
    }

    //Called at start and whenever the hand is changed
    public void UpdateHand()
    {
        while (hand.contents.Count > hand.maxHandSize)
        {
            hand.SubtractFromHand(hand.contents.Count-1);
        }

        int i = 0;
        foreach (Button slot in cardSlots)
        {
            if (i > hand.contents.Count-1)
            {
                DisableEnable(slot.image,false);
                i++;
            }
            else
            {
                DisableEnable(slot.image,true);
                slot.image.color = hand.contents[i].cardColor;
                slot.image.sprite = hand.contents[i].art;
                i++;
            }
        }
        
    }

    private void DisableEnable (Image slotArt, Boolean toShow)
    {
        slotArt.enabled = toShow;
    }

    public void SubtractFromHand (Button slot)
    {
        hand.SubtractFromHand(cardSlots.IndexOf(slot));
    }

    public void UsePower(Button slot)
    {
        CardSO correspondingCard = hand.contents[cardSlots.IndexOf(slot)];
        correspondingCard.power.RaiseAction();
    }
}
