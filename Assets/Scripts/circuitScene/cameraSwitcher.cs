using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using TMPro;
using UnityEngine.UI;

public class cameraSwitcher : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera rearCam;
    [SerializeField] CinemachineVirtualCamera topCam;
    [SerializeField] CinemachineVirtualCamera interiorCam;

    [SerializeField] TextMeshProUGUI countdownText;
    [SerializeField] Image redCircle;
    [SerializeField] Image greyCircle;
    [SerializeField] Image bg;
    [SerializeField] GameObject switchBtn;

    private bool switchedToTop = false;
    private float timer = 3f;
    public bool canStart = false;
    private bool isTopCameraActive = false; 

    void Start()
    {
        rearCam.Priority = 5;
        topCam.Priority = 1;
        interiorCam.Priority = 1;

        countdownText.text = Mathf.Ceil(timer).ToString();
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;

            float fractionalTime = timer % 1f;
            redCircle.fillAmount = 1 - fractionalTime;
            countdownText.text = Mathf.Ceil(timer).ToString();
        }
        else
        {
            redCircle.fillAmount = 1;
            StartCoroutine(StartText());
        }

        if (canStart && !switchedToTop)
        {
            SwitchToTopCamera();
        }
    }

    IEnumerator StartText()
    {
        redCircle.gameObject.SetActive(false);
        greyCircle.gameObject.SetActive(false);
        countdownText.text = "START!";

        yield return new WaitForSeconds(1f);

        countdownText.gameObject.SetActive(false);
        bg.gameObject.SetActive(false);
        switchBtn.SetActive(true);
        canStart = true;
    }

    void SwitchToTopCamera()
    {
        interiorCam.Priority = 1;
        rearCam.Priority = 1;
        topCam.Priority = 5;

        isTopCameraActive = true; 
        switchedToTop = true;
    }

    public void SwitchCamera()
    {
        if (isTopCameraActive)
        {
            topCam.Priority = 1;
            interiorCam.Priority = 5;
        }
        else
        {
            interiorCam.Priority = 1;
            topCam.Priority = 5;
        }

        isTopCameraActive = !isTopCameraActive;
    }
}
