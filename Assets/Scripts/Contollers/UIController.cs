using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    #region variables

    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject deathPanel;
    [SerializeField] private GameObject pauseButton;
    [SerializeField] private GameObject coinText;

    #endregion variables

    #region public functions

    public void SetCoinText(string value)
    {
        coinText.GetComponent<TMP_Text>().text = value;
    }

    #endregion public functions
    
    #region Button functions

    public void StartScene(int index) => SceneManager.LoadSceneAsync(index);
    
    public void Exit() => Application.Quit();
    
    public void ResumeScene()
    {
        TimeState(true);
        SwitchButtons(false);
    }

    public void PauseScene()
    {
        TimeState(false);
        SwitchButtons(true);
    }

    public void DeathScene()
    {
        TimeState(false);
        SwitchButtons(true, true);
    }

    private void SwitchButtons(bool value, bool needDeath = false)
    {
        if (needDeath)
        {
            deathPanel.SetActive(value);
        }
        else
            panel.SetActive(value);
        pauseButton.SetActive(!value);
    }

    private void TimeState(bool value)
    {
        Time.timeScale = value == false ? 0f : 1f;
    }

    #endregion Button functions
}
