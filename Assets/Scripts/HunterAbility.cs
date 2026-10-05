using UnityEngine;
using UnityEngine.InputSystem;
 
public class HunterAbility : MonoBehaviour
{
    public GameObject arrow;
    public Transform player2;
 
    public float cooldown = 60f;
 
    private float cooldownTimer = 0f;
 
    void Update()
    {
        cooldownTimer -= Time.deltaTime;
 
        if (Keyboard.current.qKey.wasPressedThisFrame &&
            cooldownTimer <= 0f)
        {
            cooldownTimer = cooldown;
 
            arrow.SetActive(true);
 
            Invoke(nameof(HideArrow), 10f);
        }
 
        if (arrow.activeSelf)
        {
            PointToPlayer2();
        }
    }
 
    void PointToPlayer2()
    {
        Vector2 direction =
            player2.position - arrow.transform.position;
 
        float angle =
            Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
 
        arrow.transform.rotation =
            Quaternion.Euler(0, 0, angle);
    }
 
    void HideArrow()
    {
        arrow.SetActive(false);
    }
}