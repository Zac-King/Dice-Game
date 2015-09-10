using UnityEngine;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    public int diceCount;
    public GameObject diePrefab;

    private bool outOfGame;     // is the player still in the Game
    private List<GameObject> dice;


    [ContextMenu("Populate Player's Stash")]
    void PopDice()
    {
        for (int i = 0; i < diceCount; i++)
        {
            GameObject go = Instantiate(diePrefab);
            dice.Add(go);
        }
    }

    [ContextMenu("Destroy List")]
    void ClearDice()
    {
        for (int i = 0; i < dice.Count; i++)
        {
            DestroyImmediate(dice[i]);
        }

        dice.Clear();
    }


    public void RerollStash()
    {
        print("Reroll Hit");
        //rerolls all the remaining Dice
        for (int i = 0; i < dice.Count; i++)
        {
            dice[i].GetComponent<Die>().Roll();
            print("Hit Loop");
        }

        // Print Loop for Test
        for (int j = 0; j < dice.Count; j++)
        {
            print(dice[j].GetComponent<Die>().value);
        }
    }

    //void MakePlay()
    //{

    //}
}
