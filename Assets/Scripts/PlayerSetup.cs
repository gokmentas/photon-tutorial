using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetup : MonoBehaviour
{

    public PlayerMovement movement;

    public GameObject cam;


    public void IsLocalPlayer()
    {
        movement.enabled = true;
        cam.SetActive(true);
    }


} // class
