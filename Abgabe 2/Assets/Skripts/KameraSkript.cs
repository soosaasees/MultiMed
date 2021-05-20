using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraSkript : MonoBehaviour
{
    public Transform target;
    private Vector3 offset=new Vector3(0, 1, -5);
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offsetRotated= target.rotation*offset;
        transform.position=target.transform.position+offsetRotated;
        transform.rotation=target.rotation;
    }
}
