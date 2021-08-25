using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
	public Transform player;
    public TextMeshProUGUI scoreText;
    private float count = 0;

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        scoreText.text = (count).ToString("0");
    }

}
