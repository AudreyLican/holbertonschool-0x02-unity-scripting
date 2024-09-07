using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // move Horizontally
        float z = Input.GetAxis("Vertical"); // move vertically

        Vector3 move = new Vector3(x, 0.0f, z);

        // Apply the movement to the player, scaled by speed and deltaTime
        rb.AddForce(move * speed);
    }
}
