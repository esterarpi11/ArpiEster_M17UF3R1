using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using TreeEditor;
using System.Linq;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Animator _animator;

    protected float idleFov = 32;
    protected float walkingFov = 40;
    protected float aimingFov = 12;
    protected float aimingSide = 0.8f;
    protected float idleSide = 0.5f;

    public int objectsToBeFound = 3;

    public Cinemachine.CinemachineVirtualCamera mainCamera;
    public Cinemachine.CinemachineVirtualCamera miniMapCamera;

    public GameObject _mainCamera;
    public GameObject _miniMapCamera;

    //Clases to get the data stored in the json
    [Serializable]
    public class World
    {
        public PlayerData _playerData;
        public EnemyData[] _enemyData;
    }
    [Serializable]
    public class PlayerData
    {
        public float positionX;
        public float positionY;
        public float positionZ;
        public float health;
        public float PlayerInventory;
    }
    [Serializable]
    public class PlayerInventory
    {
        public string[] items;

        public PlayerInventory(string[] items)
        {
            this.items = items;
        }
    }
    [Serializable]
    public class EnemyData
    {
        public string name;
        public float positionX;
        public float positionY;
        public float positionZ;
        public float health;
    }

    World _world;

    private void Awake()
    {
        try
        {
            //Read the json file
            StreamReader sr = File.OpenText("./Assets/Scripts/Data.json");
            string content = sr.ReadToEnd();
            sr.Close();
            _world = JsonUtility.FromJson<World>(content);
        }
        catch (Exception ex)
        {
            Debug.LogException(ex);
        }
    }
    public void saveData()
    {
        //Update player data at this time
        _world._playerData.positionX=MainPlayer.Instance.transform.position.x;
        _world._playerData.positionY=MainPlayer.Instance.transform.position.y;
        _world._playerData.positionZ=MainPlayer.Instance.transform.position.z;
        _world._playerData.health = MainPlayer.Instance.player.health;

        try
        {
            StreamWriter sw = new StreamWriter("./Assets/Scripts/Data.json");
            string json = JsonUtility.ToJson(_world);
            sw.WriteLine(json);
        } catch (Exception ex)
        {
            Debug.LogException(ex);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //Singeton to make sure that we don't duplicate the gamemanager
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else Destroy(gameObject);

        InputController.MiniMap += miniMap;
    }

    // Update is called once per frame
    void Update()
    {
        //Checks whether the player has found all 3 objects
        if (objectsToBeFound == 0) _animator.SetBool("isDancing", true);
    }
    public void miniMap()
    {
        _miniMapCamera.SetActive(!_miniMapCamera.activeSelf);
    }

    //Basic controller for the menus
    public void chooseScene(int n)
    {
        if ( n == -1 ) Application.Quit();
        else SceneManager.LoadScene(n);
    }

    //Camera controller to set the first or third person camera
    public void cameraController(string type)
    {
        switch (type)
        {
            case "idle":
                mainCamera.m_Lens.FieldOfView = idleFov;
                break;
            case "walk":
                mainCamera.m_Lens.FieldOfView = walkingFov;
                break;
            case "aim":
                mainCamera.m_Lens.FieldOfView = aimingFov;
                break;
        }
    }
}
