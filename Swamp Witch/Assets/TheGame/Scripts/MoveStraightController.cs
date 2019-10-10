using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStraightController : MonoBehaviour
{
    public Vector2 velocity;
    private void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = velocity;
    }
}
