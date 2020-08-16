using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_setting_form.Classes
{
    class cls_skin_loader
    {

       
    

        public void cls_color_changer(MaterialSkin.Primary primery_color,
                                      MaterialSkin.Primary dark_primry,
                                      MaterialSkin.TextShade Text_color,
                                      MaterialSkin.MaterialSkinManager sm)
        {
            sm.ColorScheme = new MaterialSkin.ColorScheme(primery_color,
                                                        dark_primry,
                                                        MaterialSkin.Primary.Blue100,
                                                        MaterialSkin.Accent.Orange400,
                                                        Text_color);
        }
        public void theme_loader(MaterialSkin.Controls.MaterialRadioButton rbLight,
                                 MaterialSkin.Controls.MaterialRadioButton rbDark,
                                 MaterialSkin.MaterialSkinManager sm)
                                    
        {
            Boolean b;
            b = Modern_setting_form.Properties.Settings.Default.rb_theme_light;
            if (b == true)
            {
                rbLight.Checked = true;
                rbDark.Checked = false;
                sm.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            }
            else
            {
                rbLight.Checked = false;
                rbDark.Checked = true;
                sm.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            }
        }
        public void skin_color_loader(ref MaterialSkin.Primary primery_color,
                                      ref MaterialSkin.Primary dark_primry,
                                      MaterialSkin.Controls.MaterialRadioButton rbBlue,
                                      MaterialSkin.Controls.MaterialRadioButton rbGreen,
                                      MaterialSkin.Controls.MaterialRadioButton rbOrange,
                                      MaterialSkin.Controls.MaterialRadioButton rbPink)
        {
            Boolean b;
            b = Modern_setting_form.Properties.Settings.Default.rb_SkinColor_blue;
            rbBlue.Checked = b;
            if (b == true)
            {
                primery_color = MaterialSkin.Primary.Blue400;
                dark_primry = MaterialSkin.Primary.Blue700;
            }
            //------------------------------------
            b = Modern_setting_form.Properties.Settings.Default.rb_SkinColor_Green;
            rbGreen.Checked = b;
            if (b == true)
            {
                primery_color = MaterialSkin.Primary.Green400;
                dark_primry = MaterialSkin.Primary.Green700;
            }
            //------------------------------------------
            b = Modern_setting_form.Properties.Settings.Default.rb_SkinColor_Orange;
            rbOrange.Checked = b;
            if (b == true)
            {
                primery_color = MaterialSkin.Primary.Orange400;
                dark_primry = MaterialSkin.Primary.Orange700;
            }
            //-------------------------------------
            b = Modern_setting_form.Properties.Settings.Default.rb_SkinColor_Pink;
            rbPink.Checked = b;
            if (b == true)
            {
                primery_color = MaterialSkin.Primary.Pink400;
                dark_primry = MaterialSkin.Primary.Pink700;
            }

        }
        public void Load_text_color(MaterialSkin.Controls.MaterialRadioButton rbWhite,
                                    MaterialSkin.Controls.MaterialRadioButton rbBlack,
                                    ref MaterialSkin.TextShade Text_color)
        {
            Boolean b;
            b = Modern_setting_form.Properties.Settings.Default.rb_txtColor_white;
            rbWhite.Checked = b;
            if (b == true)
            {
                Text_color = MaterialSkin.TextShade.WHITE;
            }
            //------------------------------------------------------
            b = Modern_setting_form.Properties.Settings.Default.rb_txtColor_black;
            rbBlack.Checked = b;
            if (b == true)
            {
                Text_color = MaterialSkin.TextShade.BLACK;
            }
        }
       
    }

}
