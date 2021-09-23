using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
	public Transform player;
    public Text winText;
    public TextMeshProUGUI scoreText;
    private float count = 0;

    // Update is called once per frame
    void Update()
    {
        count = player.position.z;
        scoreText.text = (count).ToString("0");
        if (player.position.z >= 600f && player.position.z <= 650)
        {
            winText.transform.SetPositionAndRotation(winText.transform.position, new Quaternion(0f, 0f, 0f, 0f));
            winText.text = "Level 1 Complete";
           
           
        }if (player.position.z >= 650 && player.position.z <= 700)
        {
            winText.transform.SetPositionAndRotation(winText.transform.position, new Quaternion(90f, 90f, 90f, 90f));
        }
        if (player.position.z >= 1800 && player.position.z <= 1900)
        {
            winText.transform.SetPositionAndRotation(winText.transform.position, new Quaternion(0f, 0f, 0f, 0f));
            winText.text = "Level 2 Complete";

        }
        if (player.position.z >= 1950 && player.position.z <= 2000)
        {
            winText.transform.SetPositionAndRotation(winText.transform.position, new Quaternion(90f, 90f, 90f, 90f));
        }
        if (player.position.z >= 3000 && player.position.z <= 3100)
        {
            winText.transform.SetPositionAndRotation(winText.transform.position, new Quaternion(0f, 0f, 0f, 0f));
            winText.text = "Final level Complete";

        }
        if (player.position.z >= 3150 && player.position.z <= 3200)
        {
            winText.transform.SetPositionAndRotation(winText.transform.position, new Quaternion(90f, 90f, 90f, 90f));
        }
    }

}
