using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Component3 : MonoBehaviour
{

    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        Component1.myObject.name = "NewName";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
