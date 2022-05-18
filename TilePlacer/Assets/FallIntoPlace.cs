using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FallIntoPlace : MonoBehaviour
{
    public AudioClip[] Clicks;

    public AudioSource effectPlayer;

    public Transform[] Blocks;

    List<GameObject> BlockFall = new List<GameObject>();

    public float BlockFallLength;

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
        
        //iterate through every block and log starting Y position to the BlockHeights array
        for (int i = 1; i < Blocks.Length; i++)
        {
            Blocks[i].gameObject.SetActive(false);
        }

        //Setup first cube for falling

        BlockFall.Add(Blocks[1].gameObject);
        BlockFall[0].SetActive(true);     
    }

    // Update is called once per frame
    void Update()
    {
        objectSpeed = speedSlider.value;

        if (Input.GetMouseButton(0) && Input.mousePosition.y > 400)
        {
            GetBlockList();
            MoveBlock();
        }
        else
        {
            MoveBlocksBack();
        }

    }

    private void GetBlockList()
    {
        if (Blocks[t].transform.position.y <= 10)
        {
            BlockFall.Remove(BlockFall[t]);
            t += 1;
            BlockFall.Add(Blocks[t].gameObject);
            BlockFall[t-1].SetActive(true);
        }
    }

    private void MoveBlock()
    {
        for (int i = 0; i < BlockFall.Count; i++)
        {
            /*
             idk figure this out basically add like options for 
             
             if(BlockFall[i].transform.position.y <= fallAmount) {
                BlockFall[i].transform.position
            }
             */
            BlockFall[i].transform.Translate(30 * Time.deltaTime * Vector3.back);
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