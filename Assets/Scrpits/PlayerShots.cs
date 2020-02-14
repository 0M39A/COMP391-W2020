using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShots : MonoBehaviour
{
    //PUBLIC VARIABLES
    public float speed = 20.0f;

    //PRIAVTE VARIABLES
    private Rigidbody2D rBody;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        rBody.velocity = new Vector2(speed, 0.0f);
    }

}
