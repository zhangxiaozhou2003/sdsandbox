﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TextMesh currentTotTimeDisp;
    public TextMesh penaltiesDisp;
    public bool enabled_timer = false;
    public string racerName;
    public float penalties = 0.0f; //seconds
    public float currentStart = 0.0f; //seconds

    void Awake()
    {   
        if(enabled_timer)
        {
            StartTimer();
        }
        else
        {
            DisableTimer();
        }
    }

    public void StartTimer()
    {
        currentTotTimeDisp.gameObject.SetActive(true);
        penaltiesDisp.gameObject.SetActive(true);
        penalties = 0.0f;
        currentStart = GetTime();
        enabled_timer = true;
    }
    
    public void DisableTimer()
    {
        currentTotTimeDisp.gameObject.SetActive(false);
        penaltiesDisp.gameObject.SetActive(false);
        penalties = 0.0f;
        currentStart = 0.0f;
        enabled_timer = false;
    }
    public void ResetTimer()
    {
        penalties = 0.0f;
        currentStart = GetTime();
        enabled_timer = true;
    }


    float GetTime()
    {
        return Time.time;
    }    
    float GetPenalties()
    {
        return penalties;
    }
    float GetCurrentTime()
    {
        return (GetTime() - currentStart) + GetPenalties();
    }

    public void OnCollideCone(float penalty)
    {   
        if(enabled_timer == false)
            return;

        penalties += penalty;
        if(penaltiesDisp.gameObject.activeSelf){
            float penalties = GetPenalties();
            penaltiesDisp.text = penalties.ToString("00.00");
            Debug.Log("Added penalty");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(enabled_timer == false)
            return;

        if(currentTotTimeDisp.gameObject.activeSelf)
        {
            float currentTime = GetCurrentTime();
            currentTotTimeDisp.text = currentTime.ToString("00.00");
        }
        if(penaltiesDisp.text != penalties.ToString("00.00"))
        {
            penaltiesDisp.text = penalties.ToString("00.00");
        }
    }
}
