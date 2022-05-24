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

    List<GameObject> BlockFall = new List<GameObject>();

    public float BlockFallLength;


    private Vector3 velocity = Vector3.zero;

    private float elapsedTime = 0;

    public int fallAmount = 6;

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
            BlockHeights[i] = Blocks[i].transform.localPosition.y;
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
            //GetBlockList();
            MoveBlock();
        }
        else
        {
            MoveBlocksBack();
        }

    }

    private void GetBlockList()
    {
        if (BlockFall[t-1].transform.position.y <= BlockHeights[t]-(fallAmount/2))
        {       
            t += 1;
            BlockFall.Add(Blocks[t].gameObject);
            BlockFall[t-1].SetActive(true);
            Debug.Log("Below");
        }
    }

    private void MoveBlock()
    {
        for (int i = 0; i < BlockFall.Count; i++)
        {
            BlockFall[i].transform.Translate(5 * Time.deltaTime * Vector3.back);
            if (BlockFall[i].transform.localPosition.y <= BlockHeights[i + 1]-fallAmount)
            {
                BlockFall[i].transform.localPosition = new Vector3(BlockFall[i].transform.localPosition.x,BlockHeights[i+1]-fallAmount, BlockFall[i].transform.localPosition.z);
                BlockFall.RemoveAt(i);

            }
            
        }

        
        if(BlockFall[BlockFall.Count-1].transform.localPosition.y <= BlockHeights[BlockFall.Count-1]-(fallAmount/2))
        {
            BlockFall.Add(Blocks[BlockFall.Count].gameObject);
            BlockFall[BlockFall.Count-1].SetActive(true);
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