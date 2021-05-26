using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuenzSkript : MonoBehaviour
{
    public Transform myPrefab;
    public Transform meineVFX;
    public GameObject myParent;
    private LinkedList<Transform> myPrefabList=new LinkedList<Transform>();
    private LinkedList<Vector3> myPositionList=new LinkedList<Vector3>();
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<6; i++)  {
            Transform t=Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity );
            t.SetParent(myParent.transform);
            myPrefabList.AddLast(t);
            Transform v=Instantiate(meineVFX, new Vector3(0,0,0), Quaternion.identity);
            v.SetParent(t);
            //v.localPosition=new Vector3(0,0,0);

            myPositionList.AddLast(new Vector3(UnityEngine.Random.Range(-0.5f, 0.5f), 1.5f, UnityEngine.Random.Range(-0.5f, 0.5f)));
        }
    }

    // Update is called once per frame
    void Update()
    {
        LinkedListNode<Vector3> node=myPositionList.First;
        foreach(Transform t in myPrefabList)  {
            
            t.localPosition=node.Value;
            node=node.Next;
            t.Rotate(new Vector3(0, 50f, 0)*Time.deltaTime);
        }
    }
}