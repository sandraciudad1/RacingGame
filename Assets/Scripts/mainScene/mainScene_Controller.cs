using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainScene_Controller : MonoBehaviour
{
    public void freeDrivingBtn()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        SceneManager.LoadScene("FreeDriving_Scene");
    }

    public void circuitDrivingBtn()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        SceneManager.LoadScene("circuitDriving_Scene");
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
