using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    public CubeProperties redCube;
    public CubeProperties blueCube;

    CubeProperties cubeProp;

    int activeCubeProp;

    private void Start()
    {
        activeCubeProp = 1;
        ChangeCubeProperties();
    }

    void Update () {
        GetComponent<Renderer>().material = cubeProp.cubeMaterial;
        transform.Rotate(0, cubeProp.cubeSpeed, 0);
	}

    public void ChangeCubeProperties()
    {
        if (activeCubeProp == 1)
        {
            activeCubeProp = 2;
            cubeProp = redCube;
        }
        else if(activeCubeProp == 2)
        {
            activeCubeProp = 1;
            cubeProp = blueCube;
        }
    }
}
