using BusinessLayer;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace UserInterface
{
    public static class GlobalSettings
    {
        public static clsUsers CurrentUser;

      
        public static void LoggingAnException(string SourceName,string ExceptionDetails)
        {
            if (!EventLog.SourceExists(SourceName))
            {
                EventLog.CreateEventSource(SourceName,"Application");
            }
            EventLog.WriteEntry(SourceName, ExceptionDetails,EventLogEntryType.Error);
        }
     
        public static void CloseAllFormsAndReturnToLoginForm()
        {
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {

                if (form != LogInForm.instance)
                {
                    form.Close();
                }
            }
            LogInForm.instance.Show();
        }

    }

}
