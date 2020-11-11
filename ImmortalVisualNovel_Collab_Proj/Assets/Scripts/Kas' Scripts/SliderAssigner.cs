using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderAssigner : MonoBehaviour
{
    public Slider volume;

    private void Awake()
    {
        volume = GetComponent<Slider>();
        volume.value = SettingsMenu.Instance.volume;
        volume.onValueChanged.AddListener(OnValueChange);
    }

    public void OnValueChange(float value)
    {
        SettingsMenu.Instance.SetLevel(value);
    }
}
