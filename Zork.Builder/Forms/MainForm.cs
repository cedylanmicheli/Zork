using System;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using Zork.Builder.ViewModels;

namespace Zork.Builder
{
    public partial class MainForm : Form
    {
        private Game Game { get; set; }

        private string GameFileName { get; set; }

        private GameViewModel _viewModel;

        public MainForm()
        {
            InitializeComponent();
            UpdateTitle();
            CreateGame();
            
          
            gameViewModelBindingSource.DataSource = _viewModel;
            worldView.ViewModel = _viewModel;
            settingsView.ViewModel = _viewModel;
            gameView.ViewModel = _viewModel;
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateGame();
        }

        private void UpdateTitle()
        {
            string gameFilename = string.IsNullOrEmpty(GameFileName) ? "Untitled" : Path.GetFileNameWithoutExtension(GameFileName);
            Text = $"Zork Builder - {gameFilename}";
        }

        private void CreateGame()
        {
            GameFileName = null;
            Game = new Game(new World(), null);
            _viewModel = new GameViewModel(Game);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _viewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                _viewModel.FullPath = openFileDialog.FileName;
            }
        }

        private void SaveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(GameFileName))
            {
                saveAsToolStripMenuItem.PerformClick();
            }
            else SaveGame();
        }

        private void SaveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                GameFileName = saveFileDialog.FileName;
                UpdateTitle();
                SaveGame();
            }
        }

        private void SaveGame()
        {
            JsonSerializer jsonSerializer = new JsonSerializer() { Formatting = Formatting.Indented };

            using (StreamWriter streamWriter = new StreamWriter(GameFileName))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                jsonSerializer.Serialize(jsonWriter, _viewModel.Game);

            }
        }
    }
}
