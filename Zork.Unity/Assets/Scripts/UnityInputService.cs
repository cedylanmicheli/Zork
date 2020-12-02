using Zork;
using UnityEngine;
using System;
using TMPro;

public class UnityInputService : MonoBehaviour, IInputService
{
    public TMP_InputField InputField;
    
    public event EventHandler<string> InputRecieved;

    public void ProcessInput()
    {
        Assert.IsNotNull(InputField);
        Assert.IsFalse(string.IsNullOrEmpty(InputField.text));

        InputRecieved?.Invoke(this, InputField.text);

        InputField.text = string.Empty;
    }
}
