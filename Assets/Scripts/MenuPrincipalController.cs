using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalController : MonoBehaviour
{
    public void Jogar()
    {
        SceneManager.LoadScene("SampleScene"); // Nome da cena do jogo
    }

    public void Sair()
    {
        Application.Quit();
    }
}