using UnityEngine;
 
public class LightBoost : MonoBehaviour
{
    public float duration = 10f;
 
    void Start()
    {
        Light lightObj = GetComponentInChildren<Light>();
 
        if(lightObj != null)
            lightObj.range += 5;
 
        Destroy(this, duration);
    }
 
    void OnDestroy()
    {
        Light lightObj = GetComponentInChildren<Light>();
 
        if(lightObj != null)
            lightObj.range -= 5;
    }
}