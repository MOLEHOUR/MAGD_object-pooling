using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectPooler : MonoBehaviour
{
    public GameObject objectToPool;
    public List<GameObject> thePool = new List<GameObject> ();
    public int startAmount;
    void Start()
    {
        for (int i =0; i < startAmount; i++)
        {
            thePool.Add(Instantiate(objectToPool));
            thePool[i].SetActive(false);
            thePool[i].transform.parent = transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject SpawnObject(Vector3 position, Quaternion rotation)
    {
        GameObject toReturn;
        toReturn = thePool[0];
        thePool.RemoveAt(0);

        toReturn.SetActive(true);
        toReturn.transform.position = position;
        toReturn.transform.rotation = rotation;

        return toReturn;
    }

    public void ReturnObject(GameObject objectToReturn)
    {
        thePool.Add(objectToReturn); 
        objectToReturn.SetActive(false); 
    }
}
