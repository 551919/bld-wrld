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
        
    }

    // Update is called once per frame
    void Update()
    {
        objectSpeed = speedSlider.value;

        if (Input.GetMouseButton(0) && Input.mousePosition.y > 400)
        {
            MoveBlock(Blocks);
        }
        else
        {
            moveBlocksBack();
        }

    }


    void MoveBlock(Transform[] Blocks)
    {
        for (int t = 0; t < Blocks.Length; t++)
        {
            if (Blocks[t].gameObject.activeInHierarchy == false || Blocks[t].transform.position.y > Blocks[t].transform.position.y - fallAmount / 2)
            {
                Debug.Log("added block");
                BlockFall.Add(Blocks[t].gameObject);
                BlockFall[t].gameObject.SetActive(true);
                Blocks[t].gameObject.SetActive(true);
                break;
            }
        }

        for (int a = 0; a < BlockFall.Count; a++)
        {
            Debug.Log("moved block");
            BlockFall[a].transform.Translate(Vector3.back * 2 * Time.deltaTime);
        }

        Debug.Log("broken");
        
    }

    void RandomSoundness()
    {
        effectPlayer.clip = Clicks[Random.Range(0, Clicks.Length)];
        effectPlayer.Play();
    }

    void DropSingleBlock(GameObject blockGameObj)
    {
        for (float k = 0; k < 10; k += 1)
        {
            Blocks[t].Translate(Vector3.back * 2 * Time.deltaTime);
        }
    }

    void moveBlocksBack()
    {

    }
}