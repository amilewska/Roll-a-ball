using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformSphere : MonoBehaviour
{
    [SerializeField]GameObject sphere;

    // Update is called once per frame
    void Update()
    {
        if (sphere.transform.position.y < -10) sphere.transform.position = new Vector3(5, 8, -0.6f);
    }
}
