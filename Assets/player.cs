using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class player : NetworkBehaviour
{

    private cube cube;
    // Start is called before the first frame update
    void Start()
    {
        cube = FindObjectOfType<cube>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            
            cube.CmdRotate();
        }

    }
}
