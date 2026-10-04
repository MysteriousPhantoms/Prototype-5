using UnityEngine;
using UnityEngine.InputSystem;
 
public class Player2Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
 
    void Update()
    {
        if (Gamepad.current == null)
            return;
 
        Vector2 move = Gamepad.current.leftStick.ReadValue();
 
        transform.position += (Vector3)move * moveSpeed * Time.deltaTime;
    }
}