using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public AudioSource audioSource;

    private void Awake()
    {
        UnityEngine.Object.DontDestroyOnLoad(this);
    }

    private void Start()
    {
        ResetVolume();
    }

    public void LowerVolume()
    {
        audioSource.volume = 0.1f;
    }

    public void ResetVolume()
    {
        audioSource.volume = 0.5f;
    }

}
