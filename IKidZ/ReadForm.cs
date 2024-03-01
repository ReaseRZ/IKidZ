using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKidZ
{
    public partial class ReadForm : Form
    {
        const int OFFSET_XCORD = 69;
        const int OFFSET_YCORD = 100;
        Letter newForm = null;
        MainForm parent = null;
        public ReadForm()
        {
            InitializeComponent();
            InitAllPanelNeeded();
        }

        public ReadForm(MainForm inherit)
        {
            InitializeComponent();
            InitAllPanelNeeded();
            parent = inherit;
        }


        private void InitAllPanelNeeded()
        {
            panels.Add(this.panel1);
            panels.Add(InitPanel(new Letter(this,"A", "/ei/", "Apple", global::IKidZ.Properties.Resources.Apple_6)));
            panels.Add(InitPanel(new Letter(this, "B", "/bi/", "Ballon", global::IKidZ.Properties.Resources.balloon_6)));
            panels.Add(InitPanel(new Letter(this,"C", "/si/", "Camera", global::IKidZ.Properties.Resources.Camera)));
            panels.Add(InitPanel(new Letter(this,"D", "/di/", "Dove", global::IKidZ.Properties.Resources.Dove)));
            panels.Add(InitPanel(new Letter(this,"E", "/i/", "Eye", global::IKidZ.Properties.Resources.Cuteeyes)));
            panels.Add(InitPanel(new Letter(this,"F", "/ef/", "Fire", global::IKidZ.Properties.Resources.Fire)));
            panels.Add(InitPanel(new Letter(this,"G", "/gee/", "Guitar", global::IKidZ.Properties.Resources.Guitar)));
            panels.Add(InitPanel(new Letter(this,"H", "/aitch/", "House", global::IKidZ.Properties.Resources.House8)));
            panels.Add(InitPanel(new Letter(this,"I", "/ai/", "Ink", global::IKidZ.Properties.Resources._1230682)));
            panels.Add(InitPanel(new Letter(this,"J", "/jeei/", "Jar", global::IKidZ.Properties.Resources.jar)));
            panels.Add(InitPanel(new Letter(this,"K", "/kei/", "Kite", global::IKidZ.Properties.Resources.Kite)));
            panels.Add(InitPanel(new Letter(this,"L", "/el/", "Lamp", global::IKidZ.Properties.Resources.Lamp)));
            panels.Add(InitPanel(new Letter(this,"M", "/em/", "Money", global::IKidZ.Properties.Resources.Money)));
            panels.Add(InitPanel(new Letter(this,"N", "/en/", "Nose", global::IKidZ.Properties.Resources.Nose)));
            panels.Add(InitPanel(new Letter(this,"O", "/ou/", "Owl", global::IKidZ.Properties.Resources.Owl)));
            panels.Add(InitPanel(new Letter(this,"P", "/pi/", "Parrot", global::IKidZ.Properties.Resources.Parrot)));
            panels.Add(InitPanel(new Letter(this,"Q", "/kiu/", "Queen", global::IKidZ.Properties.Resources.Queen)));
            panels.Add(InitPanel(new Letter(this,"R", "/ar/", "Ribbon", global::IKidZ.Properties.Resources.Ribbon)));
            panels.Add(InitPanel(new Letter(this,"S", "/es/", "Sun", global::IKidZ.Properties.Resources.Sun)));
            panels.Add(InitPanel(new Letter(this,"T", "/ti/", "Truck", global::IKidZ.Properties.Resources.Truck)));
            panels.Add(InitPanel(new Letter(this,"U", "/yu/", "Unicorn", global::IKidZ.Properties.Resources.Unicorn)));
            panels.Add(InitPanel(new Letter(this,"V", "/vi/", "Vase", global::IKidZ.Properties.Resources.Vase)));
            panels.Add(InitPanel(new Letter(this,"W", "/dabelyu/", "Watermelon", global::IKidZ.Properties.Resources.Watermelon)));
            panels.Add(InitPanel(new Letter(this,"X", "/eks/", "Xylophone", global::IKidZ.Properties.Resources.Xylophone)));
            panels.Add(InitPanel(new Letter(this,"Y", "/wai/", "Yacht", global::IKidZ.Properties.Resources.Yacht)));
            panels.Add(InitPanel(new Letter(this,"Z", "/zi/", "Zebra", global::IKidZ.Properties.Resources.Zebra)));
        }

        public void ShowPanel(int page)
        {
            for(int i = 0; i < panels.Count; i++)
            {
                panels[i].Visible = false;
            }
            panels[page].Visible = true;
        }

        private Letter InitPanel(Letter newForm)
        {
            newForm.Dock = DockStyle.Fill;
            newForm.Parent = this;
            newForm.AddConfigure();
            this.Controls.Add(newForm);
            return newForm;
        }

        private void Reset(object e, EventArgs eventArgs)
        {
            this.ShowPanel(0);
        }

        private void AButton(object sender, EventArgs e)
        {
            page = 1;
            ShowPanel(page);
        }
        private void BButton(object sender, EventArgs e)
        {
            page = 2;
            ShowPanel(page);
        }
        private void CButton(object sender, EventArgs e)
        {
            page = 3;
            ShowPanel(page);
        }
        private void DButton(object sender, EventArgs e)
        {
            page = 4;
            ShowPanel(page);
        }
        private void EButton(object sender, EventArgs e)
        {
            page = 5;
            ShowPanel(page);
        }
        private void FButton(object sender, EventArgs e)
        {
            page = 6;
            ShowPanel(page);
        }
        private void GButton(object sender, EventArgs e)
        {
            page = 7;
            ShowPanel(page);
        }
        private void HButton(object sender, EventArgs e)
        {
            page = 8;
            ShowPanel(page);
        }
        private void IButton(object sender, EventArgs e)
        {
            page = 9;
            ShowPanel(page);
        }
        private void JButton(object sender, EventArgs e)
        {
            page = 10;
            ShowPanel(page);
        }
        private void KButton(object sender, EventArgs e)
        {
            page = 11;
            ShowPanel(page);
        }
        private void LButton(object sender, EventArgs e)
        {
            page = 12;
            ShowPanel(page);
        }
        private void MButton(object sender, EventArgs e)
        {
            page = 13;
            ShowPanel(page);
        }
        private void NButton(object sender, EventArgs e)
        {
            page = 14;
            ShowPanel(page);
        }
        private void OButton(object sender, EventArgs e)
        {
            page = 15;
            ShowPanel(page);
        }
        private void PButton(object sender, EventArgs e)
        {
            page = 16;
            ShowPanel(page);
        }
        private void QButton(object sender, EventArgs e)
        {
            page = 17;
            ShowPanel(page);
        }
        private void RButton(object sender, EventArgs e)
        {
            page = 18;
            ShowPanel(page);
        }
        private void SButton(object sender, EventArgs e)
        {
            page = 19;
            ShowPanel(page);
        }
        private void TButton(object sender, EventArgs e)
        {
            page = 20;
            ShowPanel(page);
        }
        private void UButton(object sender, EventArgs e)
        {
            page = 21;
            ShowPanel(page);
        }
        private void VButton(object sender, EventArgs e)
        {
            page = 22;
            ShowPanel(22);
        }
        private void WButton(object sender, EventArgs e)
        {
            page = 23;
            ShowPanel(page);
        }
        private void XButton(object sender, EventArgs e)
        {
            page = 24;
            ShowPanel(page);
        }
        private void YButton(object sender, EventArgs e)
        {
            page = 25;
            ShowPanel(page);
        }
        private void ZButton(object sender, EventArgs e)
        {
            page = 26;
            ShowPanel(page);
        }

        public int page = 0;
        public List<Panel> panels = new List<Panel>();

        private void ReadForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ShowPanel(0);
            this.parent.Show();
        }

        private void ReadForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
