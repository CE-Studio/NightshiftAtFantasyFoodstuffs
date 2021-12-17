using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public string state = "Usable";
    public GameObject player;
    
    void Start()
    {
        gameObject.transform.GetComponent<MeshRenderer>().material.color = new Color32(0, 255, 0, 150);
        player = GameObject.Find("Player");
    }

    void Update()
    {
        if (Input.GetAxisRaw("Fire1") == 0 || Vector3.Distance(transform.position, player.transform.position) > 2f)
        {
            gameObject.transform.GetComponent<MeshRenderer>().material.color = new Color32(0, 255, 0, 150);
        }
    }

    void OnMouseDown()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < 2f)
        {
            gameObject.transform.GetComponent<MeshRenderer>().material.color = new Color32(255, 255, 0, 150);
        }
    }
}
