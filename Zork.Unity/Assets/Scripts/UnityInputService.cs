using Zork;
using UnityEngine;
using System;
using TMPro;
using System.Collections.Generic;

public class UnityInputService : MonoBehaviour, IInputService
{
    public TMP_InputField InputField;
    
    public event EventHandler<string> InputRecieved;

    private readonly string[] _commands = new string[] { "north", "south", "east", "west", "look" };
   
    private int commandLocation = 0;
    private int commandLength;

    private void Awake()
    {
        commandLength = _commands.Length;
    }

    public void ProcessInput()
    {
        Assert.IsNotNull(InputField);
        Assert.IsFalse(string.IsNullOrEmpty(InputField.text));

        InputRecieved?.Invoke(this, InputField.text);

        InputField.text = string.Empty;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            InputField.text = _commands[commandLocation];
            if (commandLocation < commandLength - 1) commandLocation++;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            InputField.text = _commands[commandLocation];
            if (commandLocation > 0) commandLocation--;
        }
    }
}
