using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuenzSkript : MonoBehaviour
{
    public Transform myPrefab;
    private LinkedList<Transform> myList=new LinkedList<Transform>();
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<6; i++)  {
            Transform t=Instantiate(myPrefab, new Vector3(UnityEngine.Random.Range(0, 10),0.5f, UnityEngine.Random.Range(0, 10)), Quaternion.identity );
            myList.AddLast(t);
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Transform t in myList)  {
            t.Rotate(new Vector3(0, 50f, 0)*Time.deltaTime);
        }
    }
}