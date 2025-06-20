using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public int Health = 3;
    private bool IsInvincible = false;
    private float InvincibleTime = 0.4f;

    public Text PlayerHealthText;
    private void Update()
    {
        PlayerHealthText.text = Health.ToString();

        if(Health <= 0)
        {
            GameRestart();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Inimigo")){
            TakeDamage(1);
        }
    }

    private void GameRestart()
    {
        Scene CurrentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(CurrentScene.name);
    }

    IEnumerator InvincibilityTimer()
    {
        IsInvincible = true;
        yield return new WaitForSeconds(InvincibleTime);
        IsInvincible = false;
    }

    public void TakeDamage(int amount)
    {
        if (IsInvincible) { return; }

        Health -= amount;

        StartCoroutine(InvincibilityTimer());
    }
}
