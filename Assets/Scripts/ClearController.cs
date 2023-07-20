using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearController : MonoBehaviour
{
    private int itemCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            itemCount++;
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Goal"))
        {
            if (itemCount >= 4)
            {
                SceneManager.LoadScene("GameClear");
            }
        }
    }
}
