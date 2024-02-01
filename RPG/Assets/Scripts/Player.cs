using System.Collections;
using System.Collections.Generic;
using GameInputs;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class MainPlayer : MonoBehaviour
{
    protected Character player;
    protected Inputs _inputs;
    protected Rigidbody _rigidBody;
    protected Animator _animator;

    private void Awake()
    {
        _inputs = new Inputs();
        _inputs.MainPlayer.Enable();
        _rigidBody = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        _inputs.MainPlayer.Movement.performed += Move_Performed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Move_Performed(InputAction.CallbackContext obj)
    {
        _animator.SetBool("running", true);
        _rigidBody.velocity = obj.ReadValue<Vector2>() * player.speed;
    }
}
