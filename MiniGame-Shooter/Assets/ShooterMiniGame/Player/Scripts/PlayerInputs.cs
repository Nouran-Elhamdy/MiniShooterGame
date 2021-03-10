using UnityEngine;
public class PlayerInputs : MonoBehaviour
{
    [Header ("Movments Events")]

    [SerializeField] SO.Events.EventSO OnMoveForward;
    [SerializeField] SO.Events.EventSO OnMoveBackward;
    [SerializeField] SO.Events.EventSO OnMoveLeft;
    [SerializeField] SO.Events.EventSO OnMoveRight;

    [Header("Attacking Events")]

    [SerializeField] SO.Events.EventSO OnShootingBullets;
    [SerializeField] SO.Events.EventSO OnThrowingGrenades;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Shoot");
            OnShootingBullets.Raise();
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Throw");
            OnThrowingGrenades.Raise();
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("move forward");
            OnMoveForward.Raise();
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("move backward");
            OnMoveBackward.Raise();
        }
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("move left");
            OnMoveLeft.Raise();
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("move right");
            OnMoveRight.Raise();
        }
    }
}
