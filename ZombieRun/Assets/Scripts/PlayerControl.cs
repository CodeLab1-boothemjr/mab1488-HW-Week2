using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float forceAmount = 5;
    private Rigidbody _rb;
    
    private void Awake()
    {
        transform.position = GameObject.Find("StartPos").transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        // assign rigidbody of this object when created
        _rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        // WASD CONTROLS
        if (Input.GetKey(KeyCode.W))
        {
            _rb.AddForce(Vector3.forward * forceAmount);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _rb.AddForce(Vector3.left * forceAmount);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _rb.AddForce(Vector3.back * forceAmount);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rb.AddForce(Vector3.right * forceAmount);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "EndPos")
        {
            GameManager.AdvanceCurrentLevel();
        }
    }
}
