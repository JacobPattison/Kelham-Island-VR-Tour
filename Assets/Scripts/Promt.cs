using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Promt : MonoBehaviour
{
    public GameObject infomationBoardPrefab;
    public GameObject promtPrefab;

    //InformationBoard informationBoard;

    public void InstantiateInfomationBoard()
    {
        GameObject infomationBoard = Instantiate(infomationBoardPrefab);
        infomationBoard.transform.position = new Vector3(0, 2, (float)1.2);
        Destroy(promtPrefab);
    }
}
