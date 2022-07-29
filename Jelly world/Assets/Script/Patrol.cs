using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{

    public float speed;
    public float distance;

    public Transform groundCheck;

    private bool isPatrol = true;

    

    // Update is called once per frame
    void Update()
    {
        // Patroling Logic
        if (isPatrol == true)
        {
            transform.Translate(Vector2.left * speed * Time.fixedDeltaTime);

            RaycastHit2D groundInfo = Physics2D.Raycast(groundCheck.position, Vector2.down, distance);


            if (groundInfo == false)
            {
                transform.Rotate(0f, 180f, 0f);
            }
        }
    }
}
