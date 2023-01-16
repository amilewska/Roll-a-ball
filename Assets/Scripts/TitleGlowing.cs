using UnityEngine;
using TMPro;

public class TitleGlowing : MonoBehaviour
{
    float timeGlow = 1;
    float minValueGlow = 0.05f;
    float maxWalueGlow = 0.8f;
    public TextMeshProUGUI titleGlowing;

    // Update is called once per frame
    void Update()
    {
        //changing glwo of title in time
        titleGlowing.fontSharedMaterial.SetFloat(ShaderUtilities.ID_GlowOuter, Mathf.Lerp(minValueGlow, maxWalueGlow, timeGlow));
        timeGlow += Time.deltaTime;
        if (timeGlow > 2)
        {
            float temp = maxWalueGlow;
            maxWalueGlow = minValueGlow;
            minValueGlow = temp;
            timeGlow = 0;
        }
    }
}
