using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
    [Header("Components")]
    [SerializeField] Rigidbody2D rbody;
    [SerializeField] Animator anmtr;
    [Header("Movement")]
    public bool canMove;
    [SerializeField] float speed;
    [Header("Inputs")]
    [SerializeField] Vector2 inputSpeed;
    [SerializeField] Vector2 lastInputSpeed;
    [Header("Interaction")]
    [SerializeField] Interactable activeInteractable;
    [Header("Customization")]
    public PlayerCustomization playerCustomization;

    #region Unity Methods
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(instance.gameObject);
        }
    }
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

        if(Input.GetButton("Jump"))
        {
            Interact();
        }
        if (Input.GetButton("Cancel"))
        {
            EndInteraction();
        }
    }

    void Movement()
    {
        if (canMove)
        {
            rbody.velocity = inputSpeed.normalized * speed;
        }
    }

    void AnimationHandling()
    {
        if(canMove)
        {
            anmtr.SetFloat("SpeedX", inputSpeed.x);
            anmtr.SetFloat("SpeedY", inputSpeed.y);
            anmtr.SetFloat("LastMovingSpeedX", lastInputSpeed.x);
            anmtr.SetFloat("LastMovingSpeedY", lastInputSpeed.y);
            anmtr.SetBool("IsMoving", inputSpeed.magnitude > 0);
        }
    }

    #region Interactions
    public void Interact()
    {
        if(activeInteractable!=null&&canMove)
        {
            activeInteractable.Interact();
        }
    }
    public void EndInteraction()
    {
        if (activeInteractable != null && !canMove)
        {
            activeInteractable.EndInteraction();
        }
    }
    #endregion


    private void OnTriggerEnter2D(Collider2D _collision)
    {
        if(_collision.CompareTag("Interactable"))
        {
            if(_collision.GetComponentInParent<Interactable>())
            {
                activeInteractable = _collision.GetComponentInParent<Interactable>();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D _collision)
    {
        if (_collision.CompareTag("Interactable"))
        {
            activeInteractable = null;
        }
    }
}
