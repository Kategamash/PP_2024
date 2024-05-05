using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public static PlayerControler Instance { get; private set; }

    [SerializeField] private float movingSpeed;

    private Rigidbody2D rb;

    private float minMovingSpeed = 0.1f;
    private bool isMoving = false;

    private void Awake()
    {
        Instance = this;
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        HadleMovement();
    }

    private void HadleMovement()
    {
        Vector2 inputVector = GameInput.Instance.GetMovementVector();
        rb.MovePosition(rb.position + inputVector * (Time.fixedDeltaTime * movingSpeed));
        
        if (Mathf.Abs(inputVector.x) > minMovingSpeed || Mathf.Abs(inputVector.y) > minMovingSpeed)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        Debug.Log(inputVector);
    }

    public bool IsMoving()
    {
        return isMoving;
    }

    public Vector3 GetPlayerScreenPosition()
    {
        Vector3 playerScreenPosition = Camera.main.WorldToScreenPoint(transform.position);
        return playerScreenPosition;
    }
}
