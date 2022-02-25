using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{   
    [SerializeField] float moveSpeed = 15f;
    [SerializeField] float rotateSpeed = 300f;
    [SerializeField] float slowSpeed = 10f;
    [SerializeField] float boostSpeed = 25f;

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(0, moveAmount, 0); 

        if(moveAmount < 0) { steerAmount *= -1; }
        transform.Rotate(0, 0, -steerAmount);
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        moveSpeed = slowSpeed;    
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }    
    }
}
