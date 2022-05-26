using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;


/*
 * ISSUES TO SOLVE:
 * Fix the Blocks being slightly off place when the object fall speed is higher than ~ 10 
 * Issue: the place the block is at isn't exact so it keeps being lower, so set the block that is 1/2 down exactly to being 1/2 at the center
 * 
 * 
 * THINGS TO ADD:
 * Add the option to add variable that states when the next block appears
 * 
 */
public class FallIntoPlace : MonoBehaviour
{
    //Audio Variables for playing audio that plays when Blocks fall into place
    public AudioClip[] Clicks;

    public AudioSource effectPlayer;

    //Most important part of script probably, the list of Blocks taken from the parent object
    public List<Transform> Blocks;

    //Height that the Blocks should fall
    public int fallAmount = 6;

    //(DEBUG ONLY) Slider that controls object fall speed, obsolete now as the falling has been reworked
    public float objectSpeed;

    public Slider speedSlider;

    //Variables For Iterating
    private int BlocksActivated = 0;

    private float initialHeight = 0;

    private float initialHeightFirst = 0;

    void Start()
    {

        //Linq Method to remove Parent from the List

        Blocks.AddRange(GetComponentsInChildren<Transform>().Where(x => x != this.transform));

        //Iterate through every Block and remove from List
        for (int i = 0; i < Blocks.Count; i++)
        {
            Blocks[i].gameObject.SetActive(false);
        }

        //Setup First Cube

        Blocks[0].gameObject.SetActive(true);
        BlocksActivated += 1;
        
        //Setup Initial Heights for first and last Block (should be same var for the first block)
        initialHeight = Blocks[0].transform.localPosition.y;
        initialHeightFirst = Blocks[BlocksActivated - 1].transform.localPosition.y;

    }

    // Update Loop, pretty self-explanatory
    void Update()
    {
        //Set objectSpeed (speed at which blocks fall) from the slider in level
        objectSpeed = speedSlider.value;

        //If mouse is down and above cetain y value so it doesn't interfere with the "Colors" button in GUI
        if (Input.GetMouseButton(0) && Input.mousePosition.y > 400)
        {
            //Separate functions for moving the block list and then checking the first and last blocks for positions
            MoveBlockDown();
            CheckBlocks();
        }
    }

    //The function that constantly moves every activated block down
    private void MoveBlockDown()
    {
        for (int i = 0; i < BlocksActivated; i++)
        {
            //Moves the blocks downwards based on the objectSpeed variable (set by the slider for now)
            Blocks[i].transform.Translate(objectSpeed * Time.deltaTime * Vector3.back);
        }
    }

    private void CheckBlocks()
    {
        //check if Last block (actually [0]) has fallen the fallAmount amount
        if(Blocks[0].transform.localPosition.y <= initialHeight - fallAmount)
        {
            //Fix position of the block to the desired final position
            Blocks[0].transform.localPosition = new Vector3(Blocks[0].transform.localPosition.x, initialHeight - fallAmount, Blocks[0].transform.localPosition.z);
            //Remove the Block from the List
            Blocks.RemoveAt(0);
            //THIS IS IMPORTANT!!! The line above removes the first block from the list which messes up BlocksActivated so we remove 1 to compensate
            BlocksActivated -= 1;
            //Set the inital height of the lowest block (should be fallamount/2 already down), so add fallamount/2 to compensate and find starting y position
            initialHeight = Blocks[0].transform.localPosition.y + (fallAmount/2);
            
        }

        //Check if first block is below halfway point of fallAmount
        if(Blocks[BlocksActivated-1].transform.localPosition.y <= initialHeightFirst - fallAmount / 2)
        {
            //Change BlockVar to next Block and then activate that block
            BlocksActivated += 1;
            Blocks[BlocksActivated - 1].gameObject.SetActive(true);
            //Set the initialHeightFirst variable (height of highest/first block in the list) to the initial height of the first block
            initialHeightFirst = Blocks[BlocksActivated - 1].transform.localPosition.y;
        }
    }

    //Function that plays a single random sound when called based on the public list of sounds (player is the effectPlayer)
    private void RandomSoundness()
    {
        effectPlayer.clip = Clicks[Random.Range(0, Clicks.Length)];
        effectPlayer.Play();
    }
}