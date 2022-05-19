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

    public int fallAmount = 5;

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
        if (Blocks[t].transform.position.y <= BlockHeights[t]-fallAmount/2)
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
            if (BlockFall[i].transform.position.y <= BlockHeights[i + 1]-fallAmount)
            {
                BlockFall[i].transform.position = new Vector3(0,BlockHeights[i+1]-fallAmount,0);
                BlockFall.RemoveAt(i);

            }
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