using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] Rigidbody2D rbody;
    [SerializeField] Animator anmtr;
    [Header("Movement")]
    public bool canMove;
    [SerializeField] float speed;
    [Header("Inputs")]
    [SerializeField] Vector2 inputSpeed;
    [SerializeField] Vector2 lastInputSpeed;

    #region Unity Methods
    private void Start()
    {
        SetUp();
    }
    private void Update()
    {
        InputHandling();
        AnimationHandling();
    }
    private void FixedUpdate()
    {
        Movement();
    }
    #endregion


    void SetUp()
    {
        canMove = true;
    }

    void InputHandling()
    {
        inputSpeed = Vector2.up * Input.GetAxisRaw("Vertical") + Vector2.right * Input.GetAxisRaw("Horizontal");
        //This is so that the player looks at the last direction it moved to. 
        if (inputSpeed.x !=0 || inputSpeed.y != 0)
        {
            lastInputSpeed = inputSpeed;
        }
    }

    void Movement()
    {
        if (canMove)
        {
            rbody.velocity = inputSpeed.normalized * speed;
        }
    }

    public void AnimationHandling()
    {
        anmtr.SetFloat("SpeedX",inputSpeed.x);
        anmtr.SetFloat("SpeedY", inputSpeed.y);
        anmtr.SetFloat("LastMovingSpeedX", lastInputSpeed.x);
        anmtr.SetFloat("LastMovingSpeedY", lastInputSpeed.y);
        anmtr.SetBool("IsMoving", inputSpeed.magnitude > 0);
    }

}
