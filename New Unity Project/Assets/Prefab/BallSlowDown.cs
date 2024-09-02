using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSlowDown : MonoBehaviour
{
    public float speedMultiplier = 0.5f; // Multiplicador de velocidade (metade da velocidade)
    public float duration = 10f; // Duração do efeito

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            StartCoroutine(ApplyPowerUp(collision.gameObject));
        }
    }

    private IEnumerator ApplyPowerUp(GameObject ball)
    {
        // Acessa o Rigidbody2D da bola para ajustar a velocidade
        Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity *= speedMultiplier;
        }

        // Destrói o power-up
        Destroy(gameObject);

        // Aguarda o tempo de duração do efeito
        yield return new WaitForSeconds(duration);

        // Restaura a velocidade original
        if (rb != null)
        {
            rb.velocity /= speedMultiplier;
        }
    }
}