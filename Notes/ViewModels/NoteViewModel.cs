using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace Notes.ViewModels;

internal class NoteViewModel : ObservableObject, IQueryAttributable
{
    private Models.Note _note;
    public ICommand SaveCommand { get; private set; }
    public ICommand DeleteCommand { get; private set; }


    void IQueryAttributable.ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.ContainsKey("load"))
        {
            _note = Models.Note.Load(query["load"].ToString());
            RefreshProperties();
        }
    }
    public void Reload()
    {
        _note = Models.Note.Load(_note.FileName);
        RefreshProperties();
    }

    private void RefreshProperties()
    {
        OnPropertyChanged(nameof(Text));
        OnPropertyChanged(nameof(Date));
    }
    /*方法 Reload 是一种帮助程序方法，用于刷新后备模型对象，从设备存储重新加载它

方法RefreshProperties是另一种帮助程序方法，用于确保绑定到此对象的任何订阅者都会收到 和 Date 属性已更改的通知Text。 
    由于基础模型 (_note 在导航期间加载注释时字段) 更改， Text 因此 和 Date 属性实际上不会设置为新值。 
    由于这些属性不是直接设置的，因此不会通知附加到这些属性的任何绑定，因为 OnPropertyChanged 不会为每个属性调用 。
    RefreshProperties 确保刷新到这些属性的绑定。*/

    public NoteViewModel()
    {
        _note = new Models.Note();
        SaveCommand = new AsyncRelayCommand(Save);
        DeleteCommand = new AsyncRelayCommand(Delete);
    }

    public NoteViewModel(Models.Note note)
    {
        _note = note;
        SaveCommand = new AsyncRelayCommand(Save);
        DeleteCommand = new AsyncRelayCommand(Delete);
    }


    public string Text
    {
        get => _note.Text;
        set
        {
            if (_note.Text != value)
            {
                _note.Text = value;
                OnPropertyChanged();
            }
        }
    }

    public DateTime Date => _note.Date;

    public string Identifier => _note.FileName;//对于属性， => 语法将创建一个仅获取属性，其中 右侧的 => 语句必须计算为要返回的值。
    private async Task Save()
    {
        _note.Date = DateTime.Now;
        _note.Save();
        await Shell.Current.GoToAsync($"..?saved={_note.FileName}");
    }

    private async Task Delete()
    {
        _note.Delete();
        await Shell.Current.GoToAsync($"..?deleted={_note.FileName}");
    }
}