using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New weapon", menuName = "Inventory/Weapon")]
public class Weapon : ScriptableObject
{
    new public string name = "";
    public float damage = 0f;
    public int price = 0;
    public float speed = 10f;
}
