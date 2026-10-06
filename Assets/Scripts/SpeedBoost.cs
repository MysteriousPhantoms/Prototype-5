using UnityEngine;
 
public class SpeedBoost : MonoBehaviour
{
    public float duration = 2f;
    public float speedBoost = 1f;
 
    private Player2Movement player;
 
    void Start()
    {
        player = GetComponent<Player2Movement>();
 
        if (player != null)
        {
            player.moveSpeed += speedBoost;
        }
 
        Destroy(this, duration);
    }
 
    private void OnDestroy()
    {
        if (player != null)
        {
            player.moveSpeed -= speedBoost;
        }
    }
}
