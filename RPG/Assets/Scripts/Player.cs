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
    public Transform _transformLookAt;
    private Quaternion currentRotation;
    public Rigidbody rb;

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
        if ((direction.x > 0.1 || direction.x < -0.1) || (direction.y > 0.1 || direction.y < 0.1))
        {
            currentRotation = Quaternion.LookRotation(new Vector3(direction.x, 0f, direction.y));
            transform.rotation = currentRotation;
        }
        else transform.rotation = currentRotation;
        //Vector3 currentPosition = _transform.position;
        //Vector3 newPosition = new Vector3(direction.x, 0, direction.y);
        //Vector3 positionToLookAt = currentPosition + newPosition;
        //_transform.LookAt(positionToLookAt);
    }
    public void HandleMovement(Vector2 direction)
    {
        rb.velocity = new Vector3(direction.x, 0f, direction.y) * currentSpeed;
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
