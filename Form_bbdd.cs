using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visitorApp
{
    public partial class Form_BBDD : Form
    {
        Database miDB = new Database();
        public string id_eliminar = "";
        private string tipo = "";

        //private string id_user;
        public Form_BBDD()
        {
            InitializeComponent();
            lbl_f_final.Visible = false;
            lbl_f_inicio.Visible = false;
            time_inicio.Visible = false;
            time_final.Visible = false;
            btn_modificar.Enabled = false;

        }


        private void chk_Box_filtro_CheckedChanged_1(object sender, EventArgs e)
        {

            if (chk_Box_filtro.Checked)
            {

                lbl_f_final.Visible = true;
                lbl_f_inicio.Visible = true;
                time_inicio.Visible = true;
                time_final.Visible = true;

            }
            else
            {
                lbl_f_final.Visible = false;
                lbl_f_inicio.Visible = false;
                time_inicio.Visible = false;
                time_final.Visible = false;
            }
        }

        private void btn_export_Click_1(object sender, EventArgs e)
        {
            ExportarAExcel();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Form frm_Nuevo = new RegistroNuevo(tipo);
            frm_Nuevo.ShowDialog();
            MostrarTabla(tipo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("el login: " + id_eliminar);
            Console.WriteLine("el tipo: " + tipo);
            if (miDB.DeleteRegistro(id_eliminar, tipo))
            {
                dt.Rows.Remove(dt.CurrentRow);
            }
            else
            {
                MessageBox.Show("No se pudo borrar. ");
            }


        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Form frm_Nuevo = new RegistroModificar(tipo, id_eliminar);
            frm_Nuevo.ShowDialog();
            MostrarTabla(tipo);
        }

        //pnl bbdd
        public void MostrarTabla(string tipo)
        {
            btn_modificar.Enabled = false;
            string time_ini;
            string time_fin;
            string[] arrfecha;
            if (chk_Box_filtro.Checked)
            {
                time_ini = time_inicio.Value.Date.ToString();
                time_fin = time_final.Value.Date.ToString();
                arrfecha = new string[2] { time_ini, time_fin };
            }
            else
            {
                arrfecha = new string[2] { "", "" };
            }
            Console.WriteLine("hey: " + arrfecha[0] + arrfecha[1]);
            DataTable table = new DataTable();
            //string tipo = "visita";
            dt.DataSource = (miDB.LlenarTabla(table, tipo, arrfecha));
            dt.CurrentRow.Selected = false;
        }

        //pnl bbdd
        private void CopiarGrilla()
        {
            dt.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dt.MultiSelect = true;
            dt.SelectAll();
            DataObject dataObj = dt.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);

            dt.MultiSelect = false;
            dt.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
        }

        //pnl bbdd
        private void ExportarAExcel()
        {
            this.CopiarGrilla();

            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object valor = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(valor);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

            MessageBox.Show("Exportación finalizada");
        }

        private void btn_mostrar_visitas_Click(object sender, EventArgs e)
        {
            tipo = "visita";
            MostrarTabla(tipo);
            btn_nuevo.Enabled = false;
        }

        private void btn_mostrar_incidentes_Click(object sender, EventArgs e)
        {
            chk_Box_filtro.Visible = true;
            tipo = "incidente";
            MostrarTabla(tipo);
            btn_nuevo.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tipo = "persona";
            chk_Box_filtro.Checked = false;
            chk_Box_filtro.Visible = false;
            MostrarTabla(tipo);
            btn_nuevo.Enabled = true;
        }

        private void btn_usuarios_Click_1(object sender, EventArgs e)
        {
            tipo = "usuario";
            chk_Box_filtro.Checked = false;
            chk_Box_filtro.Visible = false;
            MostrarTabla(tipo);
            btn_nuevo.Enabled = true;
        }

        private void dt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_modificar.Enabled = true;
            if (tipo == "usuario")
            {
                id_eliminar = dt.Rows[e.RowIndex].Cells["id"].Value.ToString();
                //string firstCellValue = dt.SelectedRows[0].Cells[0].Value;
                //string id_e = dt.SelectedRows.


                Console.WriteLine("cell:" + id_eliminar);
            }
            else if (tipo == "persona")
            {
                id_eliminar = dt.Rows[e.RowIndex].Cells["id"].Value.ToString();
                Console.WriteLine("cell:" + id_eliminar);
            }
            else if (tipo == "incidente")
            {
                id_eliminar = dt.Rows[e.RowIndex].Cells["id"].Value.ToString();
                Console.WriteLine("cell:" + id_eliminar);
            }
            else if (tipo == "visita")
            {
                id_eliminar = dt.Rows[e.RowIndex].Cells["id"].Value.ToString();
                Console.WriteLine("cell:" + id_eliminar);
            }
            else
            {
               
            }

        }


    }
}
