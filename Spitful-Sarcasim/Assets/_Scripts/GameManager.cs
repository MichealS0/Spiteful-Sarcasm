using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    public Transform[] cardSlots;
    public bool[] availableCardSlots;

    public void DrawCard()
    {
        if (deck.Count >= 1)
        {
            Card chosenCard = deck[Random.Range(0, deck.Count)];

            for (int i = 0; i < availableCardSlots.Length; i++)
            {
                if (availableCardSlots[i] == true)
                {
                    chosenCard.gameObject.SetActive(true);
                    chosenCard.transform.position = cardSlots[i].position;
                    availableCardSlots[i] = false;
                    deck.Remove(chosenCard);
                    return;
                }
            }
        }
    }
}
