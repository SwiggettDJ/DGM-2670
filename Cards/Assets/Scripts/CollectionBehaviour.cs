using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionBehaviour : MonoBehaviour
{
    public CardSO card;
    public HandSO hand;
    private SpriteRenderer artSpriteRenderer;
    private GameObject art;
    void Awake()
    {
        art = GetComponentInChildren<Transform>().gameObject;
        artSpriteRenderer = GetComponentInChildren<SpriteRenderer>();
        artSpriteRenderer.sprite = card.art;
        artSpriteRenderer.color = card.cardColor;
        
        EnableDisableCollectable(!card.inHand);
    }

    private void OnMouseDown()
    {
        hand.AddToHand(card);
        EnableDisableCollectable(false);
    }


    private void EnableDisableCollectable(bool value)
    {
        art.SetActive(value);
        GetComponent<Collider>().enabled = value;
    }
}
