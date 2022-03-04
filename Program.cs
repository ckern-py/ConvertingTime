using System;

namespace ConvertTime
{
    class Program
    {
        //Satisfies rule: MarkWindowsFormsEntryPointsWithStaThread.
        //added at the request of VS
        [STAThread]
        static void Main(string[] args)
        {
            //Shows the gui for interaction 
            TimeConversionGUI guiForm = new TimeConversionGUI();

            guiForm.ShowDialog();
        }
    }
}
