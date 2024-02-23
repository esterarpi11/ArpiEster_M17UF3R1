using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    protected float idleFov = 32;
    protected float walkingFov = 40;
    protected float aimingFov = 12;
    protected float aimingSide = 0.8f;
    protected float idleSide = 0.5f;

    protected Cinemachine.CinemachineVirtualCamera camera;
    public Cinemachine.CinemachineVirtualCamera camera2;

    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Cinemachine.CinemachineVirtualCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void idle()
    {
        camera.m_Lens.FieldOfView = idleFov;
        //camera.Body.CameraSide = idleSide;
    }
    public void walk()
    {
        camera.m_Lens.FieldOfView = walkingFov;
        //camera.Body.CameraSide = idleSide;
    }
    public void aim()
    {
        camera.m_Lens.FieldOfView = aimingFov;
        //camera.Body.CameraSide = aimingSide;
    }
}
