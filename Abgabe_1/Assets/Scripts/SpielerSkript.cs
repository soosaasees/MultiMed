using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpielerSkript : MonoBehaviour
{
    private float rotSpeed=100;
    private float moveSpeed=5;
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
        float rotDirection;
        if(rotateLeft&!rotateRight) {
            rotDirection=-1;
        }
        else if(rotateRight&!rotateLeft)    {
            rotDirection=1;
        }
        else rotDirection=0;

        transform.Rotate (new Vector3(0, rotDirection, 0)*Time.deltaTime*rotSpeed);
    }
}
