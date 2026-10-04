using UnityEngine;
 
public class SpeedPickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player2"))
        {
            other.gameObject.AddComponent<SpeedBoost>();
 
            Destroy(gameObject);
        }
    }
}