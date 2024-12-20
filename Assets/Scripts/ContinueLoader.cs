using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueLoader : MonoBehaviour
{
    public int sceneNumber;
    public bool onLevel;
    public ContinueLoader sceneManagement;

    private static GameObject sampleInstance;

    [Header("Bools")]
    public bool lvl1Done = false;
    public bool lvl2Done = false;
    public bool lvl3Done = false;
    public bool lvl4Done = false;
    public bool lvl5Done = false;
    public bool lvl6Done = false;
    public bool lvl7Done = false;
    public bool lvl8Done = false;
    public bool lvl9Done = false;

    private void Awake()
    {
        if (onLevel == false)
        {
            if (sampleInstance == null)
            {
                Destroy(sampleInstance);
            }
            sampleInstance = gameObject;
            DontDestroyOnLoad(gameObject);
        }

    }

    private void Start()
    {
        if (onLevel == true)
        {
            sceneNumber = SceneManager.GetActiveScene().buildIndex;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (onLevel == true)
        {
            ContinueLoader loaders = FindObjectOfType<ContinueLoader>();
            loaders.sceneNumber = sceneNumber;
            if (lvl1Done)
            {
                loaders.lvl1Done = true;
            }
            if (lvl2Done)
            {
                loaders.lvl2Done = true;
            }
            if (lvl3Done)
            {
                loaders.lvl3Done = true;
            }
            if (lvl4Done)
            {
                loaders.lvl4Done = true;
            }
            if (lvl5Done)
            {
                loaders.lvl5Done = true;
            }
            if (lvl6Done)
            {
                loaders.lvl6Done = true;
            }
            if (lvl7Done)
            {
                loaders.lvl7Done = true;
            }
            if (lvl8Done)
            {
                loaders.lvl8Done = true;
            }
            if (lvl9Done)
            {
                loaders.lvl9Done = true;
            }

        }

        if (onLevel == false)
        {
            ContinueLoader[] loaders = FindObjectsOfType<ContinueLoader>();
            foreach (ContinueLoader go in loaders)
            {
                if (go.gameObject != gameObject && lvl1Done && go.onLevel == false)
                {
                    Destroy(go);
                }
                else
                {
                    return;
                }
            }      
        }
    }
}
