using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class UIColor : MonoBehaviour
{
    public Button colorButton;

    public Button backButton;

    public Button settingsButton;
    
    public Button selectButton;

    public Button cancelButton;

    public Button finishButton;

    //finish menu buttons
    public Button nextLvlButton;

    public Button restartLvlButton;

    public Button menuLvlButton;


    public GameObject colorButtonParent;

    public GameObject backButtonParent;

    public GameObject settingsButtonParent;

    public GameObject selectButtonParent;

    public GameObject cancelButtonParent;

    public GameObject rgbSelect;

    public GameObject SettingsMenuParent;

    public GameObject finishButtonParent;

    public GameObject finishMenuParent;

    public Slider effectSlider;

    public Slider musicSlider;

    public AudioMixer masterMixer;

    public FlexibleColorPicker fcp;

    public GameObject cubeParent;

    public int lvlColors;
    
    public ParticleSystem confetti;

    private bool colorsSelected = false;

    private GameObject[] objs;

    private int colorsChanged;

    private bool completed;

    public SceneReference nextScene;

    public CameraShake cameraShake;

    

    // Start is called before the first frame update
    void Start()
    {
        //hide RGB and select and cancel buttons on start
        rgbSelect.SetActive(false);
        selectButtonParent.SetActive(false);
        cancelButtonParent.SetActive(false);
        SettingsMenuParent.SetActive(false);
        finishButtonParent.SetActive(false);
        finishMenuParent.SetActive(false);


        colorButton.onClick.AddListener(colorButtonClick);
        settingsButton.onClick.AddListener(settingsButtonClick);
        backButton.onClick.AddListener(backButtonClick);
        selectButton.onClick.AddListener(selectButtonClick);
        cancelButton.onClick.AddListener(cancelButtonClick);
        finishButton.onClick.AddListener(finishButtonClick);

        //Finish Menu buttons Onclick
        nextLvlButton.onClick.AddListener(nextLvlButtonClick);
        restartLvlButton.onClick.AddListener(restartLvlButtonClick);
        menuLvlButton.onClick.AddListener(menuLvlButtonClick);

    }

    // Update is called once per frame
    void Update()
    {
        masterMixer.SetFloat("Sound", Mathf.Log10(effectSlider.value) * 20);

        masterMixer.SetFloat("Music", Mathf.Log10(musicSlider.value) * 20);

        if(Input.GetMouseButton(0) && colorsSelected == true)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                objs = GameObject.FindGameObjectsWithTag(hit.transform.tag);
                foreach (GameObject cube in objs)
                {
                    //set cube group color and change colorsSelected to false

                    cube.GetComponent<Renderer>().material.color = fcp.color;
                    
                }
                colorsSelected = false;
                colorsChanged += 1;
            }

        }

        if (colorsChanged >= lvlColors && completed == false)
        {
            finishButtonParent.SetActive(true);
            completed = true;
            StartCoroutine(cameraShake.Shake(.15f, .4f));
            confetti.Play();
        }
    }

    void colorButtonClick()
    {
        //Time.timeScale = 0.0f;
        cubeParent.SetActive(false);

        rgbSelect.SetActive(true);
        selectButtonParent.SetActive(true);
        cancelButtonParent.SetActive(true);

        settingsButtonParent.SetActive(false);
        backButtonParent.SetActive(false);
        colorButtonParent.SetActive(false);
        
    }

    void settingsButtonClick()
    {
        if(SettingsMenuParent.activeInHierarchy == false)
        {
            cubeParent.SetActive(false);
            colorButtonParent.SetActive(false);
            backButtonParent.SetActive(false);
            SettingsMenuParent.SetActive(true);
        }
        else
        {
            cubeParent.SetActive(true);
            colorButtonParent.SetActive(true);
            backButtonParent.SetActive(true);
            SettingsMenuParent.SetActive(false);
        }
    }

    void backButtonClick()
    {
        SceneManager.LoadScene("/Scenes/MainMenu");
    }

    void selectButtonClick()
    {
        //Time.timeScale = 1.0f;
        cubeParent.SetActive(true);

        rgbSelect.SetActive(false);
        selectButtonParent.SetActive(false);
        cancelButtonParent.SetActive(false);

        //show settings and back button
        settingsButtonParent.SetActive(true);
        backButtonParent.SetActive(true);
        colorButtonParent.SetActive(true);

        //set color to selection of the RGB selector

        colorsSelected = true;
        
        
        //Time.timeScale = 1.0f;
    }

    void cancelButtonClick()
    {
        //Time.timeScale = 1.0f;
        cubeParent.SetActive(true);

        rgbSelect.SetActive(false);
        selectButtonParent.SetActive(false);
        cancelButtonParent.SetActive(false);

        settingsButtonParent.SetActive(true);
        backButtonParent.SetActive(true);
        colorButtonParent.SetActive(true);

        colorsSelected = false;
        
        
        //Time.timeScale = 1.0f;
    }

    void finishButtonClick()
    {
        //Time.timeScale = 0.0f;
        finishMenuParent.SetActive(true);
    }

    //Next lvl button
    void nextLvlButtonClick()
    {
        SceneManager.LoadScene(nextScene);
    }

    void restartLvlButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void menuLvlButtonClick()
    {

    }
}
