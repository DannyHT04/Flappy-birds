using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class FlyBehavior : MonoBehaviour
{
    // serializedField will allow us to see the variables on unity even if its private
    [SerializeField] private float _velocity = 1.5f;
    [SerializeField] private float _rotationSpeed = 10f;
    // declare as rigidbody 
    private Rigidbody2D _rb;

    private void Start()
    {
        // init rigidbody by getting the component that is attach to this script
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // getting mouse left input and space bar
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            // sets the vertical velocity of the Rigidbody2D to move the GameObject upwards at a specified speed.
            _rb.velocity = Vector2.up * _velocity;
        }
    }

    private void FixedUpdate()
    {
        //controls how sensitive the rotation is to changes in vertical velocity.
        // Every frame, the GameObject's rotation is updated based on its current vertical velocity.
        transform.rotation = Quaternion.Euler(0, 0, _rb.velocity.y * _rotationSpeed);
    }
}
