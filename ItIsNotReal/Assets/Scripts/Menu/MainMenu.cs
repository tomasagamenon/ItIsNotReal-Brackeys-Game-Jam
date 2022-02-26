using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject settings;
    public GameObject credits;
    [Header("Main Menu")]
    public TextMeshProUGUI startText;
    public TextMeshProUGUI settingsText;
    public TextMeshProUGUI creditsText;
    public TextMeshProUGUI quitText;
    [Header("Game Menu")]
    public GameObject gameMenu;
    public TextMeshProUGUI gResumeText;
    public TextMeshProUGUI gSettingsText;
    public TextMeshProUGUI gMenuText;
    [Header("Settings")]
    [SerializeField]private TextMeshProUGUI _fovValue;
    [SerializeField]private TextMeshProUGUI _sensibilityValue;
    [SerializeField]private TextMeshProUGUI _masterValue;
    [SerializeField]private TextMeshProUGUI _musicValue;
    [SerializeField]private TextMeshProUGUI _audioValue;
    [SerializeField] private Slider _fovSlider;
    [SerializeField] private Slider _sensibilitySlider;
    [SerializeField] private Slider _masterSlider;
    [SerializeField] private Slider _musicSlider;
    [SerializeField] private Slider _audioSlider;
    [SerializeField] private Toggle _fullScreenToggle;
    [SerializeField] private Toggle _headBobToggle;
    [SerializeField] private Toggle _blurToggle;
    private Color white = Color.white;
    private Color black = Color.black;
    public void Play()
    {
        if (settings.activeInHierarchy)
            ToggleSettings();
        else if (credits.activeInHierarchy)
            ToggleCredits();
        startText.color = black;
        SceneManager.LoadScene(2);
    }
    public void Resume()
    {
        if (settings.activeInHierarchy)
            ToggleSettings();
        else if (credits.activeInHierarchy)
            ToggleCredits();
        gameMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void ToggleMenu()
    {
        if (!gameMenu.activeInHierarchy)
        {
            gameMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
            //pausar cosas de algun modo
        }
        else
        {
            if (settings.activeInHierarchy)
                ToggleSettings();
            gameMenu.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            //despausar cosas
        }

    }
    public void ToggleSettings()
    {
        if (credits.activeInHierarchy)
            ToggleCredits();
        if (!settings.activeInHierarchy)
        {
            settings.SetActive(true);
            settingsText.color = black;
            gSettingsText.color = black;
        }
        else
        {
            settings.SetActive(false);
            settingsText.color = white;
            gSettingsText.color = white;
        }
    }
    public void ToggleCredits()
    {
        if (settings.activeInHierarchy)
            ToggleSettings();
        if (!credits.activeInHierarchy)
        {
            credits.SetActive(true);
            creditsText.color = black;
        }
        else
        {
            credits.SetActive(false);
            creditsText.color = white;
        }
    }
    public void QuitToMenu()
    {
        if (settings.activeInHierarchy)
            ToggleSettings();
        else if (credits.activeInHierarchy)
            ToggleCredits();
        gMenuText.color = black;
        Debug.Log("Quit to Menu");
    }
    public void Quit()
    {
        if (settings.activeInHierarchy)
            ToggleSettings();
        else if (credits.activeInHierarchy)
            ToggleCredits();
        quitText.color = black;
        gMenuText.color = black;
        Application.Quit();
    }
    public void FovUpdate(float value)
    {
        _fovValue.text = (value + 20).ToString();
    }
    public void SensibilityUpdate(float value)
    {
        _sensibilityValue.text = value.ToString("N2");
    }
    public void MasterUpdate(float value)
    {
        _masterValue.text = (value + 80).ToString();
    }
    public void MusicUpdate(float value)
    {
        _musicValue.text = (value + 80).ToString();
    }
    public void AudioUpdate(float value)
    {
        _audioValue.text = (value + 80).ToString();
    }
    public void FullscreenUpdate(bool value)
    {
        _fullScreenToggle.isOn = value;
    }
    public void HeadBobUpdate(bool value)
    {
        _headBobToggle.isOn = value;
    }
    public void BlurUpdate(bool value)
    {
        _blurToggle.isOn = value;
    }
    public void MasterSlider(float value)
    {
        _masterSlider.value = value;
    }
    public void MusicSlider(float value)
    {
        _musicSlider.value = value;
    }
    public void AudioSlider(float value)
    {
        _audioSlider.value = value;
    }
    public void FovSlider(float value)
    {
        _fovSlider.value = value;
    }
    public void SensibilitySlider(float value)
    {
        _sensibilitySlider.value = value;
    }
}
