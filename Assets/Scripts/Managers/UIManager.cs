using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour 
{
    [SerializeField] WaveSpawner waveCount;

    [SerializeField] GameObject nextLevelPannel;
    [SerializeField] GameObject settingsPannel;
    [SerializeField] GameObject settingsButton;

    

    private void Start()
    {
        nextLevelPannel.SetActive(false);
        settingsPannel.SetActive(false);
    }

    public void PlayAgainButton() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void NextLevelButton() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void HomeButton() 
    {
        SceneManager.LoadScene(0);
    }
    public void XButton() 
    {
        Time.timeScale = 1f;
        waveCount.waveCountText.text = waveCount.waveCount.ToString();
    }
    public void LevelsButton() 
    {
        SceneManager.LoadScene(1);
    }
    public void SettingsButton()
    {
        Time.timeScale = 0f;
        settingsPannel.SetActive(true);
        settingsButton.SetActive(false);
        waveCount.waveCountText.text = "";
    }


}
