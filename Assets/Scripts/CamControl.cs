using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    public Camera Cam1A;
    public Camera Cam1B;
    public Camera Cam2;
    public Camera Cam3A;
    public Camera Cam3B;
    public Camera Cam4;
    public Camera Cam5;
    public Camera Cam6A;
    public Camera Cam6B;
    public Camera Cam6C;
    public Camera Cam7;
    public Camera Cam8;
    public Camera Cam9;

    public Animator mapAnim;
    
    void Start() // Initiating each camera before preemtively deactivating each one just to turn on Cam 1A, just to have something to default to at the beginning of each night
    {
        Cam1A = GameObject.Find("Cams/1A").transform.GetChild(0).GetChild(0).GetComponent<Camera>();
        Cam1B = GameObject.Find("Cams/1B").transform.GetChild(0).GetChild(0).GetComponent<Camera>();
        Cam2 = GameObject.Find("Cams/2").transform.GetChild(0).GetChild(0).GetComponent<Camera>();
        Cam3A = GameObject.Find("Cams/3A").transform.GetChild(0).GetChild(0).GetComponent<Camera>();
        Cam3B = GameObject.Find("Cams/3B").transform.GetChild(0).GetChild(0).GetComponent<Camera>();
        Cam4 = GameObject.Find("Cams/4").transform.GetChild(0).GetChild(0).GetComponent<Camera>();
        Cam5 = GameObject.Find("Cams/5").transform.GetChild(0).GetChild(0).GetComponent<Camera>();
        Cam6A = GameObject.Find("Cams/6A").transform.GetChild(0).GetChild(0).GetComponent<Camera>();
        Cam6B = GameObject.Find("Cams/6B").transform.GetChild(0).GetChild(0).GetComponent<Camera>();
        Cam6C = GameObject.Find("Cams/6C").transform.GetChild(0).GetChild(0).GetComponent<Camera>();
        Cam7 = GameObject.Find("Cams/7").transform.GetChild(0).GetChild(0).GetComponent<Camera>();
        Cam8 = GameObject.Find("Cams/8").transform.GetChild(0).GetChild(0).GetComponent<Camera>();
        Cam9 = GameObject.Find("Cams/9").transform.GetChild(0).GetChild(0).GetComponent<Camera>();

        DeactivateAll();
        Cam1A.enabled = true;
        Cam1A.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = false;

        mapAnim = GameObject.Find("Map monitor").transform.GetChild(0).GetComponent<Animator>();
    }

    void DeactivateAll() // An all-access camera reset function to call before activating a certain camera
    {
        Cam1A.enabled = false;
        Cam1A.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = true;
        Cam1B.enabled = false;
        Cam1B.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = true;
        Cam2.enabled = false;
        Cam2.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = true;
        Cam3A.enabled = false;
        Cam3A.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = true;
        Cam3B.enabled = false;
        Cam3B.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = true;
        Cam4.enabled = false;
        Cam4.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = true;
        Cam5.enabled = false;
        Cam5.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = true;
        Cam6A.enabled = false;
        Cam6A.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = true;
        Cam6B.enabled = false;
        Cam6B.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = true;
        Cam6C.enabled = false;
        Cam6C.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = true;
        Cam7.enabled = false;
        Cam7.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = true;
        Cam8.enabled = false;
        Cam8.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = true;
        Cam9.enabled = false;
        Cam9.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = true;
    }

    public void SwapTo1A()
    {
        DeactivateAll();
        Cam1A.enabled = true;
        Cam1A.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = false;

        mapAnim.Play("Map 1A", 0, 0);
    }

    public void SwapTo1B()
    {
        DeactivateAll();
        Cam1B.enabled = true;
        Cam1B.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = false;

        mapAnim.Play("Map 1B", 0, 0);
    }

    public void SwapTo2()
    {
        DeactivateAll();
        Cam2.enabled = true;
        Cam2.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = false;

        mapAnim.Play("Map 2", 0, 0);
    }

    public void SwapTo3A()
    {
        DeactivateAll();
        Cam3A.enabled = true;
        Cam3A.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = false;

        mapAnim.Play("Map 3A", 0, 0);
    }

    public void SwapTo3B()
    {
        DeactivateAll();
        Cam3B.enabled = true;
        Cam3B.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = false;

        mapAnim.Play("Map 3B", 0, 0);
    }

    public void SwapTo4()
    {
        DeactivateAll();
        Cam4.enabled = true;
        Cam4.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = false;

        mapAnim.Play("Map 4", 0, 0);
    }

    public void SwapTo5()
    {
        DeactivateAll();
        Cam5.enabled = true;
        Cam5.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = false;

        mapAnim.Play("Map 5", 0, 0);
    }

    public void SwapTo6A()
    {
        DeactivateAll();
        Cam6A.enabled = true;
        Cam6A.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = false;

        mapAnim.Play("Map 6A", 0, 0);
    }

    public void SwapTo6B()
    {
        DeactivateAll();
        Cam6B.enabled = true;
        Cam6B.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = false;

        mapAnim.Play("Map 6B", 0, 0);
    }

    public void SwapTo6C()
    {
        DeactivateAll();
        Cam6C.enabled = true;
        Cam6C.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = false;

        mapAnim.Play("Map 6C", 0, 0);
    }

    public void SwapTo7()
    {
        DeactivateAll();
        Cam7.enabled = true;
        Cam7.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = false;

        mapAnim.Play("Map 7", 0, 0);
    }

    public void SwapTo8()
    {
        DeactivateAll();
        Cam8.enabled = true;
        Cam8.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = false;

        mapAnim.Play("Map 8", 0, 0);
    }

    public void SwapTo9()
    {
        DeactivateAll();
        Cam9.enabled = true;
        Cam9.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = false;

        mapAnim.Play("Map 9", 0, 0);
    }
}
