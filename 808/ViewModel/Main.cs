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
                        return db.Query<string>("SpVTASBarCodeGenerator",
                            new { option = "GetFamilies" },
                            commandType: CommandType.StoredProcedure).ToList();
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
                        return db.Query<string>("SpVTASBarCodeGenerator",
                            new { option = "GetLines", family = familyFromClient },
                            commandType: CommandType.StoredProcedure).ToList();
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
                        return db.Query<Article>("SpVTASBarCodeGenerator",
                            new { option = "GetByFamAndLine", family = familyFromClient, line = lineFromClient },
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
                        return db.Query<Article>("SpVTASBarCodeGenerator",
                            new { option = "GetByCode", code = codeFromClient},
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
                MessageBox.Show(ex.ToString(), "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public static void SetDataGridView(GunaDataGridView dgv)
        {
            dgv.Columns["Code"].ReadOnly = true;
            dgv.Columns["Name"].ReadOnly = true;
            dgv.Columns["Family"].ReadOnly = true;
            dgv.Columns["Line"].ReadOnly = true;

            dgv.Columns["Code"].HeaderText = "Artículo";
            dgv.Columns["Name"].HeaderText = "Descripción";
            dgv.Columns["Family"].HeaderText = "Familia";
            dgv.Columns["Line"].HeaderText = "Línea";
            dgv.Columns["Checked"].HeaderText = "";
        }
    }
}
