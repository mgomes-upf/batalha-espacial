using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Cena do jogo (o nome tem que ser IGUAL ao da cena do jogo)
    [SerializeField] private string nomeCenaJogo = "SampleScene";

    public void StartGame()
    {
        // Carrega a cena principal do jogo
        SceneManager.LoadScene(nomeCenaJogo);
    }

    public void QuitGame()
    {
        // Funciona no Editor e no build
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #else
        Application.Quit();
    #endif
    }
}