using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpielerSkript : MonoBehaviour
{
    private float rotSpeed=1;
    private float moveSpeed=0.05f;
    private float rotDirection=0;
    public float moveHorizontal=0;
    public float moveVertical=0; 
    public bool rotateLeft=false;
    public bool rotateRight=false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection=transform.rotation* new Vector3(moveHorizontal, 0, moveVertical)  ;
        transform.position+=moveDirection*moveSpeed*Time.deltaTime;
        if(rotateLeft&!rotateRight) {
           rotDirection-=rotSpeed*Time.deltaTime;
        }
        else if(rotateRight&!rotateLeft)    {
          rotDirection+=rotSpeed*Time.deltaTime;
        }
        Vector3 targetDirection=new Vector3(Mathf.Sin(rotDirection), 0, Mathf.Cos(rotDirection));
       transform.localRotation=Quaternion.LookRotation(targetDirection);
    }
}
