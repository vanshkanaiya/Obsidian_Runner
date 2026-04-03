using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumeSetting : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] Slider musicSlider;
    // Start is called before the first frame update
    void Start()
    {
        load();
    }

    public void changeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        save();
    }
    public void load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("volume", 1);
    }
    public void save()
    {
        PlayerPrefs.SetFloat("volume", volumeSlider.value);
    }
}