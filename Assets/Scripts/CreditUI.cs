using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Menambahkan direktif untuk menggunakan kelas UI
using UnityEngine.SceneManagement; // Menambahkan direktif untuk menggunakan SceneManager

public class CreditUIController : MonoBehaviour
{
    public Button backButton; // Menggunakan kelas Button dari namespace UI
    

    private void Start()
  {
    backButton.onClick.AddListener(BackToMainMenu);

  }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


}
