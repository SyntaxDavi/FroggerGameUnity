using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    public float MoveSpeed = 1f;
    private float Direcao;
    private float LimiarEsquerdo = -13f;
    private float LimiarDireita = 20f;

    private void Start()
    {
        MoveSpeed = GameData.CurrentSpeed;
    }
    public void SetDirecao(float direcao)
    {
        Direcao = direcao;
    }

    private void FixedUpdate()
    {
        DirecaoBlock();
    }

    private void DirecaoBlock()
    {
        //0 é esquerda, qualquer outra coisa direita

        if (Direcao == 0)
        {
            transform.Translate(Vector2.left * MoveSpeed * Time.deltaTime);

            if (transform.position.x <= LimiarEsquerdo)
            {
                Vector2 NovaPosicao = new Vector2(LimiarDireita, transform.position.y);
                transform.position = NovaPosicao;

            }
        }
        else if(Direcao == 1)
        {
            transform.Translate(Vector2.right * MoveSpeed * Time.deltaTime);

            if (transform.position.x >= LimiarDireita)
            {
                Vector2 NovaPosicao = new Vector2(LimiarEsquerdo, transform.position.y);
                transform.position = NovaPosicao;
            }
        }
    }
}
