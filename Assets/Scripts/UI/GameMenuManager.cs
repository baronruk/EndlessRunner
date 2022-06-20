using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _userInterface;
    [SerializeField] private GameObject _pauseMenu;
    [SerializeField] private Button _pauseButton;
    [SerializeField] private Button _resumeButton;
    [SerializeField] private Button _restartButton;
    [SerializeField] private Button _exitButton;

    private void Start()
    {
        _pauseButton.onClick.AddListener(Pause);
        _resumeButton.onClick.AddListener(Resume);
        _restartButton.onClick.AddListener(Restart);
        _exitButton.onClick.AddListener(Exit);
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        _userInterface.SetActive(false);
        _pauseMenu.SetActive(true);
    }

    private void Resume()
    {
        Time.timeScale = 1f;
        _userInterface.SetActive(true);
        _pauseMenu.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
