using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    /*
        class Rotator is create to rotates the pick up
    */
    void Update()
    {
        transform.Rotate(new Vector3(15,30,45)*Time.deltaTime);
    }

    
}
