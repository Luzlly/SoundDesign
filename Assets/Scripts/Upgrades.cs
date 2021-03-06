using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Upgrades : MonoBehaviour
{
    
    private VariableCheck varCheck;
    private DontDestroy music;
    public Text bottomText;

    public void Start()
    {
        varCheck = GameObject.Find("Variables").GetComponent<VariableCheck>();
        music = GameObject.Find("Music").GetComponent<DontDestroy>();

        music.LowerVolume();
    }

    public void MaxHealth()
    {
        varCheck.upgMH += 5;
        varCheck.PlayGame();
        Debug.Log("Loaded Scene: " + varCheck.sceneNum);
    }

    public void Healing()
    {
        varCheck.upgHeal += 5;
        varCheck.PlayGame();
        Debug.Log("Loaded Scene: " + varCheck.sceneNum);
    }

    public void Attack()
    {
        varCheck.upgAtk += 2;
        Debug.Log("Increased Atk by 2, It is now" + varCheck.upgAtk);
        varCheck.PlayGame();
        Debug.Log("Loaded Scene: " + varCheck.sceneNum);
    }


    public void HoverAtk()
    {
        bottomText.text = "Increases Attack Power by 2";
    }

    public void HoverMH()
    {
        bottomText.text = "Increases Maximum HP by 5";
    }

    public void HoverHealing()
    {
        bottomText.text = "Increases Healing Potency by 5";
    }

    public void HoverExit()
    {
        bottomText.text = "You Won!!" + "\nChoose your Upgrade!";
    }
}
