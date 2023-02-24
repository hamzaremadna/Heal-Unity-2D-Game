using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
public float speed;
public float a;
public float b;
public float c;
public float d;

public GameObject projectile;
public Transform player;


   void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        c = d; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position,player.position) > a){
            transform.position = Vector2.MoveTowards(transform.position,player.position,speed * Time.deltaTime);

        }else if(Vector2.Distance(transform.position,player.position) < a && Vector2.Distance(transform.position,player.position) > b ){
            transform.position = this.transform.position;
        }else if(Vector2.Distance(transform.position,player.position) < b ){
                        transform.position = Vector2.MoveTowards(transform.position,player.position,-speed * Time.deltaTime);

        }

    if(c <= 0){
      Instantiate(projectile, transform.position,Quaternion.identity);
         c = d;
    }else{
        c -= Time.deltaTime;
    }    
    }



}
