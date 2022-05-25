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

    List<GameObject> BlockFall = new List<GameObject>();

    public List<Transform> Blocks;
    
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

        BlockFall.Add(Blocks[0].gameObject);
        BlockFall[0].SetActive(true);

        Debug.Log(BlockHeights[2]);
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

        
        if(BlockFall[BlockFall.Count-1].transform.localPosition.y <= BlockHeights[BlockFall.Count]-(fallAmount/2))
        {
            //issue somewhere here idk where b/c it probably just keeps adding Blocks[2] instead of the next one
            BlockFall.Add(Blocks[BlockFall.Count-1].gameObject);
            BlockFall[BlockFall.Count-1].SetActive(true);
            for(int i = 0; i < BlockFall.Count; i++)
            {
                Debug.Log(BlockFall[i]);
            }
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