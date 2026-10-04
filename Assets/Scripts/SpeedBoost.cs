using UnityEngine;
 
public class SpeedBoost : MonoBehaviour
{
    public float duration = 5f;
 
    private Player2Movement player;
 
    void Start()
    {
        player = GetComponent<Player2Movement>();
 
        player.moveSpeed += 3;
 
        Destroy(this, duration);
    }
 
    void OnDestroy()
    {
        if(player != null)
            player.moveSpeed -= 3;
    }
}