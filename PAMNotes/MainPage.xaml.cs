

namespace PAMNotes
{
    public partial class MainPage : ContentPage
    {
        string FilePath = Path.Combine(FileSystem.AppDataDirectory, "Notes.txt");
        public MainPage()
        {
            InitializeComponent();
            if (File.Exists(FilePath))
            {
                NoteEditor.Text = File.ReadAllText(FilePath);
            }
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {

            string SaveText = NoteEditor.Text;
            TextLabel.Text = "Arquivo foi salvo em: " + FilePath;
            File.WriteAllText(FilePath, SaveText);
            DisplayAlert("Operação concluida", "Arquivo salvo vom sucesso!", "ok");

        }

        private void DeleteButton_Clicked(object sender, EventArgs e)
        {
            if (File.Exists(FilePath))
            {
                NoteEditor.Text = "";
                TextLabel.Text = "";
                File.Delete(FilePath);
                DisplayAlert("Operação concluida", "Arquivo apagado com sucesso", "ok");
            }
            else
                DisplayAlert("Operação cancelada", "Arquivo não encontrado", "ok");
        }
    }

}
