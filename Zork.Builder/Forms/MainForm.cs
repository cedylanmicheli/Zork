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
        private bool IsGameLoaded
        {
            get => _IsGameLoaded;
            set
            {
                _IsGameLoaded = value;
                tabControl.Enabled = IsGameLoaded;
            }
        }

        private GameViewModel mViewModel;
        private bool _IsGameLoaded;

        public MainForm()
        {
            InitializeComponent();
            UpdateTitle();
            IsGameLoaded = false;
        }

        #region File Menu Strip

        #region Saving Game
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(GameFileName))
            {
                saveAsToolStripMenuItem.PerformClick();
            }
            else SaveGame();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                GameFileName = saveFileDialog.FileName;
                mViewModel.FullPath = GameFileName;
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
                jsonSerializer.Serialize(jsonWriter, mViewModel.Game);

            }
        }
        #endregion Saving Game

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateGame();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                mViewModel = new GameViewModel(Game);
                mViewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                mViewModel.FullPath = openFileDialog.FileName;
                
                BindFields();
                EnableMenus();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion File Menu Strip

        private void UpdateTitle()
        {
           // string gameFilename = "Untitled";
           // if(string.IsNullOrEmpty(GameFileName) == false)
           // {
           //    gameFilename = Path.GetFileNameWithoutExtension(GameFileName);
           //     mViewModel.FullPath = GameFileName;
           // }
            string gameFilename = string.IsNullOrEmpty(GameFileName) ? "Untitled" : Path.GetFileNameWithoutExtension(GameFileName);
            Text = $"Zork Builder - {gameFilename}";
            
        }

        private void CreateGame()
        {
            GameFileName = null;
            Game = new Game(new World(), null);
            mViewModel = new GameViewModel(Game);

            BindFields();
            EnableMenus();
        }

        private void EnableMenus()
        {
            IsGameLoaded = true;
            saveAsToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
        }

        private void BindFields()
        {
            gameViewModelBindingSource.DataSource = mViewModel;
            worldView.ViewModel = mViewModel;
            settingsView.ViewModel = mViewModel;
        }
    }
}
