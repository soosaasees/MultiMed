using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpielerSkript : MonoBehaviour
{
    private float rotSpeed=1;
    private float moveSpeed=5;
    private float rotDirection=0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal= Input.GetAxis("Horizontal");
        float moveVertical=Input.GetAxis("Vertical"); 
        bool rotateLeft=Input.GetKey("q");
        bool rotateRight=Input.GetKey("e");
        Vector3 moveDirection=transform.rotation* new Vector3(moveHorizontal, 0, moveVertical)  ;
        transform.position+=moveDirection*moveSpeed*Time.deltaTime;
        if(rotateLeft&!rotateRight) {
           rotDirection-=rotSpeed*Time.deltaTime;
        }
        else if(rotateRight&!rotateLeft)    {
          rotDirection+=rotSpeed*Time.deltaTime;
        }
        Vector3 targetDirection=new Vector3(Mathf.Sin(rotDirection), 0, Mathf.Cos(rotDirection));
       transform.rotation=Quaternion.LookRotation(targetDirection);
    }
}
