using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Player;

public class UIManager : MonoBehaviour
{

    [SerializeField] PlayerController player;
    [SerializeField] WaveSpawner waveCount;

    [SerializeField] TextMeshProUGUI infoText;
    [SerializeField] GameObject nextLevelPannel;
    [SerializeField] GameObject settingsPannel;
    [SerializeField] GameObject settingsButton;

    

    private void Start()
    {
        nextLevelPannel.SetActive(false);
        settingsPannel.SetActive(false);
    }
    private void FixedUpdate()
    {
        /*if (player.joystick.Horizontal != 0 || player.joystick.Vertical != 0) 
        {
            Destroy(infoText);
        }*/
        if (player.nextLevel==true)
        {
            Time.timeScale = 0;
            nextLevelPannel.SetActive(true);
            waveCount.waveCountText.text = "";
            
        }
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
