using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{ 
    public float speed;
    public int posOFpatrol;
    public Transform point;
    bool moveingRight;
    Transform player;
    public float AngryDist;
    bool chill = false;
    bool angry = false;
    bool goback = false;
    

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

  
    void FixedUpdate()
    {
        if (Vector2.Distance(transform.position, point.position) < posOFpatrol && angry == false)
        {
            chill=true;
        }
        if (Vector2.Distance(transform.position, player.position) < AngryDist)
        {
            angry=true;
            chill = false;
            goback = false;
        }
        if (Vector2.Distance(transform.position, player.position) > AngryDist)
        {
            goback=true;
            angry = false;
        }
        if (chill == true)
        {
            Chill();
        }
        else if (angry==true)
        {
            Angry();
        }
        else if (goback==true)
        {
            GoBack();
        }
        
    }
    void Chill()
    {
        if (transform.position.x > point.position.x + posOFpatrol)
        {
            moveingRight = false;
        }
        
        else if (transform.position.x < point.position.x - posOFpatrol)
            {
                moveingRight = true;
            }
            if (moveingRight)
            {
                transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
            }
            else
            {
                transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
            }
        speed = 2;
        
    }
    void Angry()
    {
        transform.position =  Vector2.MoveTowards(transform.position, player.position,speed * Time.deltaTime);
        speed = 10;
    }
    void GoBack()
    {
        transform.position = Vector2.MoveTowards(transform.position, point.position, speed * Time.deltaTime);
        speed = 5;
    }
   
    }
