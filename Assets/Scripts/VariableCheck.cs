using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class VariableCheck : MonoBehaviour
{
    public int sceneNum;
    public int upgMH;
    public int upgHeal;
    public int upgAtk;
    public int enemyMaxHP;
    public int enemyAtk;

    public AudioClip upgradeSnd;
    public AudioClip loseSnd;
    public AudioClip winSnd;
    public AudioClip buttonSnd;
    public AudioSource audioSource;

    // Start is called before the first frame update
    public void Start()
    {
        InitializeVariables();
    }

    public void LoseSound()
    {
        audioSource.PlayOneShot(loseSnd);
    }

    public void WinSound()
    {
       audioSource.PlayOneShot(winSnd);
    }

    public void InitializeVariables()
    {
        upgMH = 0;
        upgHeal = 0;
        upgAtk = 0;
        sceneNum = 1;
        enemyMaxHP = 20;
        enemyAtk = 5;
    }

    public void Awake()
    {
        UnityEngine.Object.DontDestroyOnLoad(this);
    }

    public void PlayGame()
    {
        if(sceneNum != 1)
        {
            audioSource.PlayOneShot(upgradeSnd, 0.7F);
        }
        else
        {
            ButtonSound();
        }
        SceneManager.LoadScene("Battle");
    }

    public void ButtonSound()
    {
        audioSource.PlayOneShot(buttonSnd);
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        upgMH = data.playerMaxHP;
        upgHeal = data.playerHeal;
        upgAtk = data.playerAtk;
        sceneNum = data.level;
        enemyMaxHP = data.enemyMaxHP;
        enemyAtk = data.enemyAtk;

        SceneManager.LoadScene("Battle");
    }
}
