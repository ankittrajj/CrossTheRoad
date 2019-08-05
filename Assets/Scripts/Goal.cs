using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private GameObject player;
    private Vector3 initialPos;
    public Text scoreText;
    private int score;
    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindWithTag("Player");
        initialPos = player.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            target.transform.position = initialPos;
            score += 100;
            scoreText.text = score.ToString();
        }
        
    }
}
