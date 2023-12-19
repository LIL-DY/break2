using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karaktär : MonoBehaviour
{
    Rigidbody myRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRigidBody.AddForce(new Vector3(25, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidBody.AddForce(new Vector3(-25, 0, 0));
        }

    }
}
