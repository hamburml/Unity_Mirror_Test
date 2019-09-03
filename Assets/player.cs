using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class player : NetworkBehaviour
{

    private GameObject cube;

    public override void OnStartServer()
    {
        cube = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        if (isLocalPlayer && Input.GetMouseButton(0))
        {
            CmdRotate();
        }
    }

    [Command]
    public void CmdRotate()
    {
        cube.transform.Rotate(Vector3.up);
    }
}
