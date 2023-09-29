using System;
using System.Windows.Forms;

namespace WinForm.Utilities
{
    public class ExcelExporter
    {
        public static void ExportToExcel(DevExpress.XtraGrid.Views.Grid.GridView gridView, string file)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog()
                {
                    Filter = "Excel |*.xlsx",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    FileName = file
                };
                dialog.ShowDialog();
                gridView.ExportToXlsx(dialog.FileName);
                MessageBox.Show(" Successful ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
