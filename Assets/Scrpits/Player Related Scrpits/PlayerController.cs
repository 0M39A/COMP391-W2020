﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //VARIABLES
    public float speed,  MinX, MaxX, MinY, MaxY;
    public GameObject PlayerShot;
    public GameObject PlayerShotSpawn;

    private Rigidbody2D Pbody;
    public float FireRate = 0.25f;
    private float Timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        Pbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        GetComponent<Rigidbody2D>().velocity = new Vector2(horiz, vert) * speed;

        //RESTRICTION CODE
        Pbody.position= new Vector2(Mathf.Clamp(Pbody.position.x, MinX, MaxX), Mathf.Clamp(Pbody.position.y, MinY, MaxY));
    }

    void Update()
    {
        //CHECK IF FIRE BUTTON IS PRESSED
        if(Input.GetAxis("Fire1") > 0 && Timer > FireRate)
        {
            //IF YES SPWAN SHOT
            GameObject.Instantiate(PlayerShot, PlayerShotSpawn.transform.position, Quaternion.identity);

            //RESET TIMER
            Timer = 0;
        }
        Timer += Time.deltaTime;
    }
}