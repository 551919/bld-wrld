using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class FallIntoPlace : MonoBehaviour
{
    public AudioClip[] Clicks;

    public AudioSource effectPlayer;

    public List<Transform> Blocks;

    private int fallAmount = 6;

    public float objectSpeed;

    public Slider speedSlider;

    private int BlocksActivated = 0;

    private float initialHeight = 0;

    private float initialHeightFirst = 0;

    void Start()
    {

        //Linq Method to remove Parent from the List

        Blocks.AddRange(GetComponentsInChildren<Transform>().Where(x => x != this.transform));

        //iterate through every block and log starting Y position to the BlockHeights array
        for (int i = 0; i < Blocks.Count; i++)
        {
            Blocks[i].gameObject.SetActive(false);
        }

        //Setup first cube for falling

        Blocks[0].gameObject.SetActive(true);
        BlocksActivated += 1;
        
        initialHeight = Blocks[0].transform.localPosition.y;
        initialHeightFirst = Blocks[BlocksActivated - 1].transform.localPosition.y;

    }

    // Update is called once per frame
    void Update()
    {
        objectSpeed = speedSlider.value;

        if (Input.GetMouseButton(0) && Input.mousePosition.y > 400)
        {
            MoveBlockDown();
            CheckBlocks();
        }
    }

    private void MoveBlockDown()
    {
        for (int i = 0; i < BlocksActivated; i++)
        {
            Blocks[i].transform.Translate(5 * Time.deltaTime * Vector3.back);
        }
    }

    private void CheckBlocks()
    {
        //check if Last block (actually [0]) is at or below its desired point, then remove it and use new block
        if(Blocks[0].transform.localPosition.y <= initialHeight - fallAmount)
        {
            Blocks[0].transform.localPosition = new Vector3(Blocks[0].transform.localPosition.x, initialHeight - fallAmount, Blocks[0].transform.localPosition.z);
            Blocks.RemoveAt(0);
            BlocksActivated -= 1;
            initialHeight = Blocks[0].transform.localPosition.y + (fallAmount/2);
            
        }

        //Check if first block is below halfway point of fallAmount
        if(Blocks[BlocksActivated-1].transform.localPosition.y <= initialHeightFirst - fallAmount / 2)
        {
            Debug.Log(Blocks[BlocksActivated-1].transform.localPosition.y);
            BlocksActivated += 1;
            Blocks[BlocksActivated - 1].gameObject.SetActive(true);
            initialHeightFirst = Blocks[BlocksActivated - 1].transform.localPosition.y;
        }
    }


    private void RandomSoundness()
    {
        effectPlayer.clip = Clicks[Random.Range(0, Clicks.Length)];
        effectPlayer.Play();
    }
}