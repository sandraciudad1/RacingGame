using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camSwitchBtns : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera interiorCam;
    [SerializeField] CinemachineVirtualCamera perspectiveCam;
    [SerializeField] CinemachineVirtualCamera frontCam;
    [SerializeField] CinemachineVirtualCamera backCam;
    [SerializeField] CinemachineVirtualCamera rightLateralCam;
    [SerializeField] CinemachineVirtualCamera leftLateralCam;
    [SerializeField] CinemachineVirtualCamera topCam;

    void Start()
    {
        interiorCam.Priority = 1;
        perspectiveCam.Priority = 5;
        frontCam.Priority = 1;
        backCam.Priority = 1;
        rightLateralCam.Priority = 1;
        leftLateralCam.Priority = 1;
        topCam.Priority = 1;
    }

    public void changeToInterior()
    {
        interiorCam.Priority = 5;
        perspectiveCam.Priority = 1;
        frontCam.Priority = 1;
        backCam.Priority = 1;
        rightLateralCam.Priority = 1;
        leftLateralCam.Priority = 1;
        topCam.Priority = 1;
    }

    public void changeToPerspective()
    {
        interiorCam.Priority = 1;
        perspectiveCam.Priority = 5;
        frontCam.Priority = 1;
        backCam.Priority = 1;
        rightLateralCam.Priority = 1;
        leftLateralCam.Priority = 1;
        topCam.Priority = 1;
    }

    public void changeToFront()
    {
        interiorCam.Priority = 1;
        perspectiveCam.Priority = 1;
        frontCam.Priority = 5;
        backCam.Priority = 1;
        rightLateralCam.Priority = 1;
        leftLateralCam.Priority = 1;
        topCam.Priority = 1;
    }
    public void changeToBack()
    {
        interiorCam.Priority = 1;
        perspectiveCam.Priority = 1;
        frontCam.Priority = 1;
        backCam.Priority = 5;
        rightLateralCam.Priority = 1;
        leftLateralCam.Priority = 1;
        topCam.Priority = 1;
    }

    public void changeToRightLateral()
    {
        interiorCam.Priority = 1;
        perspectiveCam.Priority = 1;
        frontCam.Priority = 1;
        backCam.Priority = 1;
        rightLateralCam.Priority = 5;
        leftLateralCam.Priority = 1;
        topCam.Priority = 1;
    }

    public void changeToLeftLateral()
    {
        interiorCam.Priority = 1;
        perspectiveCam.Priority = 1;
        frontCam.Priority = 1;
        backCam.Priority = 1;
        rightLateralCam.Priority = 1;
        leftLateralCam.Priority = 5;
        topCam.Priority = 1;
    }

    public void changeToTop()
    {
        interiorCam.Priority = 1;
        perspectiveCam.Priority = 1;
        frontCam.Priority = 1;
        backCam.Priority = 1;
        rightLateralCam.Priority = 1;
        leftLateralCam.Priority = 1;
        topCam.Priority = 5;
    }
}
