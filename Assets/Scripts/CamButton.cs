using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamButton : MonoBehaviour
{
    public string camToPick;
    public GameObject monitor;

    void Start()
    {
        monitor = GameObject.Find("Camera monitor");
    }

    void OnMouseDown()
    {
        switch (camToPick)
        {
            case "1A":
                monitor.GetComponent<CamControl>().SwapTo1A();
                break;
            case "1B":
                monitor.GetComponent<CamControl>().SwapTo1B();
                break;
            case "2":
                monitor.GetComponent<CamControl>().SwapTo2();
                break;
            case "3A":
                monitor.GetComponent<CamControl>().SwapTo3A();
                break;
            case "3B":
                monitor.GetComponent<CamControl>().SwapTo3B();
                break;
            case "4":
                monitor.GetComponent<CamControl>().SwapTo4();
                break;
            case "5":
                monitor.GetComponent<CamControl>().SwapTo5();
                break;
            case "6A":
                monitor.GetComponent<CamControl>().SwapTo6A();
                break;
            case "6B":
                monitor.GetComponent<CamControl>().SwapTo6B();
                break;
            case "6C":
                monitor.GetComponent<CamControl>().SwapTo6C();
                break;
            case "7":
                monitor.GetComponent<CamControl>().SwapTo7();
                break;
            case "8":
                monitor.GetComponent<CamControl>().SwapTo8();
                break;
            case "9":
                monitor.GetComponent<CamControl>().SwapTo9();
                break;
        }
    }
}
