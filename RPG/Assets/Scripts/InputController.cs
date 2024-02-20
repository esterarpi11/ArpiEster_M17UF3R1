using GameInputs;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    public static InputController Instance;
    protected Inputs _inputs;

    public static event Action Crouch = delegate { };
    public static event Action Walk = delegate { };
    public static event Action Run = delegate { };

    protected Vector2 currentDirection;

    private void Awake()
    {
        _inputs = new Inputs();
        _inputs.MainPlayer.Movement.performed += ctx =>
        {
            Walk.Invoke();
        }; 
        _inputs.MainPlayer.Run.performed += ctx =>
        {            
            Run.Invoke();
        };
        _inputs.MainPlayer.Crouch.performed += ctx =>
        {           
            Crouch.Invoke();
        };

        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else Destroy(this.gameObject);
    }
    private void OnEnable()
    {
        _inputs.MainPlayer.Enable();
    }
    private void OnDisable()
    {
        _inputs.MainPlayer.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {

    }
    
}
