using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private GameObject _pauseUI;

    [SerializeField] private Button _backBtn;
    [SerializeField] private Button _shopBtn;
    [SerializeField] private Button _restartBtn;
    [SerializeField] private Button _resumeBtn;

    [SerializeField] private Button _pauseBtn;
    private void Start()
    {
        _pauseUI.SetActive(false);
        Time.timeScale = 1f;

        _pauseBtn.onClick.AddListener(() => Pause());
        _resumeBtn.onClick.AddListener(() => Pause());
        _backBtn.onClick.AddListener(() => GoToMainMenu());
        _shopBtn.onClick.AddListener(() => GoToMainMenu());
        _restartBtn.onClick.AddListener(() => Restart());
    }
    private void Pause()
    {
        if (Time.timeScale == 1f)
        {
            Time.timeScale = 0f;
            _pauseUI.SetActive(true);
        }

        else
        {
            Time.timeScale = 1f;
            _pauseUI.SetActive(false);
        }
    }
    private void Restart()
    {
        UnityEngine.SceneManagement.Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
    private void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
