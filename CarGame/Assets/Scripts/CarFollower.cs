using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarFollower : MonoBehaviour
{
    public Transform cartransform;
    public Transform cameratransform;
    

    void LateUpdate()
    {
        cameratransform.position = new Vector3(cartransform.position.x,cartransform.position.y,-10f;)
    }
}
