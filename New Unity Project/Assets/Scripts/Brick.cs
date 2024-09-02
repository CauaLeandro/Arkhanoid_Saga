using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public GameObject[] powerUps; // Array de prefabs dos power-ups
    public float dropChance = 0.3f; // Chance de um power-up ser dropado (30%)

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica se a colis�o foi com a bola (ou outro objeto relevante)
        if (collision.gameObject.CompareTag("Ball"))
        {
            // Destr�i o tijolo
            Destroy(gameObject);

            // Tenta dropar um power-up
            TryDropPowerUp();
        }
    }

    void TryDropPowerUp()
    {
        // Verifica se o power-up deve ser dropado
        if (Random.value <= dropChance)
        {
            // Seleciona aleatoriamente um power-up
            int powerUpIndex = Random.Range(0, powerUps.Length);

            // Instancia o power-up na posi��o do tijolo
            Instantiate(powerUps[powerUpIndex], transform.position, Quaternion.identity);
        }
    }
}
