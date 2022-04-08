using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float moveSpeed = 300f;
    public float rotationRate = 7.5f;

    void Update()
    {
        ComputerInput();
        MobileInput();
    }

    void ComputerInput()
    {
        if (Input.GetKey("left"))
        {
            transform.RotateAround(
                Vector3.zero, Vector3.forward, moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey("right"))
        {
            transform.RotateAround(
                Vector3.zero, Vector3.forward, -moveSpeed * Time.deltaTime);
        }
    }

    void MobileInput()
    {
        foreach(Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Moved)
            {
                transform.RotateAround(Vector3.zero, Vector3.forward,
                    -touch.deltaPosition.x * rotationRate / 10);
            }
        }

    }

}
