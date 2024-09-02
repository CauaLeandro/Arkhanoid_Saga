using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickRandomizer : MonoBehaviour
{
    public GameObject brickPrefab; // Prefab do tijolo
    public int rows = 5;           // N�mero de linhas de tijolos
    public int columns = 10;       // N�mero de colunas de tijolos
    public float xOffset = 1.0f;   // Espa�amento horizontal entre os tijolos
    public float yOffset = 0.5f;   // Espa�amento vertical entre os tijolos
    public Vector2 startPosition = new Vector2(-4.5f, 3.5f); // Posi��o inicial para colocar os tijolos

    private void Start()
    {
        GenerateBricks();
    }

    void GenerateBricks()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                if (Random.value > 0.3f) // 70% de chance de instanciar um tijolo
                {
                    Vector2 brickPosition = new Vector2(startPosition.x + col * xOffset, startPosition.y - row * yOffset);
                    Instantiate(brickPrefab, brickPosition, Quaternion.identity, transform);
                }
            }
        }
    }
}