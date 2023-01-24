using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAPITraningUI
{
     public class MainViweViweModel
    {
        private ExternalCommandData _commandData;

        public DelegateCommand SelectCommand { get; }

        public MainViweViweModel(ExternalCommandData commandData)
        {
            _commandData = commandData;
            SelectCommand = new DelegateCommand(OneSelectCommand);
        }

        public event EventHandler Closerequest;
        private void RaiseCloseRequest()
        {
            Closerequest?.Invoke(this, EventArgs.Empty);
        }

        private void OneSelectCommand()
        {
            UIApplication uiapp = _commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;

        }
    }
}
