using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScene : MonoBehaviour
{

    void Start()
    {   // Espera 3 segundos y luego llama al método LoadMainMenu
        Invoke("LoadMainMenu", 3);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadMainMenu()
    {
        // Carga el menú principal su Scena
        SceneManager.LoadScene("MainMenu");
        //SceneManager.LoadScene(0); // porque MainMenu es la escena con índice 0 en tu Build Settings

    }
}
