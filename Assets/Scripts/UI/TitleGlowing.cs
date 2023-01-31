using UnityEngine;
using TMPro;

public class TitleGlowing : MonoBehaviour
{
    /*
        class TitleGlowing is create to changle the glow of the font in time
    */

    float timeGlow = 1;
    float minValueGlow = 0.05f;
    float maxWalueGlow = 0.8f;
    public TextMeshProUGUI titleGlowing;

    
    void Update()
    {
        
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
