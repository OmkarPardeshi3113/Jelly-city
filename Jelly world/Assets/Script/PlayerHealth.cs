using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public Rigidbody2D playerRB;
    public Animator playerANI;
    public float minHeightForDeath;
    public GameObject player;
    public TMP_Text healthText;

    private void FixedUpdate()
    {
        if (player.transform.position.y < minHeightForDeath)
        {
            Die();
        }

        healthText.text = "Health: " + health;
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        playerANI.SetTrigger("Death");
        RestartLevel();
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
