using UnityEngine;
using System.Collections.Generic;

public class Populate : MonoBehaviour {
    [SerializeField]
    int size;
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    List<GameObject> objects = new List<GameObject>();
    

    [ContextMenu("Populate Player's Stash")]
    void Pop()
    {
        for (int i = 0; i < size; i++)
        {
            GameObject go = Instantiate(prefab);
            objects.Add(go);
        }
    }

    [ContextMenu("Destroy List")]
    void ClearPop()
    {
        foreach (GameObject go in objects)
            DestroyImmediate(go);

        objects = new List<GameObject>();
    }
}
