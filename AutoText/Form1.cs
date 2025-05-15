namespace AutoText;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        this.TopMost = true;
        this.MaximizeBox = false;
    }

    private void BtnWrite_Click(object sender, EventArgs e)
    {
        string texto = string.Empty;

        Task.Delay((int)numericUpDown1.Value * 1000).Wait();

        if (!string.IsNullOrEmpty(txtText.Text))
        {
            texto = txtText.Text;
        }

        if (chkEnter.Checked)
        {
            texto += "{ENTER}";
        }

        SendKeys.SendWait(texto);
    }

    private void chkPasswordType_CheckedChanged(object sender, EventArgs e) 
        => txtText.UseSystemPasswordChar = chkHidePass.Checked;
}