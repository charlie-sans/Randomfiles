using UnityEngine;
using UnityEngine.UI;

public class PlaybackBar : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider slider;

    public float minValue = 0f;
    public float maxValue = 1f;

    private bool isDragging;

    void Start()
    {
        slider.minValue = minValue;
        slider.maxValue = maxValue;
    }

    void Update()
    {
        if (!isDragging)
        {
            slider.value = audioSource.time;
        }
    }

    public void OnSliderValueChanged()
    {
        audioSource.time = slider.value;
    }

    public void OnSliderDragStart()
    {
        isDragging = true;
    }

    public void OnSliderDragEnd()
    {
        isDragging = false;
    }
}