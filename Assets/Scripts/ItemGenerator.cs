using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject itemPrefab;
    private int itemCount = 4;

    void Start()
    {
        for (int i = 0; i < itemCount; i++)
        {
            float randomX = Random.Range(-19f, 19f);
            float randomZ = Random.Range(-10f, 10f);

            Vector3 spawnPosition = new Vector3(randomX, 1f, randomZ);

            Instantiate(itemPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
