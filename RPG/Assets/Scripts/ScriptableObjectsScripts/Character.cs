using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New character", menuName = "World/Character")]
public class Character : ScriptableObject
{
    new public string name = "";
    public float health = 0f;
    public float maxHealth = 0f;
    public float speed = 0f;
    public float coolDown = 0f;
    public bool isDead = false;
    public bool isRunning = false;
}
