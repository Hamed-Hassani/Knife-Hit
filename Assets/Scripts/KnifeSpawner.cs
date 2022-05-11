using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnifeSpawner : MonoBehaviour
{

    public Transform spawnPoint;
    public GameObject KnifePrefab;

    private Text scoreText;
    private int score;

    private void Awake()
    {
        scoreText = GameObject.Find("Score Text").GetComponent<Text>();
    }

    public void spawnKife()
    {
        GameObject go = Instantiate(KnifePrefab, spawnPoint.position, spawnPoint.rotation);
        go.transform.parent = spawnPoint;

    }
    public void IncrecmentScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

}
