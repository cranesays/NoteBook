namespace Notes.Views;

//[QueryProperty(nameof(ItemId), nameof(ItemId))]//����������Ŀ¼ҳ������ID
public partial class NotePage : ContentPage
{
    public NotePage()
    {
        InitializeComponent();
    }

    //string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");//ƴ��·������������Ŀ¼��notes.txt�ļ�//�޸�ģ�ͺ󣬸ô��Ѳ����ɱ���ʹ��
    /*
    public string ItemId
    {
        set { LoadNote(value); }
    }
    public NotePage()
	{
		InitializeComponent();
        //if (File.Exists(_fileName))
          //  TextEditor.Text = File.ReadAllText(_fileName);//��������ļ������ȡ����


        string appDataPath = FileSystem.AppDataDirectory;
        string randomFileName = $"{Path.GetRandomFileName()}.notes.txt";

        LoadNote(Path.Combine(appDataPath, randomFileName));
    }
    /*
    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        // Save the file.
        File.WriteAllText(_fileName, TextEditor.Text);//����ȫ������
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        // Delete the file.
        if (File.Exists(_fileName))
            File.Delete(_fileName);

        TextEditor.Text = string.Empty;
    }

    //���رʼ�
    private void LoadNote(string fileName)
    {
        Models.Note noteModel = new Models.Note();
        noteModel.FileName = fileName;

        if (File.Exists(fileName))
        {
            noteModel.Date = File.GetCreationTime(fileName);
            noteModel.Text = File.ReadAllText(fileName);
        }

        BindingContext = noteModel;
    }

    private async void SaveButton_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.Note note)
            File.WriteAllText(note.FileName, TextEditor.Text);

        await Shell.Current.GoToAsync("..");
    }

    private async void DeleteButton_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.Note note)
        {
            // Delete the file.
            if (File.Exists(note.FileName))
                File.Delete(note.FileName);
        }

        await Shell.Current.GoToAsync("..");
    }
    */
}