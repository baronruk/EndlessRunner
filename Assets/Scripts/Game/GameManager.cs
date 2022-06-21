using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _userInterface;
    [SerializeField] private Button _nextLevelButton;
    [SerializeField] private GameObject _winScreen;
    [SerializeField] private TMP_Text _finalscore;
    private GameMenuManager _gameMenuManager;
    private ScoreManager _scoreManager;
    private int _gateCounter;
    
    void OnEnable()
    {
        _scoreManager = FindObjectOfType<ScoreManager>();
        _gameMenuManager = FindObjectOfType<GameMenuManager>();
        _nextLevelButton.onClick.AddListener(_gameMenuManager.Restart);
        _gateCounter = 0;
    }

    void Update()
    {
        if (_gateCounter >= 15) {
            _finalscore.text = _scoreManager.GetFinalScore();
            Time.timeScale = 0f;
            _userInterface.SetActive(false);
            _winScreen.SetActive(true);
        }
    }

    public void UpdateGateCounter()
    {
        _gateCounter += 1;
    }
}
