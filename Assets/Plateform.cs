using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plateform : MonoBehaviour
{
    public Transform pos1,pos2;
    public float speed;
    Vector3 nextpos;
    void Start()
    {
        nextpos = pos1.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position == pos1.position){
            nextpos = pos2.position;
        }
        if(transform.position == pos2.position){
            nextpos = pos1.position;
        }
        transform.position = Vector3.MoveTowards(transform.position,nextpos,speed * Time.deltaTime);
        
    }
}
