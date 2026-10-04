using UnityEngine;
using TMPro;
 
public class GameTimer : MonoBehaviour
{
    public float gameTime = 90f;
 
    public TextMeshProUGUI timerText;
 
    public GameObject player2WinScreen;
 
    private bool gameEnded = false;
 
    void Update()
    {
        if (gameEnded)
            return;
 
        gameTime -= Time.deltaTime;
 
        timerText.text = Mathf.Ceil(gameTime).ToString();
 
        if (gameTime <= 0)
        {
            gameTime = 0;
 
            gameEnded = true;
 
            player2WinScreen.SetActive(true);
        }
    }
}