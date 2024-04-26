using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Component2 : MonoBehaviour
{

    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Component1.myObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
