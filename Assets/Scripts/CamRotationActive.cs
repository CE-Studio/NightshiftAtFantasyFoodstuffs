using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotationActive : MonoBehaviour
{
    public bool isRotating;
    public Animator anim;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("ShouldRotate", isRotating);
    }
}
