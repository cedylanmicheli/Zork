using System.Collections;
using TMPro;
using UnityEngine;
using Zork;
using Newtonsoft.Json;

public class GameManager : MonoBehaviour
{
    [Header("Services")]
    [SerializeField]
    private string GameFilename = "Zork";

    [SerializeField]
    private UnityInputService InputService;
    
    [SerializeField]
    private UnityOutputService OutputService;

    [Header("Text")]
    [SerializeField]
    private TextMeshProUGUI LocationText;

    [SerializeField]
    private TextMeshProUGUI MoveText;

    [SerializeField]
    private TextMeshProUGUI ScoreText;


    public void Start()
    {
        TextAsset gameTextAsset = Resources.Load<TextAsset>(GameFilename);
         _game = JsonConvert.DeserializeObject<Game>(gameTextAsset.text);

        Assert.IsNotNull(_game);
        _game.Initialize(InputService, OutputService);


        _game.Player.LocationChanged += (sender, e) => LocationText.text = e.NewLocation != null ? e.NewLocation.Name : "Unknown";
        _game.Player.ScoreChanged += (sender, e) => ScoreText.text = $"Score: {e}";
        _game.Player.MovesChanged += (sender, e) => MoveText.text = $"Moves: {e}";

        LocationText.text = _game.Player.Location.Name;
        InputService.InputField.Select();
        InputService.InputField.ActivateInputField();
    }

    private void Player_LocationChanged(object sender, LocationChangedEventArgs e)
    {
        LocationText.text = e.NewLocation?.Name;
    }


    private void Update()
    {
        if (Input.GetKey(KeyCode.Return) && string.IsNullOrEmpty(InputService.InputField.text) == false)
        {
            OutputService.WriteLine($"> {InputService.InputField.text}");
            InputService.ProcessInput();
            OutputService.WriteLine(string.Empty);

            InputService.InputField.Select();
            InputService.InputField.ActivateInputField();
        }

        if(_game.IsRunning == false)
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
    }

    private Game _game;
}
