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

    //Objeto del panel lostgame
    public GameObject panelLostGame;

    //Array de los items
    public GameObject items;

    private bool itemsNotActive;

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

    // Comprobar que el jugador ha perdido cuando un fantasma colisiona con él
    public void GameOver()
    {
        if(isGameActive)
        {
            isGameActive = false;
            AudioManager.Instance.PlaySound(PlayerDeath);
            StartCoroutine(ShowGameLostPanelCoroutine());
            SceneManager.LoadScene("Pacman");
        }
    }

    // Comprobar que los items del hierarchy están set active false
    public void CheckItems()
    {
        if(items.activeInHierarchy == false)
        {
            itemsNotActive = true;
        } 
    }

    // Comprobar que el jugador ha ganado cuando todos los items están set active false
    public void GameWin()
    {
        //todos los items a set active false
        if(isGameActive && itemsNotActive)
        {
            isGameActive = false;
            StartCoroutine(ShowGameWinPanelCoroutine());
            SceneManager.LoadScene("Pacman");
        }
    }

    // Panel de victoria
    public IEnumerator ShowGameWinPanelCoroutine()
    {
        yield return new WaitForSeconds(3.0f);
        panelWinGame.SetActive(true);
        Time.timeScale = 0;
    }

    // Panel de derrota
    public IEnumerator ShowGameLostPanelCoroutine()
    {
        yield return new WaitForSeconds(3.0f);
        panelWinGame.SetActive(true);
        Time.timeScale = 0;
    }
}
