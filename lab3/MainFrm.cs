using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab3
{
    public partial class MainFrm : Form
    {
        private Lcg _lcg;
        private GammaOverlayCipher _goc;

        public MainFrm()
        {
            InitializeComponent();

            _lcg = new Lcg(17, 256, 39, 41);
            _goc = new GammaOverlayCipher(256);
        }

        private void encBtn_Click(object sender, EventArgs e)
        {
            try
            {
                encTB.Text = ToHex(_goc.Encrypt(decTB.Text, FromHex(gammaTB.Text)));
            }
            catch (Exception ex)
            {
                Program.ShowError(ex.Message, "Encryption error");
            }
        }

        private void decBtn_Click(object sender, EventArgs e)
        {
            try
            {
                decTB.Text = _goc.Decrypt(FromHex(encTB.Text), FromHex(gammaTB.Text));
            }
            catch (Exception ex)
            {
                Program.ShowError(ex.Message, "Decryption error");
            }
        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            if (decTB.TextLength > 0)
                gammaTB.Text = ToHex(_lcg.Generate(decTB.TextLength));
        }

        private string ToHex(IEnumerable<int> a)
        {
            StringBuilder sb = new StringBuilder();

            foreach (int i in a)
                sb.AppendFormat("{0} ", Convert.ToString(i, 16).PadLeft(2, '0'));

            sb.Remove(sb.Length - 1, 1);

            return sb.ToString();
        }

        private IEnumerable<int> FromHex(string hex)
        {
            return from i in hex.Split(' ') select Convert.ToInt32(i, 16); 
        }
    }
}
