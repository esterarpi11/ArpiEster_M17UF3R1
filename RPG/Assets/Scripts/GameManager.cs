using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using TreeEditor;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    protected float idleFov = 32;
    protected float walkingFov = 40;
    protected float aimingFov = 12;
    protected float aimingSide = 0.8f;
    protected float idleSide = 0.5f;

    public Cinemachine.CinemachineVirtualCamera camera;

    //Clases to get the data stored in the json
    [Serializable]
    public class Inventory
    {
        public Item[] items;

        public Inventory(Item[] items)
        {
            this.items = items;
        }
    }

    [Serializable]
    public class Item
    {
        public string name;

        public Item(string name)
        {
            this.name = name;
        }
    }

    [Serializable]
    public class PlayerStats
    {
        public float positionX;
        public float positionY;
        public float positionZ;
        public Inventory inventory;

        public PlayerStats(float positionX, float positionY, float positionZ, Inventory inventory)
        {
            this.positionX = positionX;
            this.positionY = positionY;
            this.positionZ = positionZ;
            this.inventory = inventory;
        }
    }


    private void Awake()
    {
        //Read the json file to get all the player data that is stored
        StreamReader sr = File.OpenText("./Assets/Scripts/Data.json");
        string content = sr.ReadToEnd();
        sr.Close();
        Debug.Log(content);
        //List<PlayerStats> player = JsonConvert.DeserializeObject<List<PlayerStats>>(content);
        //foreach(PlayerStats item in player)
        //{
        //    Debug.Log(item);
        //}
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
    public void cameraController(string type)
    {
        switch (type)
        {
            case "idle":
                camera.m_Lens.FieldOfView = idleFov;
                break;
            case "walk":
                camera.m_Lens.FieldOfView = walkingFov;
                break;
            case "aim":
                camera.m_Lens.FieldOfView = aimingFov;
                break;
        }
    }
}
