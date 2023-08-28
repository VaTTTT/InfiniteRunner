using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text _timerDisplay;

    private void Start()
    {

    }

    private void Update()
    {
        _timerDisplay.text = Mathf.Round(Time.timeSinceLevelLoad).ToString();
    }
}
 