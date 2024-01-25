using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    new public string name = "";
    public string kind = "";
    public float maxHealth = 0f;
    public int price = 0;
    public float speed = 0f;
    public float coolDown = 0f;
}
