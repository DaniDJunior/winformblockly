using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blockly
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private async void btnExecutar_Click(object sender, EventArgs e)
        {
            string xml = await webView.CoreWebView2.ExecuteScriptAsync("clik();");
            xml = xml.Replace("\\u003C","<").Replace("\\\"","\"").Replace("\\n", string.Empty);
            xml = xml.Remove(0, 1);
            xml = xml.Remove(xml.Length - 1, 1);

            var parser = Ag.Codex.Blocks.Extensions.AddStandardBlocks(new Ag.Codex.Parser());

            parser.AddBlock<Ag.Codex.Blocks.Variables.ConstantSet>("form_set_s");

            parser.AddBlock<Ag.Codex.Blocks.Variables.ConstantGet>("from_a");
            parser.AddBlock<Ag.Codex.Blocks.Variables.ConstantGet>("from_b");
            parser.AddBlock<Ag.Codex.Blocks.Variables.ConstantGet>("from_c");

            Ag.Codex.Context context = new Ag.Codex.Context();

            context.Variables.Add("from_a", Convert.ToDouble(txtAVariavel.Text, new CultureInfo("pt-BR")));
            context.Variables.Add("from_b", Convert.ToDouble(txtBVariavel.Text, new CultureInfo("pt-BR")));
            context.Variables.Add("from_c", Convert.ToDouble(txtCVariavel.Text, new CultureInfo("pt-BR")));
            context.Variables.Add("form_set_s", Convert.ToDouble(txtAVariavel.Text, new CultureInfo("pt-BR")));

            var workplace = parser.Parse(xml);

            workplace.Evaluate(context);

            if (context.Variables.ContainsKey("form_set_s"))
            {
                lblSVariavel.Text = context.Variables["form_set_s"].ToString();
            }

        }

        private void frmPrincipal_SizeChanged(object sender, EventArgs e)
        {
            webView.CoreWebView2.ExecuteScriptAsync("$('#blocklyDiv').css('height', '" + webView.Height.ToString() + "px');");
        }
    }
}
