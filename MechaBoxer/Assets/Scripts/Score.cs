using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Transform ground;
    public Text scoreText;

    private float distance;
    private float[] position = {0,0 };

    void Start()
    {
        position[0] = player.position.z;
        distance = ground.localScale.z;
    }

    // Update is called once per frame
    void Update () {
        position[1] = player.position.z;
        distance = distance - (position[1] - position[0]);
        scoreText.text = distance.ToString("0");
        position[0] = position[1];

        if (distance <= 0)
        {
            scoreText.text = "0";
        }
	}
}
