using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FallIntoPlace : MonoBehaviour
{
    public AudioClip[] Clicks;

    public AudioSource effectPlayer;

    public Transform[] Blocks;

    public float[] BlockHeights;

    private float desiredDuration = 100;

    private Vector3 velocity = Vector3.zero;

    private float elapsedTime = 0;

    public int fallAmount = 10;

    private int t = 1;

    public float objectSpeed;

    public Slider speedSlider;

    public AnimationCurve animCurve;

    private int blockDif = 0;

    void Start()
    {
        Blocks = GetComponentsInChildren<Transform>();
        BlockHeights = new float[Blocks.Length];
        //iterate through every block and log starting Y position to the BlockHeights array
        for (int i = 1; i < Blocks.Length; i++)
        {
            BlockHeights[i] = Blocks[i].transform.position.y;
            Blocks[i].gameObject.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        objectSpeed = speedSlider.value;

        if (Input.GetMouseButton(0) && Input.mousePosition.y > 400)
        {
            MoveBlock(Blocks);
        }

    }


    void MoveBlock(Transform[] Blocks)
    {
        //Transform[] Blocks = GetComponentsInChildren<Transform>();

        float currentPosY = Blocks[t].transform.position.y;

        if (Blocks[t].transform.position.y > BlockHeights[t] - fallAmount)
        {
            Blocks[t].gameObject.SetActive(true);
            
            Blocks[t].Translate(Vector3.back* objectSpeed * Time.deltaTime);
            currentPosY = Blocks[t].transform.position.y;
        }
        else
        {
            Blocks[t].transform.position = new Vector3(Blocks[t].transform.position.x, BlockHeights[t] - fallAmount, Blocks[t].transform.position.z);
            if (t < Blocks.Length - 1)
            {
                
                //If block down then play random sound and set elapsed time back to 0
                RandomSoundness();
                t = t + 1;
                elapsedTime = 0;

            }
        }
    }

    void RandomSoundness()
    {
        effectPlayer.clip = Clicks[Random.Range(0, Clicks.Length)];
        effectPlayer.Play();
    }
}