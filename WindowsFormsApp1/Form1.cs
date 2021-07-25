using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Sudoku : Form
    {
        private IContainer components;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private TextBox[,] textBoxes = new TextBox[9, 9];
        public Sudoku()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sudoku));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(524, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(498, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(552, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 44);
            this.button3.TabIndex = 4;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(606, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 44);
            this.button4.TabIndex = 5;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(498, 144);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 44);
            this.button5.TabIndex = 6;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(552, 144);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(48, 44);
            this.button6.TabIndex = 7;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Location = new System.Drawing.Point(606, 144);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(48, 44);
            this.button7.TabIndex = 8;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button8.Location = new System.Drawing.Point(498, 194);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(48, 44);
            this.button8.TabIndex = 9;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button9.Location = new System.Drawing.Point(552, 194);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(48, 44);
            this.button9.TabIndex = 10;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button10.Location = new System.Drawing.Point(606, 194);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(48, 44);
            this.button10.TabIndex = 11;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Sudoku
            // 
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Sudoku";
            this.Text = "Sudoku";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeTextBoxes();
            DrawLines();
            button1.Enabled = false;

        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Console.WriteLine(e.KeyChar);
            //if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
            //    e.Handled = true;

        }

        private void InitializeTextBoxes()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    textBoxes[i, j] = new TextBox();
                    textBoxes[i, j].Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    textBoxes[i, j].TextAlign = HorizontalAlignment.Center;
                    textBoxes[i, j].Location = new System.Drawing.Point(j * 50, i * 50);
                    textBoxes[i, j].Width = 50;
                    textBoxes[i, j].MaxLength = 1;
                    textBoxes[i, j].KeyPress += new KeyPressEventHandler(textBoxes_KeyPress);
                    textBoxes[i, j].KeyDown += new KeyEventHandler(textBoxes_KeyDown);
                    textBoxes[i, j].TextChanged += new EventHandler(textBoxes_TextChanged);
                    this.Controls.Add(textBoxes[i, j]);
                }
            }
        }

        private void textBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void textBoxes_TextChanged(object sender, EventArgs e)
        {
            if (IsFilled())
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }

        }

        private void textBoxes_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    MoveCursor(1, 0);
                    break;
                case Keys.Left:
                    MoveCursor(-1, 0);
                    break;
                case Keys.Up:
                    MoveCursor(0, -1);
                    break;
                case Keys.Down:
                    MoveCursor(0, 1);
                    break;
            }
        }

        private void MoveCursor(int xDir, int yDir)
        {
            Vector activeTxtBox = GetFocusedBox();
            int x = Convert.ToInt32(activeTxtBox.X);
            int y = Convert.ToInt32(activeTxtBox.Y);
            if (x + xDir >= 0 & x + xDir <= 8 & y + yDir >= 0 & y + yDir <= 8)
            {
                while (textBoxes[y + yDir, x + xDir].ReadOnly)
                {
                    if (xDir >= 1)
                    {
                        xDir = xDir + 1;
                    }
                    else if (xDir <= -1)
                    {
                        xDir = xDir - 1;
                    }
                    else if (yDir >= 1)
                    {
                        yDir = yDir + 1;
                    }
                    else if (yDir <= -1)
                    {
                        yDir = yDir - 1;
                    }

                    if (x + xDir < 0 | x + xDir > 8)
                    {
                        if (xDir >= 1)
                        {
                            xDir = 0;
                            x = 0;
                            y++;
                        }
                        else if (xDir <= -1)
                        {
                            xDir = 0;
                            x = 8;
                            y--;
                        }

                        if (y > 8)
                        {
                            y = 0;
                        }
                        else if (y < 0)
                        {
                            y = 8;
                        }

                        while (textBoxes[y + yDir, x + xDir].ReadOnly)
                        {
                            if (x == 0)
                            {
                                xDir = xDir + 1;
                            }
                            else
                            {
                                xDir = xDir - 1;
                            }
                        }

                    }
                    else if (y + yDir < 0 | y + yDir > 8)
                    {
                        if (yDir >= 1)
                        {
                            y = 0;
                            yDir = 0;
                        }
                        else if (yDir <= -1)
                        {
                            y = 0;
                            yDir = 8;
                        }

                        while (textBoxes[y + yDir, x + xDir].ReadOnly)
                        {
                            if (yDir >= 0)
                            {
                                yDir = yDir + 1;
                            }
                            else if (yDir <= -1)
                            {
                                yDir = yDir - 1;
                            }
                        }
                    }
                }
            }
            else if (x + xDir < 0 | x + xDir > 8)
            {
                if (xDir >= 1)
                {
                    xDir = 0;
                    x = 0;
                    y++;
                }
                else if (xDir <= -1)
                {
                    xDir = 0;
                    x = 8;
                    y--;
                }

                if (y > 8)
                {
                    y = 0;
                }
                else if (y < 0)
                {
                    y = 8;
                }

                while (textBoxes[y + yDir, x + xDir].ReadOnly)
                {
                    if (x == 0)
                    {
                        xDir = xDir + 1;
                    }
                    else
                    {
                        xDir = xDir - 1;
                    }
                }


            }
            else if (y + yDir < 0 | y + yDir > 8)
            {
                if (yDir >= 1)
                {
                    y = 0;
                    yDir = 0;
                }
                else if (yDir <= -1)
                {
                    y = 0;
                    yDir = 8;
                }

                while (textBoxes[y + yDir, x + xDir].ReadOnly)
                {
                    if (yDir >= 0)
                    {
                        yDir = yDir - 1;				
                    }
                    else if (yDir <= -1)         /* <---- tady chyba */
                    {							 /*Zvýraznit tlačítko - aktivní řešení*/
                        yDir = yDir + 1;
                    }
                }
            }
            textBoxes[y + yDir, x + xDir].Focus();
        }

        private Vector GetFocusedBox()
        {
            Vector txtBoxPos = new Vector();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (textBoxes[i, j].Focused)
                    {
                        txtBoxPos.X = j;
                        txtBoxPos.Y = i;
                    }
                }
            }
            return txtBoxPos;
        }

        private void DrawLines()
        {
            for (int i = 1; i < 3; i++)
            {
                Panel pan = new Panel();
                pan.Enabled = false;
                pan.Width = 4;
                pan.Height = 450;
                pan.Location = new System.Drawing.Point(i * 148, 0);
                pan.BackColor = Color.Black;
                Controls.Add(pan);
                pan.BringToFront();
            }

            for (int i = 1; i < 3; i++)
            {
                Panel pan = new Panel();
                pan.Enabled = false;
                pan.Width = 450;
                pan.Height = 4;
                pan.Location = new System.Drawing.Point(0, i * 148);
                pan.BackColor = Color.Black;
                Controls.Add(pan);
                pan.BringToFront();
            }
        }

        private void CheckTable()
        {
            if (RowsAreOK() & ColsAreOK() & ZonesAreOK())
            {
                MessageBox.Show("Good Job!", "Sudoku", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The solution is incorrect!", "Sudoku", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool RowsAreOK()
        {
            bool rowIsOK = true;
            int[] row = new int[9];
            for (int i = 0; i < 9 & rowIsOK; i++)
            {
                for (int j = 0; j < 9 & rowIsOK; j++)
                {
                    row[j] = Convert.ToInt32(textBoxes[i, j].Text);

                }
                if (row.Sum() == 45)
                {
                    rowIsOK = true;

                }
                else rowIsOK = false;

            }
            if (rowIsOK)
            {
                return true;
            }
            else return false;
        }

        private bool ColsAreOK()
        {
            bool colIsOK = true;
            int[] col = new int[9];
            for (int i = 0; i < 9 & colIsOK; i++)
            {
                for (int j = 0; j < 9 & colIsOK; j++)
                {
                    col[j] = Convert.ToInt32(textBoxes[j, i].Text);

                }
                if (col.Sum() == 45)
                {
                    colIsOK = true;

                }
                else colIsOK = false;
            }
            if (colIsOK)
            {
                return true;
            }
            else return false;
        }

        private bool ZonesAreOK()
        {
            bool zoneIsOK = true;
            int[] zone = new int[9];

            for (int x = 3; x <= 9 & zoneIsOK; x += 3)
            {
                for (int y = 3; y <= 9 & zoneIsOK; y += 3)
                {
                    int index = 0;
                    for (int i = x - 3; i < x; i++)
                    {
                        for (int j = y - 3; j < y; j++)
                        {
                            zone[index] = Convert.ToInt32(textBoxes[i, j].Text);
                            index++;
                        }
                    }

                    if (zone.Sum() == 45)
                    {
                        zoneIsOK = true;
                    }
                    else zoneIsOK = false;
                }
            }
            if (zoneIsOK)
            {
                return true;
            }
            else return false;
        }

        private void FillTable(string[,] numbers)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (numbers[i, j] != "")
                    {
                        textBoxes[i, j].ReadOnly = true;
                        textBoxes[i, j].Text = numbers[i, j];
                        textBoxes[i, j].Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        textBoxes[i, j].BackColor = Color.LightGray;
                    }
                    else
                    {
                        textBoxes[i, j].ReadOnly = false;
                        textBoxes[i, j].Text = numbers[i, j];
                        textBoxes[i, j].Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    }

                }
            }
        }

        private void ClearTable()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    textBoxes[i, j].Text = "";
                    textBoxes[i, j].BackColor = System.Drawing.SystemColors.Window;
                }
            }
        }

        private bool IsFilled()
        {
            bool isFilled = true;
            for (int i = 0; i < 9 & isFilled; i++)
            {
                for (int j = 0; j < 9 & isFilled; j++)
                {
                    if (textBoxes[i, j].Text != "")
                    {
                        isFilled = true;
                    }
                    else
                    {
                        isFilled = false;
                    }
                }
            }
            if (isFilled)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[,] nums = new string[9, 9]
            {
                {"5","3","" ,"" ,"7","" ,"" ,"" ,"" },
                {"6","" ,"" ,"1","9","5","" ,"" ,"" },
                {"" ,"9","8","3","4","2","" ,"6","" },
                {"8","" ,"" ,"" ,"6","" ,"" ,"" ,"3"},
                {"4","" ,"" ,"8","" ,"3","" ,"" ,"1"},
                {"7","" ,"" ,"" ,"2","" ,"" ,"" ,"6"},
                {"" ,"6","1","" ,"" ,"" ,"2","8","" },
                {"" ,"" ,"" ,"4","1","9","" ,"" ,"5"},
                {"" ,"" ,"" ,"" ,"8","" ,"" ,"7","9"},
            };

            ClearTable();
            FillTable(nums);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[,] nums = new string[9, 9]
            {
                {"8","7","6","9","" ,"" ,"" ,"" ,"" },
                {"" ,"1","" ,"" ,"" ,"6","" ,"" ,"" },
                {"" ,"4","" ,"3","" ,"5","8","" ,"" },
                {"4","" ,"" ,"" ,"" ,"" ,"2","1","" },
                {"" ,"9","" ,"5","" ,"" ,"" ,"" ,"" },
                {"" ,"5","" ,"" ,"4","" ,"3","" ,"6"},
                {"" ,"2","9","" ,"" ,"" ,"" ,"" ,"8"},
                {"" ,"" ,"4","6","9","" ,"1","7","3"},
                {"" ,"" ,"" ,"" ,"" ,"1","" ,"" ,"4"},
            };

            ClearTable();
            FillTable(nums);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[,] nums = new string[9, 9]
            {
                {"1","" ,"" ,"2","" ,"" ,"" ,"4" ,"" },
                {"" ,"2","" ,"" ,"" ,"3","9" ,"" ,"" },
                {"9","" ,"7" ,"","" ,"" ,"5","" ,"" },
                {"" ,"" ,"4" ,"" ,"" ,"" ,"" ,"5","7"},
                {"","","","5","4" ,"1" ,"" ,"" ,""},
                {"3","5","" ,"" ,"","" ,"1","" ,""},
                {"" ,"" ,"3","" ,"" ,"" ,"7" ,"" ,"9"},
                {"" ,"" ,"1","4","" ,"" ,"","8",""},
                {"" ,"9" ,"" ,"" ,"" ,"2","" ,"" ,"6"},
            };

            ClearTable();
            FillTable(nums);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[,] nums = new string[9, 9]
{
                {"" ,"7","" ,"" ,"4","5","" ,"" ,"" },
                {"5","" ,"" ,"8","7","" ,"" ,"" ,"3"},
                {"" ,"" ,"4","1","" ,"" ,"9","" ,"" },
                {"" ,"" ,"" ,"5","" ,"2","" ,"6","8"},
                {"" ,"" ,"2","6","","" ,"" ,"3",""},
                {"" ,"" ,"1","" ,"3","" ,"1","" ,""},
                {"" ,"" ,"5","" ,"1","8","" ,"9","2"},
                {"1","4","" ,"" ,"" ,"6" ,"","","7"},
                {"2" ,"9" ,"" ,"" ,"" ,"","" ,"" ,"1"},
};

            ClearTable();
            FillTable(nums);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[,] nums = new string[9, 9]
{
                {"" ,"" ,"7","9","" ,"" ,"" ,"" ,"1"},
                {"" ,"2","3","8","" ,"" ,"6","7",""},
                {"" ,"" ,"6","" ,"2","7","" ,"" ,"" },
                {"" ,"7","8","" ,"5","" ,"" ,"" ,"" },
                {"" ,"5","" ,"2","" ,"6","" ,"3","" },
                {"" ,"" ,"","" ,"1","" ,"9","5" ,""},
                {"" ,"" ,"" ,"6","3","" ,"8" ,"" ,"" },
                {"" ,"8","4","" ,"" ,"9","2","1",""},
                {"2" ,"" ,"" ,"" ,"","1","3" ,"" ,""},
};

            ClearTable();
            FillTable(nums);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string[,] nums = new string[9, 9]
{
                {"" ,"2" ,"","5","" ,"1","" ,"9","" },
                {"8","" ,"" ,"2","" ,"3","","","6"},
                {"" ,"3" ,"","" ,"6","","" ,"7" ,"" },
                {"" ,"","1","" ,"","" ,"6" ,"" ,"" },
                {"5" ,"4","" ,"","" ,"","" ,"1","9" },
                {"" ,"" ,"2","" ,"","" ,"7","" ,""},
                {"" ,"9" ,"" ,"","3","" ,"" ,"8" ,"" },
                {"2" ,"","","8" ,"" ,"4","","","7"},
                {"" ,"1" ,"" ,"9" ,"","7","" ,"6" ,""},
};

            ClearTable();
            FillTable(nums);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string[,] nums = new string[9, 9]
{
                {"8" ,"" ,"" ,"","" ,"","" ,"","" },
                {"","" ,"3" ,"6","" ,"","","",""},
                {"" ,"7","" ,"" ,"9","","2","" ,"" },
                {"" ,"5","" ,"" ,"" ,"7","" ,"" ,"" },
                {"" ,"" ,"" ,"" ,"4","5","7","" ,"" },
                {"" ,"" ,"","1" ,"","" ,"","3" ,""},
                {"" ,"" ,"1" ,"","","" ,"" ,"6" ,"8" },
                {"" ,"","8","5" ,"" ,"","","1",""},
                {"" ,"9" ,"" ,"" ,"","","4" ,"" ,""},
};

            ClearTable();
            FillTable(nums);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string[,] nums = new string[9, 9]
{
                {"6" ,"" ,"" ,"","" ,"3","" ,"","5" },
                {"9","" ,"3" ,"","8" ,"","","",""},
                {"" ,"5","1" ,"" ,"","","6","" ,"" },
                {"" ,"","" ,"4" ,"3" ,"","" ,"" ,"7" },
                {"" ,"" ,"8" ,"5" ,"","7","1","" ,"" },
                {"4" ,"" ,"" ,"","6","8" ,"" ,"" ,"" },
                {"" ,"" ,"7" ,"","","" ,"9" ,"8" ,"" },
                {"" ,"","","" ,"7" ,"","4","","2"},
                {"8","" ,"" ,"3" ,"","","" ,"" ,"6"},
};

            ClearTable();
            FillTable(nums);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string[,] nums = new string[9, 9]
{
                {"" ,"" ,"" ,"1","" ,"5","" ,"6","8" },
                {"","" ,"" ,"","" ,"","7","","1"},
                {"9" ,"","1" ,"" ,"","","","3" ,"" },
                {"" ,"","7" ,"" ,"2" ,"6","" ,"" ,"" },
                {"5" ,"" ,"" ,"" ,"","","","" ,"3" },
                {"" ,"" ,"" ,"8","7","" ,"4" ,"" ,"" },
                {"" ,"3" ,"" ,"","","" ,"8" ,"" ,"5" },
                {"1" ,"","5","" ,"" ,"","","",""},
                {"7","9" ,"" ,"4" ,"","1","" ,"" ,""},
};

            ClearTable();
            FillTable(nums);
        }
    }
}
