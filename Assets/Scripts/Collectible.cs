using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public bool speed, health;
    public int speedBoost, healthBoost, duration;
    public PlayerMovement player;
    private int baseMovespeed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (speed)
        {
            player.moveSpeed += speedBoost;
            StartCoroutine(BackToBaseSpeed());
        }
        
        if (health)
        {
            player.healthPoints += healthBoost;
        }
        

        IEnumerator BackToBaseSpeed()
        {
            yield return new WaitForSeconds(duration);
            player.moveSpeed = baseMovespeed;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        baseMovespeed = player.moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
