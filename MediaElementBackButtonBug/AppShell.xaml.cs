﻿namespace MediaElementBackButtonBug
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(PageTwo), typeof(PageTwo));

        }
    }
}
