using GameInputs;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public static PlayerMovement Instance;

    public Animator animator;
    protected Inputs _inputs;

    protected Vector3 moveDirection;

    int isWalkingHash;
    int isRunningHash;

    Vector2 currentMovement;
    bool movementPressed;
    bool runPressed;

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
            runPressed = true;
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
    }
    void Update()
    {
        handleMovement();
        Debug.Log(runPressed);

    }
    void handleMovement()
    {
        bool isWalking = animator.GetBool(isWalkingHash);
        bool isRunning = animator.GetBool(isRunningHash);

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
    }
}
