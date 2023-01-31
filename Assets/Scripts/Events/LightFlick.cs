using UnityEngine;

public class LightFlick : MonoBehaviour
{
    /*
        class LightFlick is create to:
        - show Starting Red Light
    */

    Light newLight;
    float time = 0;
    public float timeFlicker = 1;
    [SerializeField] float maxIntensity = 6;


    // Start is called before the first frame update
    void Start()
    {
        newLight = GetComponent<Light>();
        
    }

    void Update()
    {
        //sparking light in first 4 seconds
        LightFlicker();

    }

    void LightFlicker()
    {
        if (time < 4)
        {
            time += Time.deltaTime;
            newLight.intensity = Mathf.Lerp(Random.Range(0, maxIntensity), Random.Range(0, maxIntensity), Mathf.PingPong(Time.time, timeFlicker));
        }

    }

}
