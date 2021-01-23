using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Instancia de la clase
    public static GameManager Instance;

    // Audio al morir el jugador
    public Sound PlayerDeath;

    // Comprobar si el estado del juego está activo
    public bool isGameActive;

    //Objeto del panel wingame
    public GameObject panelWinGame;

    private void Awake()
    {
        Instance = this;
        isGameActive = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        if(isGameActive)
        {
            isGameActive = false;
            AudioManager.Instance.PlaySound(PlayerDeath);
            SceneManager.LoadScene("Pacman");
        }
    }

    public void GameWin()
    {
        //todos los items a set active false
        if(isGameActive)
        {
            isGameActive = false;
            StartCoroutine(ShowGameWinPanelCoroutine());
            SceneManager.LoadScene("Pacman");
        }
    }

    public IEnumerator ShowGameWinPanelCoroutine()
    {
        yield return new WaitForSeconds(1.0f);
        panelWinGame.SetActive(true);
        Time.timeScale = 0;
    }
}
