using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockColor : MonoBehaviour
{
    public Color blockColor;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = blockColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
