using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            _rigidbody.AddForce(Vector3.forward * _speed);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            _rigidbody.AddForce(Vector3.left * _speed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.AddForce(Vector3.right * _speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            _rigidbody.AddForce(Vector3.back * _speed);
        }
    }
}
