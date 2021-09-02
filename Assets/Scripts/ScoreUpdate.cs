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
        if (player.position.z >= 600f)
        {
            winText.transform.SetPositionAndRotation(winText.transform.position, new Quaternion(0f, 0f, 0f, 0f));
           
        }
    }

}
