using UnityEngine;
using UnityEngine.InputSystem;
 
public class HunterAbility : MonoBehaviour
{
    public GameObject arrow;
    public float cooldown = 60f;
 
    private float currentCooldown;
 
    void Update()
    {
        currentCooldown -= Time.deltaTime;
 
        if(Keyboard.current.qKey.wasPressedThisFrame &&
           currentCooldown <= 0)
        {
            currentCooldown = cooldown;
 
            arrow.SetActive(true);
 
            Invoke(nameof(HideArrow), 3f);
        }
    }
 
    void HideArrow()
    {
        arrow.SetActive(false);
    }
}