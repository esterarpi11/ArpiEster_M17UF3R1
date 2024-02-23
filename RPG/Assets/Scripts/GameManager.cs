using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    protected float idleFov = 32;
    protected float walkingFov = 40;
    protected float aimingFov = 12;
    protected float aimingSide = 0.8f;
    protected float idleSide = 0.5f;

    public Cinemachine.CinemachineVirtualCamera camera;

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
    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void chooseScene(int n)
    {
        if ( n == -1 ) Application.Quit();
        else SceneManager.LoadScene(n);
    }
    public void cameraController()
    {

    }
}
