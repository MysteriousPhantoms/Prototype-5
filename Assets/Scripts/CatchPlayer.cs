using UnityEngine;
 
public class CatchPlayer : MonoBehaviour
{
    public GameObject player1WinScreen;
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player2"))
        {
            player1WinScreen.SetActive(true);
        }
    }
}