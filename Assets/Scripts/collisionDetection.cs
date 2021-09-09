using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class collisionDetection : MonoBehaviour
{
    public Transform player;
    


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Start Terrain")
        {

            player.transform.SetPositionAndRotation(new Vector3(0, 0.5f, 0), new Quaternion());
            PlayerController playerScript = player.GetComponent<PlayerController>();
            playerScript.speed = 5;
        }
        if (collision.gameObject.name == "Level 2 Terrain")
        {

            player.transform.SetPositionAndRotation(new Vector3(0, 0.5f, 666), new Quaternion());
            PlayerController playerScript = player.GetComponent<PlayerController>();
            playerScript.speed = 5;
        }
        if (collision.gameObject.name == "Final Level Terrain")
        {

            player.transform.SetPositionAndRotation(new Vector3(0, 0.5f, 1800), new Quaternion());
            PlayerController playerScript = player.GetComponent<PlayerController>();
            playerScript.speed = 5;
        }


    }
}
