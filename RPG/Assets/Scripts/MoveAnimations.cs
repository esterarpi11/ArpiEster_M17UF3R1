using GameInputs;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveAnimations : MonoBehaviour
{
    public static MoveAnimations Instance;

    public Animator animator;
    protected Inputs _inputs;

    protected Vector3 moveDirection;

    int isWalkingHash;
    int isRunningHash;
    int isCrouchingHash;
    int isCrouchingAndMovingHash;

    Vector2 currentMovement;
    bool movementPressed;
    bool runPressed;
    bool crouchPressed;

    private void Awake()
    {
        _inputs = new Inputs();
        _inputs.MainPlayer.Enable();
        _inputs.MainPlayer.Movement.performed += ctx =>
        {
            currentMovement = ctx.ReadValue<Vector2>();
            movementPressed = currentMovement.x != 0 || currentMovement.y != 0;
        }; 
        _inputs.MainPlayer.Run.performed += ctx =>
        {
            runPressed = !runPressed;
        };
        _inputs.MainPlayer.Crouch.performed += ctx =>
        {
            crouchPressed = !crouchPressed;
        };

        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else Destroy(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
        isCrouchingHash = Animator.StringToHash("isCrouching");
        isCrouchingAndMovingHash = Animator.StringToHash("isCrouchingAndMoving");
    }
    void Update()
    {
        handleMovement();
    }
    void handleMovement()
    {
        bool isWalking = animator.GetBool(isWalkingHash);
        bool isRunning = animator.GetBool(isRunningHash);
        bool isCrouching = animator.GetBool(isCrouchingHash);

        if (movementPressed && !isWalking)
        {
            animator.SetBool(isWalkingHash, true);
        }
        if (!movementPressed && isWalking)
        {
            animator.SetBool(isWalkingHash, false);
        }
        if(movementPressed && runPressed && !isRunning)
        {
            animator.SetBool(isRunningHash, true);
        }
        if ((!movementPressed || !runPressed) && isRunning)
        {
            animator.SetBool(isRunningHash, false);
        }

        if (crouchPressed && !isCrouching)
        {
            animator.SetBool(isCrouchingHash, true);
        }
        if (!crouchPressed && isCrouching)
        {
            animator.SetBool(isCrouchingHash, false);
        }
        if (movementPressed && isCrouching)
        {
            animator.SetBool(isCrouchingAndMovingHash, true);
        }
        if ((!movementPressed || !crouchPressed) && isCrouching)
        {
            animator.SetBool(isCrouchingAndMovingHash, false);
        }
    }
}
