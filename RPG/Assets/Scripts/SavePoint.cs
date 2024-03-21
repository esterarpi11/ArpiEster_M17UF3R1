using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePoint : Interactable
{
    public override void Interact()
    {
        GameManager.Instance.saveData();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
