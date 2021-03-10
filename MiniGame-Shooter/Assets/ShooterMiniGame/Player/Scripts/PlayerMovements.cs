using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    public void MoveForward()
    {
        transform.Translate(new Vector3(0, 0, 1) * movementSpeed);
    }
    public void MoveBackward()
    {
        transform.Translate(new Vector3(0, 0, -1) * movementSpeed);
    }
    public void MoveLeft()
    {
        transform.Translate(new Vector3(-1, 0, 0) * movementSpeed);
    }
    public void MoveRight()
    {
        transform.Translate(new Vector3(1, 0, 0) * movementSpeed);
    }
}
