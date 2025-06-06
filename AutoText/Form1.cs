using AutoText.SystemTray;

namespace AutoText;

public partial class Form1 : Form
{
    private readonly Dictionary<int, string> values = [];

    public Form1()
    {
        InitializeComponent();
        this.TopMost = true;
        this.MaximizeBox = false;
        SetMainLocation();

        SystemTrayLogic.Initialize(this);
    }

    private async void BtnWrite_Click(object sender, EventArgs e)
    {
        await Task.Delay((int)numericUpDown1.Value * 1000);

        values.TryGetValue(txtCombo.SelectedIndex, out string? texto);

        if (string.IsNullOrEmpty(texto)) return;
        if (chkEnter.Checked)
        {
            texto += "{ENTER}";
        }

        var capsLocked = Control.IsKeyLocked(Keys.CapsLock);
        if (capsLocked)
        {
            texto = "{CAPSLOCK}" + texto;
        }

        SendKeys.SendWait(texto);
    }

    private void chkPasswordType_CheckedChanged(object sender, EventArgs e)
    {
        UpdateComboValues(txtCombo, (index, value) =>
        {
            if (string.IsNullOrWhiteSpace(value)) return;
            txtCombo.Items[index] = chkHidePass.Checked ? new string('*', value.Length) : value;
        });
    }

    private void txtCombo_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter) return;

        var value = txtCombo?.Text?.Trim();
        if (string.IsNullOrWhiteSpace(value) || txtCombo?.Items?.Contains(value) == true || values.ContainsValue(value)) return;

        var hideText = new string('*', value.Length);
        var index = txtCombo?.Items?.Add(chkHidePass.Checked ? hideText : value) ?? null;
        if (index == null) return;

        values.TryAdd(index.Value, value);
        if(txtCombo is not null)
        {
            txtCombo.Text = string.Empty;
        }

        e.Handled = true;
        e.SuppressKeyPress = true;
    }

    private void UpdateComboValues(ComboBox combo, Action<int, string?> action)
    {
        for (int i = 0; i < combo?.Items?.Count; i++)
        {
            if (values.ContainsKey(i)) action?.Invoke(i, values.GetValueOrDefault(i));
        }
    }

    private void SetMainLocation()
    {
        if (Screen.PrimaryScreen == null) return;
        var workingArea = Screen.PrimaryScreen.WorkingArea;
        var x = workingArea.Right - this.Width - 25;
        var y = workingArea.Bottom - this.Height - 25;
        this.StartPosition = FormStartPosition.Manual;
        this.Location = new Point(x, y);
    }
}