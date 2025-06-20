using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public GameObject PrefabTriangle;
    public GameObject PrefabSquare;
    public GameObject PrefabCircle;
    public GameObject PrefabDiamond;

    public int TotalBlocks = 70;
    public float BlockWidth = 1.0f;

    private float StartX = -20f;

    private List<GameObject> PrefabList;
    private GameObject[] PrefabOptions;
    void Awake()
    {
        PrefabOptions = new GameObject[] {PrefabTriangle, PrefabSquare, PrefabDiamond, PrefabCircle};
        PrefabList = new List<GameObject>();
    }
    private void Start()
    {
        InstanciarBlocos();
    }

    private GameObject GetRandomPrefab()
    {
        int index = Random.Range(0,PrefabOptions.Length);
        return PrefabOptions[index];
    }

    private void InstanciarBlocos()
    {
        float[] LinhasY = { 3f, 1.15f, -0.60f, -2.25f };

        for (int j = 0; j < LinhasY.Length; j++)
        {
            GameObject RandomPrefab = GetRandomPrefab();
            int DirecaoLinha = Random.Range(0, 2); // 0 = esquerda, 1 = direita
            int BlocksCreated = 0;

            float CurrentX = StartX + 5;
            float CurrentY = LinhasY[j]; // desce Y a cada linha

            while (BlocksCreated < TotalBlocks)
            {
                int GroupSize = Random.Range(1, 3);

                //Se ultrapassar o total, vai ajustar o tamanho do grupo
                if (BlocksCreated + GroupSize > TotalBlocks)
                {
                    GroupSize = TotalBlocks - BlocksCreated;
                }

                for (int i = 0; i < GroupSize; i++)
                {
                    Vector2 posicao = new Vector2(CurrentX, CurrentY);
                    GameObject obj = Instantiate(RandomPrefab, posicao, Quaternion.identity);
                    obj.GetComponent<BlockMovement>().SetDirecao(DirecaoLinha);
                    obj.SetActive(true);
                    PrefabList.Add(obj);

                    CurrentX += BlockWidth;
                    BlocksCreated++;

                }

                CurrentX += (BlockWidth * 3);
            }
        }
    }

}
