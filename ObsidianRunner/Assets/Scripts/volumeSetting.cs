using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumeSetting : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] Slider musicSlider;
    
    [SerializeField] AudioSource musicSource;
    void Start()
    {
        Load();
    }
    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }
    public void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("volume", 1f);
        musicSlider.value = PlayerPrefs.GetFloat("music", 1f);

        AudioListener.volume = volumeSlider.value;

        //if (musicSource != null)
        //    musicSource.volume = musicSlider.value;
    }
    public void Save()
    {
        PlayerPrefs.SetFloat("volume", volumeSlider.value);
        PlayerPrefs.SetFloat("music", musicSlider.value);
        PlayerPrefs.Save();
    }

    //public void ChangeMusic()
    //{
    //        musicSource.volume = musicSlider.value;
    //    //    Save();
    //}
}