using UnityEngine;
using UnityEngine.Rendering.Universal;
 
public class LightBoost : MonoBehaviour
{
    public float duration = 10f;
    public float lightIncrease = 2f;
 
    private Light2D playerLight;
 
    void Start()
    {
        playerLight = GetComponentInChildren<Light2D>();
 
        if (playerLight != null)
        {
            playerLight.pointLightOuterRadius += lightIncrease;
        }
 
        Destroy(this, duration);
    }
 
    private void OnDestroy()
    {
        if (playerLight != null)
        {
            playerLight.pointLightOuterRadius -= lightIncrease;
        }
    }
}
