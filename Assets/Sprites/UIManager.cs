using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public bool mbPause = false;
    public AudioMixer mixer;
    [SerializeField] Button mPauseBtn;
    public Slider mVolumeSlider;
        
    // Start is called before the first frame update
    void Start()
    {
        mPauseBtn.onClick.AddListener(GamePause);
        mVolumeSlider.onValueChanged.AddListener(GameVolume);
    }
    public  void  GamePause()
    {
        Debug.Log("button clicked...");
        if(!mbPause )
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
         mbPause = !mbPause;
    }
    public void GameVolume(float fVolume)
    {
        mixer.SetFloat("MasterVolume", fVolume);
        //Debug.Log("");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
