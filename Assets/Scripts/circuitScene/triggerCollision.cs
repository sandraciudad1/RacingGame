using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerCollision : MonoBehaviour
{
    [SerializeField] GameObject finishTrigger;
    [SerializeField] GameObject firework;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (gameObject.CompareTag("beforeFinish"))
            {
                finishTrigger.SetActive(false);
                firework.SetActive(true);
                StartCoroutine(waitMainScene());
            }
        }
    }

    IEnumerator waitMainScene()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.sceneLoaded += OnSceneLoaded;
        SceneManager.LoadScene("mainScene");
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
