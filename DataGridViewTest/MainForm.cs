using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataGridViewTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitToolStrip();
            InitDataGridView();
        }

        private void InitToolStrip()
        {
            ToolStripButton fillTSB = new ToolStripButton("Заполнить");
            fillTSB.Click += (s, e) => FillDGV();
            _toolStrip.Items.Add(fillTSB);
        }
        
        private void InitDataGridView()
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle
            {
                WrapMode = DataGridViewTriState.False
            };

            _dgv.DefaultCellStyle = style;

            _dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Column_1", HeaderText = "Столбец 1" });
            _dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Column_2", HeaderText = "Столбец 2" });
            _dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Column_3", HeaderText = "Столбец 3" });
            _dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Column_4", HeaderText = "Столбец 4" });
            _dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Column_5", HeaderText = "Столбец 5" });
        }

        //------------------------------------------------------------------------

        Random _randoizer;
        Random Randomizer => _randoizer ?? (_randoizer = new Random());

        private void FillDGV()
        {
            try
            {
                int rowsCount = Randomizer.Next(10, 50);

                _dgv.Rows.Clear();

                for (int i = 0; i < rowsCount; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    for (int j = 0; j < _dgv.ColumnCount; j++)
                    {
                        if (j == 0)
                            row.Cells.Add(new DataGridViewTextBoxCell() { Value = $"[{i};{j}]" });
                        if (j == 1)
                            row.Cells.Add(new DataGridViewTextBoxCell() { Value = $"[{i};{j}]" });
                        if (j == 2)
                            row.Cells.Add(new DataGridViewTextBoxCell() { Value = $"[{i};{j}]" });
                        if (j == 3)
                            row.Cells.Add(new DataGridViewTextBoxCell() { Value = $"[{i};{j}]" });
                        if (j == 4)
                            row.Cells.Add(new DataGridViewTextBoxCell() { Value = $"[{i};{j}]" });
                    }

                    _dgv.Rows.Add(row);
                }
            }
            catch (Exception error)
            {
                System.Diagnostics.Debug.WriteLine(error.Message);
            }
        }
    }
}
