using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;

    private int score = 0;

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

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pickup")
        {
            // increment the value score when the player touch an object tagged Pickup
            score++;

            // Outpt Debug.Log()
            Debug.Log("Score:" + score);

            //disabled object after the player touch it
            Destroy(other.gameObject);
        }
    }
}
