using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private string NomeDaFase;
    [SerializeField] private GameObject painelMenuinicial;
    [SerializeField] private GameObject painelOpçoes;
    [SerializeField] private GameObject painelControles;

    public void AbrirMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Joga()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void AbriOpçoes()
    {
        SceneManager.LoadScene("Options");
    }

    public void FecharOpçoes()
    {
        SceneManager.LoadScene("Menu");
    }
    public void AbrirInfo()
    {
        SceneManager.LoadScene("Info");
    }

    public void FecharInfo()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Sair()
    {
        Debug.Log("Saiu do Jogo");
        Application.Quit();
    }

}

