using UnityEngine;
using TMPro;

public class DisplayChangedTextContent : MonoBehaviour
{
    public TMP_InputField inputField;
    private TextMeshProUGUI textDisplay;

    void Awake()
    {
        textDisplay = GetComponent<TextMeshProUGUI>();
    }

    public void DISPLAY_NEW_VALUE()
    {
        textDisplay.text = "last entry = '" + inputField.text + "'";
    }
}