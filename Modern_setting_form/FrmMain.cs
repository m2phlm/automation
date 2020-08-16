using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_setting_form
{
    public partial class FrmMain : MaterialSkin.Controls.MaterialForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        MaterialSkin.MaterialSkinManager sm; //sm = skin manager
        MaterialSkin.Primary primery_color = MaterialSkin.Primary.Blue400;
        MaterialSkin.Primary dark_primry = MaterialSkin.Primary.Blue700;
        MaterialSkin.TextShade Text_color = MaterialSkin.TextShade.BLACK;
        Modern_setting_form.Classes.cls_skin_loader my_class = new Classes.cls_skin_loader();

        private void Form1_Load(object sender, EventArgs e)
        {
            sm = MaterialSkin.MaterialSkinManager.Instance;
            sm.AddFormToManage(this);
            //------------------------------------------
            sm.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //------------------------------------------
            sm.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue400,
                                                         MaterialSkin.Primary.Blue700,
                                                         MaterialSkin.Primary.Blue100,
                                                         MaterialSkin.Accent.Orange400,
                                                         MaterialSkin.TextShade.WHITE);
            //--------------------load skin setting--------------
            MaterialSkin.Controls.MaterialRadioButton rb = new MaterialSkin.Controls.MaterialRadioButton();
            //----------class load theme----------------
            my_class.theme_loader(rb, rb,sm);

            //---------------Load class skin color-----------
            my_class.skin_color_loader(ref primery_color,
                                       ref dark_primry,
                                       rb,
                                       rb,
                                       rb,
                                       rb);
            //-------------------Class restore text color-----------
            my_class.Load_text_color(rb, rb, ref Text_color);
            //---------Load class skin changer-----------------------------

            my_class.cls_color_changer(primery_color, dark_primry, Text_color, sm);
            //---------------------------------------------

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            frm_skin_setting frm_setting = new frm_skin_setting();
            frm_setting.ShowDialog();
            frm_setting.Dispose();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
