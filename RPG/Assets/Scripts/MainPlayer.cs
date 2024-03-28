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
    public Rigidbody rb;
    public Camera cam;
    public IInteractable focus;
    public MeshFilter itemPlacement;
    public GameObject itemPositon;

    public void setPlayer(float x, float y, float z, float health)
    {
        _transform.position = new Vector3(x, y, z);
        player.health = health;
    }
    private void Awake()
    {
        InputController.Run += RunHandler;
        InputController.Crouch += CrouchHandler;
        InputController.Interact += PickObject;

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
        cam = Camera.main;
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
        //RemoveFocus();
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
    void PickObject()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();
            if (interactable != null)
            {
                SetFocus(interactable);
            }
        }
    }
    public void setWeapon(Item item)
    {
        itemPlacement.mesh = item.mesh;
    }
    void SetFocus(IInteractable newFocus)
    {
        if(newFocus != focus)
        {
            focus = newFocus;
        }
        
        newFocus.isFocus = true;
        newFocus.hasInteracted = false;
    }
    //void RemoveFocus()
    //{
    //    focus.isFocus = false;
    //    focus=null;
    //}
}
