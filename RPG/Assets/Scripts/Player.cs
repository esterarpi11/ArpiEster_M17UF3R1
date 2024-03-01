using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class MainPlayer : MonoBehaviour
{
    public static MainPlayer Instance;
    public Character player;
    public float currentSpeed;
    public Transform _transform;
    private Quaternion currentRotation;
    public Rigidbody rb;
    public Cinemachine.CinemachineVirtualCamera playerCamera;

    private void Awake()
    {
        InputController.Run += RunHandler;
        InputController.Crouch += CrouchHandler;

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
        currentSpeed = player.speed;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void HandleRotation(Vector2 direction)
    {
        _transform.Rotate(new Vector3(0, direction.x * 30, 0));
    }
    public void HandleMovement(Vector2 direction)
    {
        Vector3 smt = _transform.TransformVector(Vector3.right * direction.x * currentSpeed) + _transform.TransformVector(Vector3.forward * direction.y * currentSpeed);
        rb.velocity = smt;
    }
    void RunHandler()
    {
        if (currentSpeed == player.speed) currentSpeed = player.speed + 2;
        else currentSpeed = player.speed;
    }
    void CrouchHandler()
    {
        if (currentSpeed == player.speed) currentSpeed = player.speed - 2;
        else currentSpeed = player.speed;
    }
}
