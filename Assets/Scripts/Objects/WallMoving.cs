using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMoving : MonoBehaviour
{
    /*
        class WallMoving is create to:
        - moves smoothly the wall via Lerp function
        - moves the wall from A to B and from B to A constantly
    */

    [SerializeField] private Transform startPos;
    [SerializeField] private Transform endPos;
    [SerializeField] private float speed = 0.5f;
    private float target, current;

    // Update is called once per frame
    void Update()
    {
        if (current==target) target = target == 0 ? 1 : 0;
        current = Mathf.MoveTowards(current, target, speed * Time.deltaTime);
        transform.position = Vector3.Lerp(startPos.position, endPos.position, current);
    }

}
