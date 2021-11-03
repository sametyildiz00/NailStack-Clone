using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 8f;
    private float horizontalSpeed = 10f;
    public Rigidbody rb;
    public Vector3 moveVector;

    private void Start()
    {
        rb.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        TouchMovement();
        AutoMoveForward();
    }
    public void TouchMovement()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (touch.position.x < Screen.width / 2)
                        rb.velocity = new Vector3(0f, 0f, horizontalSpeed);

                    if (touch.position.x > Screen.width / 2)
                        rb.velocity = new Vector3(0f, 0f, -horizontalSpeed);
                    break;

                case TouchPhase.Ended:
                    rb.velocity = new Vector3(0f, 0f, 0f);
                    break;
            }
        }
    }
    public void AutoMoveForward()
    {
        transform.Translate(moveVector * speed * Time.deltaTime);
    }
}
