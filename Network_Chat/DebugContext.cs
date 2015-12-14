using System.Windows.Forms;
using Network_Chat.ProjectSRC.Controller;
using Network_Chat.ProjectSRC.GUI;

namespace Network_Chat {
    public class DebugContext : ApplicationContext {
        public DebugContext() {
            GUIView view = new GUIView();
            GUIController controller = new GUIController(view); //Controller is saved in view as reference
            view.RegisterController(controller);
            view.Visible = true;

#if DEBUG   
            GUIView view2 = new GUIView();
            GUIController controller2 = new GUIController(view2); //Controller is saved in view as reference
            view2.RegisterController(controller2);
            view2.Visible = true;
#endif
        }
    }
}