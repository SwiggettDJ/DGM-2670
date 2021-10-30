using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollectionBehaviour : MonoBehaviour
{
    public CardSO card;
    public HandSO hand;
    private SpriteRenderer artSpriteRenderer;
    private GameObject art;
    public UnityEvent pickUpEvent;
    void Awake()
    {
        art = GetComponentInChildren<Transform>().gameObject;
        artSpriteRenderer = GetComponentInChildren<SpriteRenderer>();
        artSpriteRenderer.sprite = card.art;
        artSpriteRenderer.color = card.cardColor;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hand.AddToHand(card); 
            EnableDisableCollectable(false);
            pickUpEvent.Invoke();
        }
    }


    private void EnableDisableCollectable(bool value)
    {
        art.SetActive(value);
        GetComponent<Collider>().enabled = value;
    }
    
    
}
