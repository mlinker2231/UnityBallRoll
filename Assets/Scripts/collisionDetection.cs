using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class collisionDetection : MonoBehaviour
{
    public Transform player;
    public AudioSource audioSource;



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Tree"  || collision.gameObject.name == "Tree1" || collision.gameObject.name == "Tree2")
        {


            print(collision.gameObject.tag);
            print(collision);

            player.transform.SetPositionAndRotation(new Vector3(0, 0.5f, 0), new Quaternion());
            PlayerController playerScript = player.GetComponent<PlayerController>();
            playerScript.speed = 5;
            audioSource.Stop();
            audioSource.Play();
            

        }

    }
}
