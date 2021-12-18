using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SitAtOfficeDesk : MonoBehaviour
{
    public string isSitting = "No";  // Just so the script knows what state the player is in
    public GameObject player;        // The player
    public GameObject playerCam;     // The player's camera
    public GameObject crosshairs;    // The crosshairs

    Vector3 startPos;                // Set to the player's current position when used
    Vector3 endPos;                  // Set to the seat's position when used
    Quaternion playerStartRot;       // Set to the player's current rotation when used
    Quaternion camStartRot;          // Set to the player camera's current rotation when used
    Quaternion playerEndRot;         // Set to a fixed end rotation when used
    Quaternion camEndRot;            // Set to a fixed end rotation when used

    float i;                         // Initiated outside the function so it can be kept track of
    float storedSpeed;               // Hold's player speed while the player checks the cameras
    float storedSensitivity;         // Hold's player look sensitivity while the player checks the cameras

    void Start()
    {
        player = GameObject.Find("Player");
        playerCam = GameObject.Find("Player/Main Camera");
        crosshairs = GameObject.Find("Canvas/Crosshairs");
    }

    void Update()
    {
        if (Input.GetKeyDown("e") && isSitting == "Yes" && Vector3.Distance(transform.position, player.transform.position) < 1)
        {
            player.GetComponent<MovePlayer>().xRotation = 0f;
            startPos = player.transform.position;
            endPos = new Vector3(0.5f, 1f, -0.1f);
            playerStartRot = player.transform.rotation;
            camStartRot = playerCam.transform.rotation;
            playerEndRot = Quaternion.Euler(0f, 7.5f, 0f);
            camEndRot = Quaternion.Euler(0f, 7.5f, 0f);
            Cursor.lockState = CursorLockMode.Locked;
            isSitting = "Standing...";
        }
        
        if (isSitting == "Sitting..." || isSitting == "Standing...") // A two-way transition from one state to another. Useful for both sitting and standing given how the transition works
        {
            if (i < 1)
            {
                player.transform.position = Vector3.Slerp(startPos, endPos, i);
                player.transform.rotation = Quaternion.Slerp(playerStartRot, playerEndRot, i);
                playerCam.transform.rotation = Quaternion.Slerp(camStartRot, camEndRot, i);
                i = i + Time.deltaTime;
                if (i >= 1 && isSitting == "Sitting...")
                {
                    isSitting = "Yes";
                    Cursor.lockState = CursorLockMode.None;
                    i = 0;
                }
                else if (i >= 1 && isSitting == "Standing...")
                {
                    isSitting = "No";
                    player.GetComponent<MovePlayer>().speed = storedSpeed;
                    player.GetComponent<MovePlayer>().lookSensitivity = storedSensitivity;
                    crosshairs.GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                    i = 0;
                }
            }
        }
    }

    void OnMouseDown()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < 2f)
        {
            startPos = player.transform.position;
            endPos = new Vector3(-1f, 1f, -1f);
            playerStartRot = player.transform.rotation;
            camStartRot = playerCam.transform.rotation;
            playerEndRot = Quaternion.Euler(0f, 175f, 0f);
            camEndRot = Quaternion.Euler(0f, 175f, 0f);
            storedSpeed = player.GetComponent<MovePlayer>().speed;
            player.GetComponent<MovePlayer>().speed = 0f;
            storedSensitivity = player.GetComponent<MovePlayer>().lookSensitivity;
            player.GetComponent<MovePlayer>().lookSensitivity = 0f;
            crosshairs.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
            isSitting = "Sitting...";
        }
    }
}
