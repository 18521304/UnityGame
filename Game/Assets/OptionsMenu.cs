using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using System.Linq;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public Dropdown resolutionDropdown;

    int minus = 0;
    Resolution[] resolutions;
    private void Start()
    {
        //resolutions = Screen.resolutions;
        resolutions = Screen.resolutions.Select(resolution => new Resolution 
            { width = resolution.width, height = resolution.height }).Distinct().ToArray();
        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();
        int currentRSIndex = 0;
        
        for (int i = 0; i < resolutions.Length; i++)
        {
            if (resolutions[i].width <= 600 && resolutions[i].height <= 400)
            {
                minus++;
                Debug.Log("minus: " + minus);
                Debug.Log("i: " + i);
                continue;
            }
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);
            //if (resolutions[i].width == Screen.currentResolution.width &&
            //    resolutions[i].height == Screen.currentResolution.height)
            //{
            //    currentRSIndex = i;
            //}
            if (resolutions[i].width == Screen.width &&
                resolutions[i].height == Screen.height)
            {
                currentRSIndex = i - minus + 1;
                
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentRSIndex /*- minus*/;
        resolutionDropdown.RefreshShownValue();
        

    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex + minus - 1];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
         
    }
    public void SetVolume(float volume)
    {
        //audioMixer.SetFloat("volume", Mathf.Log10(volume) * 20);
        audioMixer.SetFloat("volume",volume);
        //first volume is the parameter of audioMixer
        //second volume is variable of this function 
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
        
    }

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
}
