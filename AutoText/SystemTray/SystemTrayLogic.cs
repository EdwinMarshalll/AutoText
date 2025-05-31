namespace AutoText.SystemTray
{
    public class SystemTrayLogic
    {
        private static SystemTrayLogic? _instance;
        private readonly Form _mainForm;
        private readonly NotifyIcon _notifyIcon;

        public static SystemTrayLogic Instance
        {
            get
            {
                if (_instance == null) throw new InvalidOperationException("The instance has not been initialized yet.");
                return _instance;
            }
        }

        public static SystemTrayLogic Initialize(Form mainForm)
        {
            ArgumentNullException.ThrowIfNull(mainForm);
            _instance ??= new SystemTrayLogic(mainForm);
            return _instance;
        }

        private SystemTrayLogic(Form mainForm)
        {
            _mainForm = mainForm;
            _notifyIcon = new NotifyIcon()
            {
                Icon = Resources.keyboardIcon,
                Visible = true,
                Text = "AutoText",
                ContextMenuStrip = AddMenuStrip()
            };
            RegisterEvents();
            HideWindow(false);
        }

        private ContextMenuStrip AddMenuStrip()
        {
            var menu = new ContextMenuStrip();
            menu.Items.Add("Close", null, (sender, eventArgs) => CloseApplication());
            return menu;
        }

        private void CloseApplication()
        {
            _mainForm.Close();
        }

        private void RegisterEvents()
        {
            _notifyIcon.DoubleClick += (sender, eventArgs) => ShowWindow(false);
            _mainForm.Resize += PreventMinimized;
            _mainForm.FormClosed += (sender, eventArgs) => ClearNotifyIcon();
        }

        private void ClearNotifyIcon()
        {
            _notifyIcon.Visible = false;
            _notifyIcon.Dispose();
        }

        private void PreventMinimized(object? sender, EventArgs eventArgs)
        {
            if (_mainForm.WindowState != FormWindowState.Minimized) return;
            _mainForm.Hide();
        }

        internal void ShowWindow(bool showInTaskbar = true)
        {
            _mainForm.Show();
            _mainForm.WindowState = FormWindowState.Normal;
            _mainForm.ShowInTaskbar = showInTaskbar;
        }

        internal void HideWindow(bool hideMainForm = true)
        {
            _mainForm.ShowInTaskbar = false;
            if (hideMainForm)
            {
                _mainForm.Hide();
                _mainForm.WindowState = FormWindowState.Minimized;
            }
        }
    }
}
