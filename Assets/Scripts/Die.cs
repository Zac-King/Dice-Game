using UnityEngine;
using System.Collections;

public class Die : MonoBehaviour {

    public int value;

    [SerializeField]
    private int numOfSides;

	// Use this for initialization
	void Start ()
    {
        value = Random.Range(1, numOfSides);
	}
	
	public void Roll()
    {
        value = Random.Range(1, numOfSides);
    }

}
