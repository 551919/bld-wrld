using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class FallIntoPlace : MonoBehaviour
{
    public AudioClip[] Clicks;

    public AudioSource effectPlayer;

    public float[] BlockHeights;

    public List<Transform> Blocks;
    
    public float BlockFallLength;

    private Vector3 velocity = Vector3.zero;

    private float elapsedTime = 0;

    private int fallAmount = 6;

    private int t = 1;

    public float objectSpeed;

    public Slider speedSlider;

    public AnimationCurve animCurve;

    private int blockDif = 0;

    private int BlocksActivated = 0;

    void Start()
    {

        //Linq Method to remove Parent from the List

        Blocks.AddRange(GetComponentsInChildren<Transform>().Where(x => x != this.transform));
        BlockHeights = new float[Blocks.Count];

        //iterate through every block and log starting Y position to the BlockHeights array
        for (int i = 0; i < Blocks.Count; i++)
        {
            BlockHeights[i] = Blocks[i].transform.localPosition.y;
            Blocks[i].gameObject.SetActive(false);
        }

        //Setup first cube for falling

        Blocks[0].gameObject.SetActive(true);

        BlocksActivated += 1;


    }

    // Update is called once per frame
    void Update()
    {
        objectSpeed = speedSlider.value;

        MoveBlock();

    }

    private void MoveBlock()
    {
        /* IMPORTANT IMPORTANT
         * 
         * 
         * YOU ONLY NEED TO CHECK IF BLOCK 0 IS AT THE NEEDED Y VALUE AND YOU CAN REMOVE IT FROM THE LIST
         */

        if (Input.GetMouseButton(0) && Input.mousePosition.y > 400)
        {
            for (int i = 0; i < BlocksActivated; i++)
            {
                Blocks[i].transform.Translate(5 * Time.deltaTime * Vector3.back);
                if (Blocks[i].transform.localPosition.y <= BlockHeights[i] - fallAmount /*should be 14*/)
                {
                    Blocks[i].transform.localPosition = new Vector3(Blocks[i].transform.localPosition.x, BlockHeights[i] - fallAmount, Blocks[i].transform.localPosition.z);
                    Blocks.RemoveAt(0);

                }

            }
        }

        
        if(Blocks[BlocksActivated-1].transform.localPosition.y <= BlockHeights[BlocksActivated-1]-(fallAmount/2))
        {
            //issue somewhere here idk where b/c it probably just keeps adding Blocks[2] instead of the next one
            BlocksActivated += 1;
            Debug.Log(BlocksActivated);
            Blocks[BlocksActivated-1].gameObject.SetActive(true);
            //t += 1;
            Debug.Log("troll");
        }
        
    }

    private void RandomSoundness()
    {
        effectPlayer.clip = Clicks[Random.Range(0, Clicks.Length)];
        effectPlayer.Play();
    }

    private void MoveBlocksBack()
    {

    }
}