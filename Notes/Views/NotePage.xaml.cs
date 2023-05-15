namespace Notes.Views;

//[QueryProperty(nameof(ItemId), nameof(ItemId))]//创建可以让目录页导航的ID
public partial class NotePage : ContentPage
{
    public NotePage()
    {
        InitializeComponent();
    }

    //string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");//拼接路径，本地数据目录，notes.txt文件//修改模型后，该串已不在由本类使用
    /*
    public string ItemId
    {
        set { LoadNote(value); }
    }
    public NotePage()
	{
		InitializeComponent();
        //if (File.Exists(_fileName))
          //  TextEditor.Text = File.ReadAllText(_fileName);//如果存在文件，则读取数据


        string appDataPath = FileSystem.AppDataDirectory;
        string randomFileName = $"{Path.GetRandomFileName()}.notes.txt";

        LoadNote(Path.Combine(appDataPath, randomFileName));
    }
    /*
    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        // Save the file.
        File.WriteAllText(_fileName, TextEditor.Text);//存入全部文字
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        // Delete the file.
        if (File.Exists(_fileName))
            File.Delete(_fileName);

        TextEditor.Text = string.Empty;
    }

    //加载笔记
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