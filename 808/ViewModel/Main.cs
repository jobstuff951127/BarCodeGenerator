using _808.Model;
using _808.Services;
using Dapper;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _808.ViewModel
{
    public class Main
    {
        public async static Task<List<string>> GetFamilies()
        {
            try
            {
                var query = await Task.Run(() =>
                {
                    using (IDbConnection db = Connection.GetConnectionIntelisis())
                    {
                        return db.Query<string>("SpVTASGeneradorCodigoBarras",
                            new { opcion = "GetFamilies" },
                            commandType: CommandType.StoredProcedure).OrderBy(f => f).ToList();
                    }
                });

                return query;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
        public async static Task<List<string>> GetLinesBasedOnFam(string familyFromClient)
        {

            try
            {
                var query = await Task.Run(() =>
                {
                    using (IDbConnection db = Connection.GetConnectionIntelisis())
                    {
                        return db.Query<string>("SpVTASGeneradorCodigoBarras",
                            new { opcion = "GetLines", familia = familyFromClient },
                            commandType: CommandType.StoredProcedure).OrderBy(l => l).ToList();
                    }
                });

                return query;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
           
        }
        public async static Task<List<Article>> GetByFamAndLine(string lineFromClient, string familyFromClient, GunaWinCircleProgressIndicator loader)
        {

            try
            {
                var query = await Task.Run(() =>
                {
                    loader.Invoke(new MethodInvoker(delegate
                    {
                        loader.Show();
                    }));
                    using (IDbConnection db = Connection.GetConnectionIntelisis())
                    {
                        return db.Query<Article>("SpVTASGeneradorCodigoBarras",
                            new { opcion = "GetByFamAndLine", familia = familyFromClient, linea = lineFromClient },
                            commandType: CommandType.StoredProcedure).ToList();
                    }
                });
                if (query.Count == 0)
                {
                    loader.Hide();
                    MessageBox.Show("No hay artículos con esa familia-línea.", "Notificación:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                loader.Hide();
                return query;
            }
            catch (Exception ex)
            {
                loader.Hide();
                MessageBox.Show(ex.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public async static Task<List<Article>> GetByCode(string codeFromClient, GunaWinCircleProgressIndicator loader)
        {

            try
            {
                var query = await Task.Run(() =>
                {
                    loader.Invoke(new MethodInvoker(delegate
                    {
                        loader.Show();
                    }));
                    using (IDbConnection db = Connection.GetConnectionIntelisis())
                    {
                        return db.Query<Article>("SpVTASGeneradorCodigoBarras",
                            new { opcion = "GetByCode", articulo = codeFromClient},
                            commandType: CommandType.StoredProcedure).ToList();
                    }
                });
                if (query.Count == 0)
                {
                    loader.Hide();
                    MessageBox.Show("El código no existe.", "Notificación:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                loader.Hide();
                return query;
            }
            catch (Exception ex)
            {
                loader.Hide();
                MessageBox.Show(ex.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public static void SetDataGridView(GunaDataGridView dgv)
        {
            dgv.Columns["Artículo"].ReadOnly = true;
            dgv.Columns["Descripcion1"].ReadOnly = true;
            dgv.Columns["Familia"].ReadOnly = true;
            dgv.Columns["Linea"].ReadOnly = true;

            dgv.Columns["Descripcion1"].HeaderText = "Descripción";
            dgv.Columns["Linea"].HeaderText = "Línea";
            dgv.Columns["Checked"].HeaderText = "";
            
            dgv.Columns["Checked"].Width = 35;
            dgv.Columns["Cuenta"].Visible = false;
        }
    }
}
