using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDetection : MonoBehaviour
{
    public Transform player;


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.GetContact(0).point.y > .51)
        {

            collision.collider.transform.SetPositionAndRotation(player.position - new Vector3(400, (float)0.2, 400), new Quaternion(0, 0, 0, 0));
        }


    }
}
