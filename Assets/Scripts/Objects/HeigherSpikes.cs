using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeigherSpikes : MonoBehaviour
{
    /*
        class HeigherSpikes is create to:
        - moves height of spikes
    */

    [SerializeField] Transform startScale;
    [SerializeField] Transform endScale;
    [SerializeField] private float speed = 0.5f;
    private float target, current;

    void Update()
    {
        if (current == target) target = target == 0 ? 1 : 0;
        current = Mathf.MoveTowards(current, target, speed * Time.deltaTime);
        transform.localScale = Vector3.Lerp(startScale.localScale, endScale.localScale, current);
    }
}
