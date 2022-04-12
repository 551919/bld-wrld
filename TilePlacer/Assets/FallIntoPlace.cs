using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallIntoPlace : MonoBehaviour
{
    public AudioClip[] Clicks;

    public AudioSource effectPlayer;

    public Transform[] Blocks;

    public float[] BlockHeights;

    private float desiredDuration = 100;

    private Vector3 velocity = Vector3.zero;

    private float elapsedTime = 0;

    private bool completed = false;

    public int fallAmount = 30;

    private int t = 1;

    public float objectSpeed;

    public AnimationCurve animCurve;

    public Color[] sceneColors;

    private int blockDif = 0;

    void Start()
    {
        Blocks = GetComponentsInChildren<Transform>();
        BlockHeights = new float[Blocks.Length];
        //iterate through every block and log starting Y position to the BlockHeights array
        for (int i = 1; i < Blocks.Length; i++)
        {
            BlockHeights[i] = Blocks[i].transform.position.y;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && Input.mousePosition.y > 400)
        {
            MoveBlock();
        }

        if(blockDif < Blocks.Length)
        {
            for (int i = 1; i < Blocks.Length; i++)
            {
                Debug.Log(blockDif);
                for (int c = 0; c < sceneColors.Length; c++)
                {
                    if (Blocks[i].GetComponent<MeshRenderer>().material.color != sceneColors[c])
                    {
                        blockDif += 1;
                    }
                }
            }
        }
        else
        {
            Debug.Log("Color Finished");
        }
    }


    void MoveBlock()
    {
        Transform[] Blocks = GetComponentsInChildren<Transform>();

        if (Blocks[t].transform.position.y > BlockHeights[t] - fallAmount)
        {
            elapsedTime += Time.deltaTime;
            Blocks[t].transform.position = Vector3.Lerp(Blocks[t].transform.position, Blocks[t].transform.position - new Vector3(0, fallAmount, 0),  animCurve.Evaluate(elapsedTime/objectSpeed));
            
        }
        else
        {
            //if all blocks placed down, do popup-for color (or somethign)
            RandomSoundness();
            Blocks[t].transform.position = new Vector3(Blocks[t].transform.position.x, BlockHeights[t] - fallAmount, Blocks[t].transform.position.z);
            t = t + 1;
            elapsedTime = 0;
        }
    }

    void RandomSoundness()
    {
        effectPlayer.clip = Clicks[Random.Range(0, Clicks.Length)];
        effectPlayer.Play();
    }
}