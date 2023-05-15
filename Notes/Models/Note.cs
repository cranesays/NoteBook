namespace Notes.Models
{
    internal class Note
    {
        public string FileName { get; set; } 
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public void Save() =>
            File.WriteAllText(System.IO.Path.Combine(FileSystem.AppDataDirectory, FileName), Text);
        public void Delete() =>
            File.Delete(System.IO.Path.Combine(FileSystem.AppDataDirectory, FileName));

        public Note()
        {
            FileName = $"{Path.GetRandomFileName()}.notes.txt";
            Date = DateTime.Now;
            Text = "";
        }

        public static Note Load(string filename)//加载单个笔记，可以使用静态方法，不需要调用类实体
        {
            filename = System.IO.Path.Combine(FileSystem.AppDataDirectory, filename);

            if (!File.Exists(filename))
                throw new FileNotFoundException("Unable to find file on local storage.", filename);

            return
                new()
                {
                    FileName = Path.GetFileName(filename),
                    Text = File.ReadAllText(filename),
                    Date = File.GetLastWriteTime(filename)
                };
        }

        public static IEnumerable<Note> LoadAll()//打开所有笔记（用于在目录页显示）
        {
            // Get the folder where the notes are stored.
            string appDataPath = FileSystem.AppDataDirectory;

            // Use Linq extensions to load the *.notes.txt files.
            return Directory

                    // Select the file names from the directory
                    .EnumerateFiles(appDataPath, "*.notes.txt")

                    // Each file name is used to load a note
                    .Select(filename => Note.Load(Path.GetFileName(filename)))

                    // With the final collection of notes, order them by date
                    .OrderByDescending(note => note.Date);
        }
    }
}
