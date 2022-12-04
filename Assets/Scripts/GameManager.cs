using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text ScoreText;
    public GameObject Settings;
    public GameObject MainMenu;
    public GameObject VolumeOffButton;
    public GameObject VolumeOnButton;
    public bool SoundOff;
    private void Start()
    {
        SoundOff= false;
        score= 0;
        ScoreText.text = score.ToString();
    }

    public void UpdateScore()
    {        
        score++;
        ScoreText.text = score.ToString();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void GoMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void GoSettings()
    {
        Settings.SetActive(true);
        MainMenu.SetActive(false);
    }
    public void VolumeOff()
    {
        SoundOff = true;
        AudioListener.volume = 0;
        VolumeOffButton.SetActive(false);
        VolumeOnButton.SetActive(true);
    }
    public void VolumeOn()
    {
        SoundOff = false;
        AudioListener.volume = 1;
        VolumeOffButton.SetActive(true);
        VolumeOnButton.SetActive(false);
    }
}