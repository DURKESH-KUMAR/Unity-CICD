using UnityEngine;
using UnityEngine.UI;

public class ValueController : MonoBehaviour
{
    [SerializeField] private Text valueText;

    public void Increase()
    {
        int value = int.Parse(valueText.text);
        value++;
        valueText.text = value.ToString();
    }

    public void Decrease()
    {
        int value = int.Parse(valueText.text);
        value--;
        valueText.text = value.ToString();
    }
}