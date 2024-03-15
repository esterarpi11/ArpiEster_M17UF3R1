using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    new public string name = "";
    public Sprite icon = null;
    public string kind = "";
    public float damage = 0f;
    public float health = 0f;

    public virtual void Use()
    {

    }
}
