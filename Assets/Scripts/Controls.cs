using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public int player;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if(player <= 0)
        {
            player = 1;
        }
        if(player >= 3)
        {
            player = 2;
        }

        if(player == 1)
        {
            if(Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= -0.72)
            {
                transform.position = new Vector3(transform.position.x - Time.deltaTime * speed, transform.position.y, transform.position.z);
            }
            if (Input.GetKey(KeyCode.RightArrow) && transform.position.x <= 0.7)
            {
                transform.position = new Vector3(transform.position.x + Time.deltaTime * speed, transform.position.y, transform.position.z);
            }
            if (Input.GetKey(KeyCode.UpArrow) && transform.position.y <= 0.4)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + Time.deltaTime * speed, transform.position.z);
            }
            if (Input.GetKey(KeyCode.DownArrow) && transform.position.y >= -0.4)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - Time.deltaTime * speed, transform.position.z);
            }
        }

        if (player == 2)
        {
            if (Input.GetKey(KeyCode.A) && transform.position.x >= -0.72)
            {
                transform.position = new Vector3(transform.position.x - Time.deltaTime * speed, transform.position.y, transform.position.z);
            }
            if (Input.GetKey(KeyCode.D) && transform.position.x <= 0.7)
            {
                transform.position = new Vector3(transform.position.x + Time.deltaTime * speed, transform.position.y, transform.position.z);
            }
            if (Input.GetKey(KeyCode.W) && transform.position.y <= 0.4)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + Time.deltaTime * speed, transform.position.z);
            }
            if (Input.GetKey(KeyCode.S) && transform.position.y >= -0.4)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - Time.deltaTime * speed, transform.position.z);
            }
        }
    }
}
