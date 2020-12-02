using UnityEngine;
using Zork;
using TMPro;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using System.Linq;

public class UnityOutputService : MonoBehaviour, IOutputService
{
    [SerializeField]
    private TextMeshProUGUI TextLinePrefab;
    [SerializeField]
    private Image NewLinePrefab;

    [SerializeField]
    [Range(10, 1000)]
    private int MaxEntries;

    [SerializeField]
    private Transform OutputTextContainer;

    private static readonly string[] LineDelimiters = { "\n" };
    private static List<GameObject> _entries;

    public UnityOutputService() =>  _entries = new List<GameObject>(MaxEntries);
  

    public void Write(string value) => WriteLine(value);

    public void Write(object value) => WriteLine(value.ToString());

    public void WriteLine(string value)
    {
        var lines = value.Split(LineDelimiters, StringSplitOptions.None);

        foreach (string line in lines)
        {

            if(_entries.Count >= MaxEntries)
            {
                var entry = _entries.First();
                Destroy(entry);
                _entries.Remove(entry);
            }

            if (string.IsNullOrWhiteSpace(line))
            {
                WriteNewLine();
            }
            else WriteTextLine(line);

            
        }

        WriteNewLine();

    }

    public void WriteLine(object value)
    {
        WriteLine(value.ToString());
    }

    private void WriteTextLine(string value)
    {
        var textLine = Instantiate(TextLinePrefab, OutputTextContainer);
        textLine.text = value;
        _entries.Add(textLine.gameObject);
    }

    private void WriteNewLine()
    {
        var newLine = Instantiate(NewLinePrefab, OutputTextContainer);
        _entries.Add(newLine.gameObject);
    }
}
