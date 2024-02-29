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
        //_transform.Rotate(Vector3.up, direction.x * currentSpeed * Time.deltaTime);

        //float rotationX = Mathf.Clamp(direction.y * currentSpeed, -45f, 45f);
        //playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
        //_transform.rotation *= Quaternion.Euler(0, direction.x * currentSpeed, 0);

        _transform.Rotate(new Vector3(0, direction.x * currentSpeed, 0));

        //if ((direction.x > 0.1 || direction.x < -0.1) || (direction.y > 0.1 || direction.y < 0.1))
        //{
        //    currentRotation = Quaternion.LookRotation(new Vector3(direction.x, 0f, direction.y));
        //    transform.rotation = currentRotation;
        //}
        //else transform.rotation = currentRotation;

        //Vector3 currentPosition = _transform.position;
        //Vector3 newPosition = new Vector3(direction.x, 0, direction.y);
        //Vector3 positionToLookAt = currentPosition + newPosition;
        //_transform.LookAt(positionToLookAt);
    }
    public void HandleMovement(Vector2 direction)
    {
        //_transform.Translate(new Vector3(direction.x, 0f, direction.y) * currentSpeed * Time.deltaTime);
        rb.velocity = new Vector3(direction.x, 0f, direction.y) * currentSpeed;
        //rb.velocity = transform.position.z * direction.y * currentSpeed;
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
