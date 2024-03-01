using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Menambahkan direktif untuk menggunakan kelas UI
using UnityEngine.SceneManagement; // Menambahkan direktif untuk menggunakan SceneManager

public class MainMenuUIController : MonoBehaviour
{
    public Button playButton; // Menggunakan kelas Button dari namespace UI
    public Button exitButton; // Menggunakan kelas Button dari namespace UI
    public Button creditButton;

    private void Start()
  {
    playButton.onClick.AddListener(PlayGame);
    exitButton.onClick.AddListener(ExitGame);
    creditButton.onClick.AddListener(CreditScene);
  }

    public void PlayGame()
    {
        SceneManager.LoadScene("Pinball_Game");
    }

    private void ExitGame() // Mengubah private menjadi public agar dapat diakses dari luar kelas
    {
        Application.Quit();
    }

    private void CreditScene()
    {
      SceneManager.LoadScene("Credits");
    }
}
