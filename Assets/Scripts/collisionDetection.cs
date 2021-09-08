using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class collisionDetection : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI textLabel;
    


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Player" && collision.transform.position.y >= .5)
        {

            collision.gameObject.transform.SetPositionAndRotation(new Vector3(0, 0.5f, 0), new Quaternion());
            PlayerController playerScript = player.GetComponent<PlayerController>();
            playerScript.speed = 5;
        }


    }
}
