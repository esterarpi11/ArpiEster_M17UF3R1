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
    public class PlayerPosition
    {
        public float positionX;
        public float positionY;
        public float positionZ;

        public PlayerPosition(float positionX, float positionY, float positionZ)
        {
            this.positionX = positionX;
            this.positionY = positionY;
            this.positionZ = positionZ;
        }
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

    PlayerPosition player;
    PlayerInventory inventory;

    private void Awake()
    {
        try
        {
            //First I read the position file
            StreamReader sr = File.OpenText("./Assets/Scripts/PositionData.txt");
            string content = sr.ReadToEnd();
            sr.Close();
            string[] positionSplitted = content.Split(';');
            float[] position = new float[3];

            for (int i = 0; i < positionSplitted.Length; i++)
            {
                position[i] = float.Parse(positionSplitted[i].Split('=')[1]);
            }

            player = new PlayerPosition(position[0], position[1], position[2]);

            //After that I do the same with the items file
            sr = File.OpenText("./Assets/Scripts/InventoryData.txt");
            content = sr.ReadToEnd();
            sr.Close();
            string[] inventorySplitted = content.Split(';');
            List<string> inventoryList = new List<string>();

            for (int i = 0; i < inventorySplitted.Length; i++)
            {
                inventoryList.Add(inventorySplitted[i].Split('=')[1]);
            }

            string[] items = new string[inventoryList.Count];
            int n = 0;

            foreach (string item in inventoryList)
            {
                items[n] = item;
                n++;
            }
            inventory = new PlayerInventory(items);
        }
        catch (Exception ex)
        {
            Debug.LogException(ex);
        }
    }
    public void saveData()
    {

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
