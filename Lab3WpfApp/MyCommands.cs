using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab3WpfApp
{
    class MyCommands
    {
        public static RoutedUICommand Exit { get; set; }
        static MyCommands ()
        {
            //действие            Exit = new RoutedCommand();

            //коллекция жестов для горячих клавиш
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.T, ModifierKeys.Control, "Ctrl+T"));
            //горячая клавиша
            Exit = new RoutedUICommand("Выход", "Exit", typeof (MyCommands), inputs);

        }
    }
}
