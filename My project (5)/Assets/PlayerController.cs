using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody PlayerRigidBody;
    public float speed = 8f;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRigidBody = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow) == true)
        {
            PlayerRigidBody.AddForce(0f, 0f, speed);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            PlayerRigidBody.AddForce(0f, 0f, -speed);
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            PlayerRigidBody.AddForce(-speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            PlayerRigidBody.AddForce(speed, 0f, 0f);
        }

    }
    public void Die()
    {
        gameObject.SetActive(false);
    }
}
