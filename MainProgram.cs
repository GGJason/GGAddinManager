using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace GGJason
{
    
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class manager : IExternalCommand
    {
        public Result Execute(ExternalCommandData data, ref string msg, ElementSet elements)
        {
            main form = new main(data,ref msg,elements);
            form.Show();
            return Result.Succeeded;
            
        }
    }
}/* [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]

     public class GGAddin : IExternalApplication
     {
         public Result OnStartup(UIControlledApplication application)
         {
             string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).ToString().Substring(6);

             RibbonPanel ribbonPanel = application.CreateRibbonPanel("Addin Manager");
             PushButton pushButton = ribbonPanel.AddItem(new PushButtonData("Addin Manager mad by GGJason. Visit http://revit.ggjason.tw for more infomation.", "Manage", path+@"\GGAddinManager.dll", "GGJason.manager")) as PushButton;
             return Result.Succeeded;
         }
         public Result OnShutdown(UIControlledApplication application)
         {
             return Result.Succeeded;
         }
     }*/
