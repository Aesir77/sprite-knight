using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scri : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    public PlayerMovement player;
    public int trapDamage;

    public bool isPlayerOnTop;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            isPlayerOnTop= true;
        {
            anim.SetBool("isActive", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isPlayerOnTop= false;
        if (collision.gameObject.CompareTag("Player"))
        {
            anim.SetBool("isActive", false);
        }
    }

    public void PlayerDamage()
    {
        player.healthPoints -= trapDamage;
    }
}
