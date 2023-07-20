using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] stages;

    void Start()
    {
        foreach (GameObject stage in stages)
        {
            stage.SetActive(false);
        }

        int randomIndex = Random.Range(0, stages.Length);

        stages[randomIndex].SetActive(true);
    }
}
