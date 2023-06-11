using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PartyMonkey.Forms;

namespace PartyMonkey
{
    internal class Buttons
    {
        public static Button CreateButtonBack()
        {
            Button backButton = new Button();
            backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            backButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            backButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            backButton.Location = new System.Drawing.Point(15, 15);
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Size = new System.Drawing.Size(121, 40);
            backButton.TabIndex = 29;
            backButton.Text = "Back";
            return backButton;
        }

        public static Button CreateButtonLogOut()
        {
            Button backButton = new Button();
            backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            backButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            backButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            backButton.Location = new System.Drawing.Point(670, 15);
            backButton.Size = new System.Drawing.Size(121, 40);
            backButton.TabIndex = 29;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Text = "Log out";
            return backButton;
        }

        public static Button createButtonCart()
        {
            Button cartButton = new Button();
            cartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            cartButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cartButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            cartButton.Location = new System.Drawing.Point(536, 12);
            cartButton.Size = new System.Drawing.Size(121, 28);
            cartButton.TabIndex = 29;
            cartButton.Text = "Cart";
            return cartButton;
        }

        public static Button createButtonBuy()
        {
            Button buyButton = new Button();
            buyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            buyButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            buyButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            buyButton.Location = new System.Drawing.Point(274, 12);
            buyButton.Size = new System.Drawing.Size(121, 28);
            buyButton.TabIndex = 29;
            buyButton.Text = "Buy";
            return buyButton;
        }
    }
}
