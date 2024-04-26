using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    int x;

    private void Awake()
    {
        x = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Inicializando contador en " + x);

    }

    // Update is called once per frame
    void Update()
    {
        x++; 
        if(x > 100)
        {
            Debug.LogWarning("La variable está por encima de 100");
        }
    }

    private void OnDisable()
    {
        Debug.LogError("El objeto de este script no debería ser deshabilitado");
    }
}
