using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
using Microsoft.Extensions.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Modbus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ModbusClient client = new ModbusClient();

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvRead.ReadOnly = true;
            dgvRead.ColumnCount = 3;
            dgvRead.Columns[0].HeaderText = "Address";
            dgvRead.Columns[1].HeaderText = "Value";
            dgvRead.Columns[2].HeaderText = "Time";
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            client.IPAddress = tbxIpAddress.Text;
            client.Port = Convert.ToInt32(tbxPort.Text);
            try
            {
                client.Connect();
                MessageBox.Show("Connected");
                lblStatus.Text = "Connected";
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Exception writing values to Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                client.Disconnect();
                MessageBox.Show("Disconnected");
                lblStatus.Text = "Disconnected";
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Exception writing values to Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadHolding_Click(object sender, EventArgs e)
        {
            try
            {
                int[] values;
                values = client.ReadHoldingRegisters(int.Parse(tbxRegister.Text) - 1, 1);
                tbxValue.Text = null;

                DataGridViewRow row = (DataGridViewRow)dgvRead.Rows[0].Clone();
                row.Cells[0].Value = tbxRegister.Text;
                row.Cells[1].Value = values[0].ToString();
                row.Cells[2].Value = DateTime.Now.ToString();
                dgvRead.Rows.Add(row);
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Exception writing values to Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadInputRegisters_Click(object sender, EventArgs e)
        {
            try
            {
                int[] values;
                values = client.ReadInputRegisters(int.Parse(tbxRegister.Text), 1);
                tbxValue.Text = values[0].ToString();

                DataGridViewRow row = (DataGridViewRow)dgvRead.Rows[0].Clone();
                row.Cells[0].Value = tbxRegister.Text;
                row.Cells[1].Value = values[0].ToString();
                row.Cells[2].Value = DateTime.Now.ToString();
                dgvRead.Rows.Add(row);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Exception writing values to Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadCoil_Click(object sender, EventArgs e)
        {
            try
            {
                bool[] values;
                values = client.ReadCoils(int.Parse(tbxRegister.Text) - 1, 1);
                tbxValue.Text = null;

                DataGridViewRow row = (DataGridViewRow)dgvRead.Rows[0].Clone();
                row.Cells[0].Value = tbxRegister.Text;
                row.Cells[1].Value = values[0].ToString();
                row.Cells[2].Value = DateTime.Now.ToString();
                dgvRead.Rows.Add(row);
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Exception writing values to Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadDiscreteInputs_Click(object sender, EventArgs e)
        {
            try
            {
                bool[] values;
                values = client.ReadDiscreteInputs(int.Parse(tbxRegister.Text), 1);

                DataGridViewRow row = (DataGridViewRow)dgvRead.Rows[0].Clone();
                row.Cells[0].Value = tbxRegister.Text;
                row.Cells[1].Value = values[0].ToString();
                row.Cells[2].Value = DateTime.Now.ToString();
                dgvRead.Rows.Add(row);
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Exception writing values to Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWriteHolding_Click(object sender, EventArgs e)
        {
            try
            {
                var result = Convert.ToInt32(tbxRegister.Text);
                client.WriteSingleRegister(int.Parse(tbxRegister.Text) - 1, int.Parse(tbxValue.Text));

                int[] values = client.ReadHoldingRegisters(int.Parse(tbxRegister.Text) - 1, 1);
                DataGridViewRow row = (DataGridViewRow)dgvRead.Rows[0].Clone();
                row.Cells[0].Value = result;
                row.Cells[1].Value = values[0];
                row.Cells[2].Value = DateTime.Now.ToString();
                dgvRead.Rows.Add(row);
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Exception writing values to Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWriteCoil_Click(object sender, EventArgs e)
        {

            try
            {
                if (tbxValue.Text == "0" || tbxValue.Text == "false" || tbxValue.Text == "False")
                {
                    client.WriteSingleCoil(int.Parse(tbxRegister.Text) - 1, false);
                    var result = client.ReadCoils(int.Parse(tbxRegister.Text), 1);

                    dgvRead.Rows.Add(tbxRegister.Text, "False");

                }

                else if (tbxValue.Text == "1" || tbxValue.Text == "true" || tbxValue.Text == "True")
                {
                    client.WriteSingleCoil(int.Parse(tbxRegister.Text) - 1, true);
                    dgvRead.Rows.Add(tbxRegister.Text, "True");
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Exception writing values to Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWriteMulti_Click(object sender, EventArgs e)
        {
            try
            {
                bool[] coilsToSend = new bool[Convert.ToInt32(tbxQuantityWrite.Text)];
                var result = Convert.ToInt32(tbxQuantityWrite.Text);

                for (int i = 0; i < coilsToSend.Length; i++)
                {
                    if (tbxValue.Text == "0" || tbxValue.Text == "false" || tbxValue.Text == "False")
                    {
                        coilsToSend[i] = false;
                    }
                    else if (tbxValue.Text == "1" || tbxValue.Text == "true" || tbxValue.Text == "True")
                    {
                        coilsToSend[i] = true;
                    }
                    client.WriteMultipleCoils(result - 1, coilsToSend);
                    result++;

                    DataGridViewRow row = (DataGridViewRow)dgvRead.Rows[0].Clone();
                    row.Cells[0].Value = result;
                    row.Cells[1].Value = coilsToSend[0].ToString();
                    row.Cells[2].Value = DateTime.Now.ToString();
                    dgvRead.Rows.Add(row);
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Exception writing values to Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnWriteMultiHolding_Click(object sender, EventArgs e)
        {
            try
            {
                var result = int.Parse(tbxRegister.Text);

                for (int i = 0; i < Convert.ToInt32(tbxQuantityWrite.Text); i++)
                {
                    client.WriteSingleRegister(result - 1, int.Parse(tbxValue.Text));
                    result++;

                    int[] values = client.ReadHoldingRegisters(int.Parse(tbxRegister.Text) - 1, 1);
                    DataGridViewRow row = (DataGridViewRow)dgvRead.Rows[0].Clone();
                    row.Cells[0].Value = result - 1;
                    row.Cells[1].Value = values[0];
                    row.Cells[2].Value = DateTime.Now.ToString();
                    dgvRead.Rows.Add(row);
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Exception writing values to Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadMultiCoil_Click(object sender, EventArgs e)
        {
            try
            {
                bool[] values;
                var result = int.Parse(tbxRegister.Text);

                for (int i = 0; i < Convert.ToInt32(tbxQuantityRead.Text); i++)
                {
                    values = client.ReadCoils(result - 1, 1);

                    DataGridViewRow row = (DataGridViewRow)dgvRead.Rows[0].Clone();
                    row.Cells[0].Value = result;
                    row.Cells[1].Value = values[0].ToString();
                    row.Cells[2].Value = DateTime.Now.ToString();
                    dgvRead.Rows.Add(row);
                    result++;
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Exception writing values to Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadMultiHolding_Click(object sender, EventArgs e)
        {
            try
            {
                int[] values;
                var result = int.Parse(tbxRegister.Text);

                for (int i = 0; i < Convert.ToInt32(tbxQuantityRead.Text); i++)
                {
                    values = client.ReadHoldingRegisters(result - 1, 1);

                    DataGridViewRow row = (DataGridViewRow)dgvRead.Rows[0].Clone();
                    row.Cells[0].Value = result;
                    row.Cells[1].Value = values[0].ToString();
                    row.Cells[2].Value = DateTime.Now.ToString();
                    dgvRead.Rows.Add(row);
                    result++;
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Exception writing values to Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadMultiInputRegisters_Click(object sender, EventArgs e)
        {
            try
            {
                int[] values;
                var result = int.Parse(tbxRegister.Text);

                for (int i = 0; i < Convert.ToInt32(tbxQuantityRead.Text); i++)
                {
                    values = client.ReadInputRegisters(result - 1, 1);

                    DataGridViewRow row = (DataGridViewRow)dgvRead.Rows[0].Clone();
                    row.Cells[0].Value = result;
                    row.Cells[1].Value = values[0].ToString();
                    row.Cells[2].Value = DateTime.Now.ToString();
                    dgvRead.Rows.Add(row);
                    result++;
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Exception writing values to Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadMultiDiscreteInputs_Click(object sender, EventArgs e)
        {
            try
            {
                int[] values;
                var result = int.Parse(tbxRegister.Text);

                for (int i = 0; i < Convert.ToInt32(tbxQuantityRead.Text); i++)
                {
                    values = client.ReadInputRegisters(result - 1, 1);

                    DataGridViewRow row = (DataGridViewRow)dgvRead.Rows[0].Clone();
                    row.Cells[0].Value = result;
                    row.Cells[1].Value = values[0].ToString();
                    row.Cells[2].Value = DateTime.Now.ToString();
                    dgvRead.Rows.Add(row);
                    result++;
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Exception writing values to Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvRead.Rows.Clear();
        }

        private void btnLogToText_Click(object sender, EventArgs e)
        {
            try
            {
                using (TextWriter tw = new StreamWriter(@"C:\Users\cceli\Desktop\Modbus\Modbus\Modbus\bin\Debug\log.txt"))
                {
                    for (int i = 0; i < dgvRead.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgvRead.Columns.Count; j++)
                        {
                            tw.Write($"{dgvRead.Rows[i].Cells[j].Value.ToString()}");

                            if (j != (dgvRead.Columns.Count) - 1)
                            {
                                tw.Write("-");
                            }
                        }
                        tw.WriteLine();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Exception writing values to Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteFromView_Click(object sender, EventArgs e)
        {
            try
            {
                dgvRead.Rows.RemoveAt(dgvRead.SelectedRows[0].Index);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Exception writing values to Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                ImportDialog.Multiselect = false;
                DialogResult dialogResult = ImportDialog.ShowDialog();
                string path = ImportDialog.FileName;

                string[] lines = File.ReadAllLines(path);
                string[] values;

                for (int i = 0; i < lines.Length; i++)
                {
                    values = lines[i].ToString().Split('-');
                    string[] row = new string[values.Length];

                    for (int j = 0; j < values.Length; j++)
                    {
                        row[j] = values[j].Trim();
                    }
                    dgvRead.Rows.Add(row);
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message, "Exception writing values to Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}