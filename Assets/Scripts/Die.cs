using UnityEngine;
using System.Collections;

public class Die : MonoBehaviour {

    public int value;

	// Use this for initialization
	void Start ()
    {
        value = Random.Range(1, 6);
	}
	
	public void Roll()
    {
        value = Random.Range(1, 6);
    }

}
