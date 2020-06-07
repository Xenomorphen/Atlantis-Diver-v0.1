    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_piece : MonoBehaviour
{
    public float speed;

    void Update()
    {
        gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - Time.deltaTime * speed);   
    }
}
