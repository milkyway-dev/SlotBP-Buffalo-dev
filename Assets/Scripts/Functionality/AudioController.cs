using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioController : MonoBehaviour
{
    [SerializeField] private AudioListener m_MainAudioListener;
    [SerializeField] private AudioSource m_NormalButton_Audio;
    [SerializeField] private AudioSource m_SpinButton_Audio;
    [SerializeField] private AudioSource m_Spinning_Audio;
    [SerializeField] private AudioSource m_BG_Music;
    [SerializeField] private AudioSource m_FreeSpinEnc_Sound;
    [SerializeField] private AudioSource m_BigWin_Sound;
    [SerializeField] private AudioSource m_MegaWin_Sound;
    [SerializeField] private AudioSource m_GoldCount_Audio;

    private void Start()
    {
        if (m_BG_Music) m_BG_Music.Play();
    }

    internal void CheckFocusFunction(bool focus)
    {
        m_MainAudioListener.enabled = focus;
        //if (!focus)
        //{
        //    m_MainAudioListener.enabled = focus;
        //}
        //else
        //{
        //    m_MainAudioListener.enabled = focus;
        //}
    }

    internal void PlayNormalButton()
    {
        if(m_MainAudioListener.enabled) m_NormalButton_Audio.Play();
    }

    internal void PlaySpinButton()
    {
        if (m_MainAudioListener.enabled) m_SpinButton_Audio.Play();
    }

    internal void PlayFreeSpin_Enc()
    {
        if (m_MainAudioListener.enabled) m_FreeSpinEnc_Sound.Play();
    }

    internal void PlayGold_Enc()
    {
        if (m_MainAudioListener.enabled) m_GoldCount_Audio.Play();
    }

    internal void PlaySpinAudio(bool m_play_pause)
    {
        switch (m_play_pause)
        {
            case true:
                if (m_MainAudioListener.enabled) m_Spinning_Audio.Play();
                break;
            case false:
                if (m_MainAudioListener.enabled) m_Spinning_Audio.Stop();
                break;
        }
    }

    internal void PlayWin(Sound win)
    {
        switch (win)
        {
            case Sound.BigWin:
                if (m_MainAudioListener.enabled) m_BigWin_Sound.Play();
                break;
            case Sound.MegaWin:
                if (m_MainAudioListener.enabled) m_MegaWin_Sound.Play();
                break;
        }
    }

    internal void MuteUnmute(Sound sound, bool toggle, bool config)
    {
        switch (sound)
        {
            case Sound.Music:
                m_BG_Music.mute = toggle;
                break;
            case Sound.Sound:
                m_NormalButton_Audio.mute = toggle;
                m_SpinButton_Audio.mute = toggle;
                m_Spinning_Audio.mute = toggle;
                m_GoldCount_Audio.mute = toggle;
                m_BigWin_Sound.mute = toggle;
                m_MegaWin_Sound.mute = toggle;
                m_FreeSpinEnc_Sound.mute = toggle;
                break;
            case Sound.All:
                m_NormalButton_Audio.mute = toggle;
                m_SpinButton_Audio.mute = toggle;
                m_Spinning_Audio.mute = toggle;
                m_GoldCount_Audio.mute = toggle;
                m_BigWin_Sound.mute = toggle;
                m_MegaWin_Sound.mute = toggle;
                m_FreeSpinEnc_Sound.mute = toggle;
                m_BG_Music.mute = toggle;
                break;
        }
    }
}

public enum Sound
{
    BigWin,
    MegaWin,
    //Mute or Unmute Ids
    All,
    Music,
    Sound,
}
