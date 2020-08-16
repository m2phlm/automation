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
    public partial class frm_skin_setting : MaterialSkin.Controls.MaterialForm
    {
        public frm_skin_setting()
        {
            InitializeComponent();
        }
        MaterialSkin.MaterialSkinManager sm; //sm = skin manager
        MaterialSkin.Primary primery_color= MaterialSkin.Primary.Blue400;
        MaterialSkin.Primary dark_primry= MaterialSkin.Primary.Blue700;
        MaterialSkin.TextShade Text_color = MaterialSkin.TextShade.BLACK;
        Modern_setting_form.Classes.cls_skin_loader my_class = new Classes.cls_skin_loader();

        private void frm_skin_setting_Load(object sender, EventArgs e)
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
            //---------------Load Setting------------------
            //Boolean b;
            //b = Modern_setting_form.Properties.Settings.Default.rb_theme_light;
            //if (b == true)
            //{
            //    this.rbLight.Checked=true;
            //    this.rbDark.Checked = false;
            //    sm.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //}
            //else
            //{
            //    this.rbLight.Checked = false;
            //    this.rbDark.Checked = true;
            //    sm.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            //}


            //----------class load theme----------------
            my_class.theme_loader(this.rbLight, this.rbDark, sm);

            //---------------------Restor skin color-------------
            //Boolean b;
            // b = Modern_setting_form.Properties.Settings.Default.rb_SkinColor_blue;
            // this.rbBlue.Checked = b;
            // if (b == true)
            // {
            //     primery_color = MaterialSkin.Primary.Blue400;
            //     dark_primry = MaterialSkin.Primary.Blue700;
            // }
            // //------------------------------------
            // b=Modern_setting_form.Properties.Settings.Default.rb_SkinColor_Green ;
            // this.rbGreen.Checked = b;
            // if (b == true)
            // {
            //     primery_color = MaterialSkin.Primary.Green400;
            //     dark_primry = MaterialSkin.Primary.Green700;
            // }
            // //------------------------------------------
            // b =Modern_setting_form.Properties.Settings.Default.rb_SkinColor_Orange ;
            // this.rbOrange.Checked = b;
            // if (b == true)
            // {
            //     primery_color = MaterialSkin.Primary.Orange400;
            //     dark_primry = MaterialSkin.Primary.Orange700;
            // }
            // //-------------------------------------
            // b =Modern_setting_form.Properties.Settings.Default.rb_SkinColor_Pink ;
            // this.rbPink.Checked = b;
            // if (b == true)
            // {
            //     primery_color = MaterialSkin.Primary.Pink400;
            //     dark_primry = MaterialSkin.Primary.Pink700;
            // }

            //---------------Load class skin color-----------
             my_class.skin_color_loader(ref primery_color,
                                        ref dark_primry,
                                        this.rbBlue,
                                        this.rbGreen,
                                        this.rbOrange,
                                        this.rbPink);

            //-------------------restore text color-----------
            //Boolean b;
            //b = Modern_setting_form.Properties.Settings.Default.rb_txtColor_white;
            //this.rbWhite.Checked = b;
            //if (b == true)
            //{
            //    Text_color = MaterialSkin.TextShade.WHITE;
            //}
            ////------------------------------------------------------
            //b = Modern_setting_form.Properties.Settings.Default.rb_txtColor_black;
            //this.rbBlack.Checked = b;
            //if (b == true)
            //{
            //    Text_color = MaterialSkin.TextShade.BLACK;
            //}

            //-------------------Class restore text color-----------
            my_class.Load_text_color(this.rbWhite,this.rbBlack,ref Text_color);
            //---------Load class skin changer-----------------------------

            my_class.cls_color_changer(primery_color,dark_primry,Text_color,sm);
        }
        

        private void rbLight_Click(object sender, EventArgs e)
        {
            sm.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            Modern_setting_form.Properties.Settings.Default.rb_theme_light=this.rbLight.Checked;
            Modern_setting_form.Properties.Settings.Default.rb_theme_dark =this. rbDark.Checked;
            Modern_setting_form.Properties.Settings.Default.Save();
        }

        private void tbDark_Click(object sender, EventArgs e)
        {
            sm.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            Modern_setting_form.Properties.Settings.Default.rb_theme_light = this.rbLight.Checked;
            Modern_setting_form.Properties.Settings.Default.rb_theme_dark =this. rbDark.Checked;
            Modern_setting_form.Properties.Settings.Default.Save();
        }

      

        //void skin_changer()
        //{
        //    sm.ColorScheme = new MaterialSkin.ColorScheme(primery_color,
        //                                                  dark_primry,
        //                                                  MaterialSkin.Primary.Blue100,
        //                                                  MaterialSkin.Accent.Orange400,
        //                                                  Text_color);

        //}

     

        private void rbBlack_Click(object sender, EventArgs e)
        {
            Text_color = MaterialSkin.TextShade.BLACK;
            //-----------------------
            my_class.cls_color_changer(primery_color, dark_primry, Text_color, sm);
            //--------------------------
            Modern_setting_form.Properties.Settings.Default.rb_txtColor_black = this.rbBlack.Checked;
            Modern_setting_form.Properties.Settings.Default.rb_txtColor_white = this.rbWhite.Checked;
            Modern_setting_form.Properties.Settings.Default.Save();
        }

        private void rbWhite_Click(object sender, EventArgs e)
        {
            Text_color = MaterialSkin.TextShade.WHITE;
            //----------------------
            my_class.cls_color_changer(primery_color, dark_primry, Text_color, sm);
            //-----------------
            Modern_setting_form.Properties.Settings.Default.rb_txtColor_white = this.rbWhite.Checked;
            Modern_setting_form.Properties.Settings.Default.rb_txtColor_black = this.rbBlack.Checked;
            Modern_setting_form.Properties.Settings.Default.Save();
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void rbBlue_Click(object sender, EventArgs e)
        {
            primery_color = MaterialSkin.Primary.Blue400;
            dark_primry = MaterialSkin.Primary.Blue700;
            //-----------------
            my_class.cls_color_changer(primery_color, dark_primry, Text_color, sm);
            //----------------------
            color_loader();
        }
        void color_loader()
        {
            Modern_setting_form.Properties.Settings.Default.rb_SkinColor_blue = rbBlue.Checked;
            Modern_setting_form.Properties.Settings.Default.rb_SkinColor_Green = rbGreen.Checked;
            Modern_setting_form.Properties.Settings.Default.rb_SkinColor_Orange = rbOrange.Checked;
            Modern_setting_form.Properties.Settings.Default.rb_SkinColor_Pink = rbPink.Checked;
            Modern_setting_form.Properties.Settings.Default.Save();
        }

        private void rbOrange_Click(object sender, EventArgs e)
        {
            primery_color = MaterialSkin.Primary.Orange400;
            dark_primry = MaterialSkin.Primary.Orange700;
            my_class.cls_color_changer(primery_color, dark_primry, Text_color, sm);
            //----------------------
            color_loader();
        }

        private void rbGreen_Click(object sender, EventArgs e)
        {
            primery_color = MaterialSkin.Primary.Green400;
            dark_primry = MaterialSkin.Primary.Green700;
            my_class.cls_color_changer(primery_color, dark_primry, Text_color, sm);
            //----------------------
            color_loader();
        }

        private void rbPink_Click(object sender, EventArgs e)
        {
            primery_color = MaterialSkin.Primary.Pink400;
            dark_primry = MaterialSkin.Primary.Pink700;
            //-----------------------
            my_class.cls_color_changer(primery_color, dark_primry, Text_color, sm);
            //----------------------
            color_loader();
        }

       
    }
}
