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

        if (collision.GetContact(0).point.y > .51)
        {
            player.SetPositionAndRotation(new Vector3(player.position.x, player.position.y), new Quaternion());
            collision.collider.transform.SetPositionAndRotation(player.position - new Vector3(400, (float)0.2, 400), new Quaternion(0, 0, 0, 0));
            GameObject thePlayer = GameObject.Find("Player");
            PlayerController playerScript = thePlayer.GetComponent<PlayerController>();
            playerScript.speed = 10;
        }


    }
}
