using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioMenu : MonoBehaviour
{
    [SerializeField] GameObject audioMenu;
    [SerializeField] GameObject openAudioSettingButton;

    public void OpenAudioSetting()
    {
        AudioManager.Instance.PlaySFX("Click");
        audioMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void CloseAudioSetting()
    {
        AudioManager.Instance.PlaySFX("Click");
        audioMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}
