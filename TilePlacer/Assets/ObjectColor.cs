using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectColor : MonoBehaviour
{
    //variables for different types of colors

    public Color[] sceneColors;

    //Arrays for the respective tagged objects

    private GameObject[] color1;

    // Start is called before the first frame update
    void Start()
    {
        //Assigns all objects tagged to their respective color
        clayCubes = GameObject.FindGameObjectsWithTag("clay");
        woodCubes = GameObject.FindGameObjectsWithTag("wood");
        brickCubes = GameObject.FindGameObjectsWithTag("brick");

        foreach (GameObject cube in clayCubes)
        {
            var cubeRenderer = cube.GetComponent<Renderer>();
            cubeRenderer.material.SetColor("_Color", clayColor);
        }

        foreach (GameObject cube in woodCubes)
        {
            var cubeRenderer = cube.GetComponent<Renderer>();
            cubeRenderer.material.SetColor("_Color", woodColor);
        }

        foreach (GameObject cube in brickCubes)
        {
            var cubeRenderer = cube.GetComponent<Renderer>();
            cubeRenderer.material.SetColor("_Color", brickColor);
        }

        /*
        foreach (GameObject cube in clayCubes)
        {
            var cubeRenderer = cube.GetComponent<Renderer>();
            cubeRenderer.material.SetColor("_Color", clayColor);
        }
        */


    }
}
