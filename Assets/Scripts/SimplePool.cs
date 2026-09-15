using System.Collections.Generic;
using UnityEngine;

public class SimplePool : MonoBehaviour
{
    public GameObject prefab;
    public int poolSize = 10;
    private List<GameObject> pool = new List<GameObject>();

    private void Awake()
    {
        // Use this one for slide 13.
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.SetActive(false);
            pool.Add(obj);
        }
    }

    // Use this one for slide 14.
    public GameObject GetFromPool()
    {
        foreach (GameObject obj in pool)
        {
            if (!obj.activeInHierarchy)
            {
                obj.SetActive(true);
                return obj;
            }
        }
        GameObject newObject = Instantiate(prefab);
        pool.Add(newObject);
        newObject.SetActive(true);
        return newObject;
    }
}
