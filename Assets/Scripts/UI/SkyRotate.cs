using UnityEngine;

public class SkyRotate : MonoBehaviour
{
    /*
        class SkyRotate is create to rotate the sky in the background menu
    */
    float rotateSpeed = 1f;

    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotateSpeed);
    }
}
