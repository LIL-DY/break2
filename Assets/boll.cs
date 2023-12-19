using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boll : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody bol;
    void Start()
    {
        transform.position += new Vector3(0, -1, 0);
        bol = GetComponent<Rigidbody>();
        bol.velocity = new Vector3(0, -100, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
