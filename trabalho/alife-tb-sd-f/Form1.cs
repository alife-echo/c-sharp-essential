using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alife_tb_sd_f
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;

        
        public Form1()
        {
            InitializeComponent();
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index)
            {
                random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null) 
            { 
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;  
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Fira Code", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(32, 34, 37);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Fira Code", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

    }

}
