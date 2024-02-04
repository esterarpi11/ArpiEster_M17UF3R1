using GameInputs;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public static PlayerMovement Instance;
    public MainPlayer player;
    protected Inputs _inputs;
    protected Vector3 moveDirection;
    public Transform orientation;
    protected Rigidbody _rigidBody;
    protected float _movementSpeed;

    protected float horizontalInput;
    protected float verticalInput;

    private void Awake()
    {
        _inputs = new Inputs();
        _inputs.MainPlayer.Enable();

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
        _movementSpeed = player.player.speed;
        _inputs.MainPlayer.Movement.performed += Move_Performed;
        _rigidBody = GetComponent<Rigidbody>();
        _rigidBody.freezeRotation = true;

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical"); ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Move_Performed(InputAction.CallbackContext obj)
    {
        player._animator.SetBool("Running", true);
        MovePlayer();
    }
    private void MovePlayer()
    {
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
        _rigidBody.AddForce(moveDirection.normalized * _movementSpeed  * 10f, ForceMode.Force);
    }
}
