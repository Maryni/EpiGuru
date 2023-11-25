using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    #region variables

    [SerializeField] public GameObject panel;
    [SerializeField] public GameObject pauseButton;
    [SerializeField] public GameObject coinText;

    #endregion variables

    public void SetCoinText(string value)
    {
        coinText.GetComponent<TMP_Text>().text = value;
    }
    
    #region Button functions

    public void StartScene(int index) => SceneManager.LoadSceneAsync(index);
    
    public void Exit() => Application.Quit();
    
    public void ResumeScene()
    {
        Time.timeScale = 1f;
        panel.SetActive(false);
        pauseButton.SetActive(true);
    }

    public void PauseScene()
    {
        Time.timeScale = 0f;
        panel.SetActive(true);
        pauseButton.SetActive(false);
    }

    #endregion Button functions
}
