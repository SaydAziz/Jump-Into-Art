using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    [SerializeField] GameObject[] SceneList;
    int currentSceneIndex = 1;  //need to compare inline decleration vs in Start();

    public static SceneManager Instance { get; private set; }
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void CycleNextScene()
    {
        Debug.Log("Next Scene");
        LoadNextScene();
        UnloadPrevScene();
        currentSceneIndex++;

    }
    void LoadNextScene()
    {
        SceneList[currentSceneIndex + 1].gameObject.SetActive(true);
    }
    void UnloadPrevScene()
    {
        SceneList[currentSceneIndex - 1].gameObject.SetActive(false);
    }
}
