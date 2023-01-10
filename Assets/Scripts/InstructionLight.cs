using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionLight : MonoBehaviour
{
    [SerializeField] private Transform startPos;
    [SerializeField] private Transform mid1Pos;
    [SerializeField] private Transform mid2Pos;
    [SerializeField] private Transform endPos;


    public Transform[] positions;
    public int i = 0;
    public float lerpAmount = 0;
    public float lerpSpeed = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LightSpark());
        StartCoroutine(LightMove());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LightSpark()
    {
        yield return new WaitForSeconds(.05f);
        GetComponent<Light>().intensity = 6;
        yield return new WaitForSeconds(.05f);
        GetComponent<Light>().intensity = 3;
        yield return new WaitForSeconds(.05f);
        GetComponent<Light>().intensity = 5;
        yield return new WaitForSeconds(.05f);
        GetComponent<Light>().intensity = 6;
        yield return new WaitForSeconds(2f);
    }
    IEnumerator LightMove()
    {
        
            if (lerpAmount >= 1f)

                lerpAmount = 0;
            lerpAmount += lerpSpeed * Time.deltaTime;

            //Here the lerp from place to place takes place, this way it keeps looping between these positions.
            transform.position = Vector3.Lerp(positions[i % positions.Length].position, positions[(i + 1) % positions.Length].position, lerpAmount);

            //since lerp never actually reaches its target you need to check for the distance and can't just say if the lerps final position is reached up "i" by 1.
            if (Vector3.Distance(transform.position, positions[(i + 1) % positions.Length].position) < 0.13333)
            {
                i++;
                lerpAmount = 1;
            }
        
        
        yield return new WaitForSeconds(2f);
    }
}
