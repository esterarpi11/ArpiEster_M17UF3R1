using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallBack;
    public int space = 6;
    public List<Item> items = new List<Item>();
    private void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else Destroy(gameObject);
    }

    public bool Add(Item item)
    {
        if(items.Count < space)
        {
            items.Add(item);
            if(onItemChangedCallBack != null) onItemChangedCallBack.Invoke();
            return true;
        }
        return false;
    }
    public void Remove(Item item)
    {
        items.Remove(item);
    }
}
