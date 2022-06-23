using System;
using System.Drawing;
using System.IO;
using iTextSharp.text;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool paz = false;


        TreeNode uz0 = new TreeNode();
        TreeNode en0 = new TreeNode();
        TreeNode uq0 = new TreeNode();
        TreeNode sanoq = new TreeNode();

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==' ')
            {
                tarjima.Visible = !tarjima.Visible;
                if (til.Text == "O'zbekcha")
                {
                    uqilishi.Visible = !uqilishi.Visible;
                }
                timer.Enabled = !timer.Enabled;
                paz = !paz;
                if (!paz)
                {
                    til_almashsa();
                }
            }
            else
            {
                if (til.Text == "O'zbekcha")
                {
                    til.Text = "English";
                }
                else
                {
                    til.Text = "O'zbekcha";
                }
                til_almashsa();
                
            }

        }


        public void til_almashsa()
        {
            if (!paz)
            {

                if (til.Text == "O'zbekcha")
                {
                    uqilishi.Visible = false;

                }
                else
                {
                    tarjima.Visible = false;
                    uqilishi.Visible = true;
                }
                
            }
            qiymat_kirit();
        }

        public void qiymat_kirit()
        {
            if (linklabel.Text != "Fayl tanlang")
            {
                if (til.Text == "O'zbekcha")
                {
                    asosiy.Text = uz0.Nodes[value].Text;
                    tarjima.Text = en0.Nodes[value].Text;
                }
                else
                {
                    asosiy.Text = en0.Nodes[value].Text;
                    tarjima.Text = uz0.Nodes[value].Text;
                }
                uqilishi.Text = uq0.Nodes[value].Text;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //til_almashsa();
           


        }
        int value = 0;
        Random r = new Random();
        private void timer_Tick(object sender, EventArgs e)
        {
            if (sanoq.Nodes.Count>0)
            {
                
                
                value = r.Next(0, sanoq.Nodes.Count - 1);

                int v = value;
                value = Convert.ToInt16(sanoq.Nodes[v].Text);
                sanoq.Nodes[v].Remove();
                qiymat_kirit();

            }
            else
            {

                if (label1.Text == "∞")
                {
                    int len = uz0.Nodes.Count;
                    for (int i = 0; i < len; i++)
                    {
                        sanoq.Nodes.Add(i.ToString());
                    }

                }

                else
                {
                    linklabel.Text = "Fayl tanlang";
                    timer.Stop();
                }
                
            }
            
        }

        private void til_Click(object sender, EventArgs e)
        {
            if (til.Text == "O'zbekcha")
            {
                til.Text = "English";
            }
            else
            {
                til.Text = "O'zbekcha";
            }
            til_almashsa();
        }


        public static string pdfText(string path)
        {
            PdfReader reader = new PdfReader(path);
            string text = string.Empty;
            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                text += PdfTextExtractor.GetTextFromPage(reader, page);
            }
            reader.Close();
            return text;
        }
        private void linklabel_Click(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog.ShowDialog();
            if (d == DialogResult.OK)
            {
                
                StreamReader baza = new StreamReader(openFileDialog.FileName);
                string[] bo = baza.ReadLine().Split(';');

                if (bo.Length != 3)
                {
                    MessageBox.Show("Faylning birinchi qatorida ustun haqidagi malumotlar bo'lishi kerak masalan uz,en,uq");
                }
                else
                {
                    int uz = 0, en = 0, uq = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        if (bo[i] == "uz")
                        {
                            uz = i;
                        }
                        else if (bo[i] == "en")
                        {
                            en = i;

                        }
                        else
                        {
                            uq = i;
                        }
                    }
                    string s = baza.ReadLine();
                    while (s != null)
                    {
                        bo = s.Split(';');
                        if (bo.Length > 2)
                        {
                            uz0.Nodes.Add(bo[uz]);
                            en0.Nodes.Add(bo[en]);
                            uq0.Nodes.Add(bo[uq]);
                        }

                        s = baza.ReadLine();
                    }

                    int len = uz0.Nodes.Count;
                    for(int i = 0; i < len; i++)
                    {
                        string t = i.ToString();
                        sanoq.Nodes.Add(t);
                    }

                    timer.Start();
                    linklabel.Text = openFileDialog.FileName;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "(1)")
            {
                label1.Text = "∞";
            }
            else
            {
                label1.Text = "(1)";
            }
        }

        private void asosiy_Resize(object sender, EventArgs e)
        {
            int x = ClientSize.Width;
            int y = ClientSize.Height;

            //textBox1.Size = new Size(x * 664 / 704, y * 41 / 442);
            //textBox1.Location = new Point(x * 12 / 704, y * 62 / 442);
            
            int l1 = asosiy.Size.Width;
            int l2 = tarjima.Size.Width;
            int l3 = uqilishi.Size.Width;
            int t = til.Size.Width;
            asosiy.Location = new Point((x - l1) / 2, asosiy.Location.Y);
            tarjima.Location = new Point((x - l2) / 2, tarjima.Location.Y);
            uqilishi.Location = new Point((x - l3) / 2, uqilishi.Location.Y);
            til.Location = new Point((x - t) / 2, til.Size.Height);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
                timer.Interval = (int)numericUpDown1.Value * 1000;
            else
            {
                timer.Interval = 1000;
                numericUpDown1.Value = 1;
            }
        }
        
    }
}
