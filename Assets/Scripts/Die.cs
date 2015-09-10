using UnityEngine;
using System.Collections.Generic;

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

        switch(value)
        {
            case 1:
                transform.eulerAngles = new Vector3(0,0,0); 
                break;
            case 2:
                transform.eulerAngles = new Vector3(0, 0, 90);
                break;
            case 3:
                transform.eulerAngles = new Vector3(90, 0, 0);
                break;
            case 4:
                transform.eulerAngles = new Vector3(-90, 0, 0);
                break;
            case 5:
                transform.eulerAngles = new Vector3(0, 0, -90);
                break;
            case 6:
                transform.eulerAngles = new Vector3(180, 0, 0);
                break;

        }
    }

}
