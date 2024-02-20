using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class MainPlayer : MonoBehaviour
{
    public static MainPlayer Instance;
    public Character player;
    protected float currentSpeed = 5f;
    public Transform _transform;

    private void Awake()
    {
        InputController.Run += RunHandler;
        InputController.Walk += MoveHandler;
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MoveHandler()
    {
        _transform.Translate(new Vector3(1f, 0.0f, 0f) * currentSpeed * Time.deltaTime);
    }
    void RunHandler()
    {
        if (currentSpeed == player.speed) currentSpeed += 5;
        else currentSpeed = player.speed;
    }
}
