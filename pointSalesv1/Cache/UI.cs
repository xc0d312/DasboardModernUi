using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using FontAwesome.Sharp;

namespace pointSalesv1.Cache
{
    public class UI
    {
        private static IconButton currentBtn;
        public static Panel rigthBorderPanel;
        public static int locationX;
        public static void clearCajas(Control.ControlCollection owner)
        {
            foreach (Control items in owner)
            {
                if (items is TextBox)
                {
                    items.Text = "";
                }
            }

        }
        public static void activeRegistro(bool flag, TabControl ctrl)
        {
            foreach (Control element in ctrl.GetControl(1).Controls)
            {
                if (element is TextBox || element is System.Windows.Forms.ComboBox || element is Button)
                {
                    element.Enabled = flag;
                }
            }
        }
        public static void clearBoxNumericDown(List<NumericUpDown> done)
        {
            foreach (NumericUpDown item in done)
            {
                if (item.Value != null)
                {
                    item.Value = 0;
                }
            }
        }
        public static bool areFieldsNotEmpty(params Control[] controls) {
            foreach (var control in controls)
            {
                if (control is NumericUpDown numericUpDown && numericUpDown.Value <= 0) return true;
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    return true;
                }
            }
            return false;
        }
        public static void activeButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                disableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(255, 255, 255);
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                //rigth border button
                //rigthBorderPanel.BackColor = color;

                //rigthBorderPanel.Location = new Point(locationX, currentBtn.Location.Y);
                //rigthBorderPanel.Visible = true;
                rigthBorderPanel.BringToFront();

            }

        }
        public struct RGBcolors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
           

        }
        public static void disableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(46, 52, 88);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.IconColor = Color.White;
                //currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            }

        }
       


    }
}
