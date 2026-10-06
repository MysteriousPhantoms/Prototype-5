using UnityEngine;

public class LightPickup : MonoBehaviour
{
    public float duration = 10f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player1") || other.CompareTag("Player2"))
        {
            other.gameObject.AddComponent<LightBoost>();

            Destroy(gameObject);
        }
    }
}
