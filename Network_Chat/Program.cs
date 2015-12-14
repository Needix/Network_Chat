using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Network_Chat.ProjectSRC.Controller;
using Network_Chat.ProjectSRC.GUI;

namespace Network_Chat {
    static class Program {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new DebugContext());
        }
    }
}
