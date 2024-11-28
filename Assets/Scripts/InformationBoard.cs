using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class InformationBoard : MonoBehaviour
{
    public GameObject promtPrefab;
    public GameObject infomationBoardPrefab;
    public Image infomationImageCanvas;

    public Vector3 promtPosition;
    public Sprite[] infomation;

    public void ExitButton()
    {
        GameObject promt = Instantiate(promtPrefab);
        promt.transform.position = promtPosition;
        Destroy(infomationBoardPrefab);
    }

    int infomationIndex = 0;
    public void NextButton()
    {
        int infomationUpperBound = infomation.Length - 1;
        if (infomationIndex < infomationUpperBound)
        {
            infomationIndex++;
            infomationImageCanvas.sprite = infomation[infomationIndex];
        }
    }

    public void PreviousButton()
    {
        int infomationLowerBound = 0;
        if (infomationIndex > infomationLowerBound)
        {
            infomationIndex--;
            infomationImageCanvas.sprite = infomation[infomationIndex];
        }
    }
}