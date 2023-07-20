using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionController : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        bool isRunning = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow);

        animator.SetBool("Run", isRunning);
    }
}
