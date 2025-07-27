using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    
    public float rotationSpeed, moveSpeed;
    public Transform Cartransform;

    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        Debug.Log("horizontal:" + horizontalMovement + "vertical:" + verticalMovement);

        if(Mathf.Abs(horizontalMovement) > 0.01f)
        {
            Cartransform.Rotate(0f,0f,-1*rotationSpeed*horizontalMovement);
        }
        if(Mathf.Abs(verticalMovement) > 0.01f)
        {
            Cartransform.Translate(0f,moveSpeed * verticalMovement,0f);
        }

    }
}
