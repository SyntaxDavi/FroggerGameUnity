using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerChegada : MonoBehaviour
{
    public Text Pontos;
    private int CurrentPoints = 5;

    private PlayerHealth PlayerHealthScript;

    private void Awake()
    {
        PlayerHealthScript = GetComponent<PlayerHealth>();
        CurrentPoints = GameData.CurrentPoints;
        Pontos.text = CurrentPoints.ToString();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Chegada") && PlayerHealthScript.Health > 0)
        {
            NextFase();
        }
    }

    private void NextFase()
    {
        if (PlayerHealthScript != null)
        {
            PlayerHealthScript.Health = 3;

            CurrentPoints++;
            GameData.CurrentPoints = CurrentPoints;
            GameData.CurrentSpeed += 0.3f;
               
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
