using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionLight : MonoBehaviour
{
    public Light newLight;
    float time = 0;
    public float timeFlicker = 1;

    [SerializeField] private Transform[] positions;

    // Start is called before the first frame update
    void Start()
    {
        newLight = GetComponent<Light>();
        
    }

    void Update()
    {
        //sparking light in first 3 seconds
        if(time<3)
        {
            time += Time.deltaTime;
            newLight.intensity = Mathf.Lerp(Random.Range(0, 4), Random.Range(0, 4), Mathf.PingPong(Time.time, timeFlicker));
        }

        //moving light to instruct the player
        
        

    }

    void LightFlicker()
    {


        
    }



}
