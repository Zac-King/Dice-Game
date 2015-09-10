using UnityEngine;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    public int diceCount;
    public GameObject diePrefab;
    public GameObject myStash;

    private bool outOfGame;     // is the player still in the Game

    [SerializeField]
    private List<GameObject> dice = new List<GameObject>();


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
        print("clearing list");
        foreach (GameObject go in dice)
            DestroyImmediate(go);

        dice.Clear();
    }


    public void RerollStash()
    {
        print("Reroll Hit");
        //rerolls all the remaining Dice
        foreach (GameObject go in dice)
            go.GetComponent<Die>().Roll();
        //for (int i = 0; i < dice.Count; i++)
        //{
        //    dice[i].GetComponent<Die>().Roll();
        //    print("Hit Loop");
        //}

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
