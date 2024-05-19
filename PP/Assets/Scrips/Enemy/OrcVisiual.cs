using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcVisiual : MonoBehaviour
{
    private Animator animator;

    private const string IS_MOVING = "isMoving";
    private bool isMoving = false;
    Vector3 lastPosition;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        IsMoving();
        animator.SetBool(IS_MOVING, isMoving);
    }

    private void IsMoving()
    {
        if (lastPosition == transform.position)
        {
            isMoving = false;
        }
        else
        {
            isMoving = true;
        }
        lastPosition = transform.position;
    }

}
