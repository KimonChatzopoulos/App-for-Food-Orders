
namespace order_app
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.LinkLabel();
            this.btnExit = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.BtnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlace = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse8 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse9 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.remove_item1 = new order_app.allusercontrol.remove_item();
            this.userControl31 = new order_app.allusercontrol.UserControl3();
            this.place_order1 = new order_app.allusercontrol.place_order();
            this.userControl22 = new order_app.allusercontrol.UserControl2();
            this.userControl12 = new order_app.allusercontrol.UserControl1();
            this.userControl21 = new order_app.allusercontrol.UserControl2();
            this.userControl11 = new order_app.allusercontrol.UserControl1();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.remove_item1);
            this.panel2.Controls.Add(this.userControl31);
            this.panel2.Controls.Add(this.place_order1);
            this.panel2.Controls.Add(this.userControl22);
            this.panel2.Controls.Add(this.userControl12);
            this.panel2.Controls.Add(this.userControl21);
            this.panel2.Controls.Add(this.userControl11);
            this.guna2Transition1.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(222, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 511);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel3.Controls.Add(this.btnlogout);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Controls.Add(this.BtnUpdate);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.btnPlace);
            this.guna2Transition1.SetDecoration(this.panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(11, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 511);
            this.panel3.TabIndex = 2;
            // 
            // btnlogout
            // 
            this.btnlogout.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.btnlogout, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnlogout.LinkColor = System.Drawing.Color.White;
            this.btnlogout.Location = new System.Drawing.Point(74, 468);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(59, 20);
            this.btnlogout.TabIndex = 5;
            this.btnlogout.TabStop = true;
            this.btnlogout.Text = "Logout";
            this.btnlogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnlogout_LinkClicked);
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.guna2Transition1.SetDecoration(this.btnExit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(1, -3);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(33, 34);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "x";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BorderRadius = 15;
            this.btnRemove.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRemove.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnRemove.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnRemove.CheckedState.Parent = this.btnRemove;
            this.btnRemove.CustomImages.Parent = this.btnRemove;
            this.guna2Transition1.SetDecoration(this.btnRemove, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnRemove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.HoverState.Parent = this.btnRemove;
            this.btnRemove.Location = new System.Drawing.Point(23, 244);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ShadowDecoration.Parent = this.btnRemove;
            this.btnRemove.Size = new System.Drawing.Size(202, 41);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Items";
            this.btnRemove.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BorderRadius = 15;
            this.BtnUpdate.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnUpdate.CheckedState.FillColor = System.Drawing.Color.White;
            this.BtnUpdate.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.BtnUpdate.CheckedState.Parent = this.BtnUpdate;
            this.BtnUpdate.CustomImages.Parent = this.BtnUpdate;
            this.guna2Transition1.SetDecoration(this.BtnUpdate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BtnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.BtnUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.HoverState.Parent = this.BtnUpdate;
            this.BtnUpdate.Location = new System.Drawing.Point(23, 188);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.ShadowDecoration.Parent = this.BtnUpdate;
            this.BtnUpdate.Size = new System.Drawing.Size(202, 41);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "Update Items";
            this.BtnUpdate.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 15;
            this.btnAdd.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAdd.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAdd.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.guna2Transition1.SetDecoration(this.btnAdd, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(23, 131);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(202, 41);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Items";
            this.btnAdd.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnPlace
            // 
            this.btnPlace.BorderRadius = 15;
            this.btnPlace.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPlace.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnPlace.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnPlace.CheckedState.Parent = this.btnPlace;
            this.btnPlace.CustomImages.Parent = this.btnPlace;
            this.guna2Transition1.SetDecoration(this.btnPlace, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnPlace.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnPlace.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnPlace.ForeColor = System.Drawing.Color.White;
            this.btnPlace.HoverState.Parent = this.btnPlace;
            this.btnPlace.Location = new System.Drawing.Point(23, 70);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.ShadowDecoration.Parent = this.btnPlace;
            this.btnPlace.Size = new System.Drawing.Size(202, 41);
            this.btnPlace.TabIndex = 0;
            this.btnPlace.Text = "Place Order";
            this.btnPlace.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.ScaleAndHorizSlide;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            this.guna2Transition1.MaxAnimationTime = 3000;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 30;
            this.guna2Elipse6.TargetControl = this.panel2;
            // 
            // guna2Elipse7
            // 
            this.guna2Elipse7.BorderRadius = 30;
            this.guna2Elipse7.TargetControl = this.panel2;
            // 
            // guna2Elipse8
            // 
            this.guna2Elipse8.BorderRadius = 30;
            this.guna2Elipse8.TargetControl = this.panel2;
            // 
            // guna2Elipse9
            // 
            this.guna2Elipse9.BorderRadius = 30;
            this.guna2Elipse9.TargetControl = this.panel2;
            // 
            // remove_item1
            // 
            this.remove_item1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.remove_item1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.remove_item1.Location = new System.Drawing.Point(0, 0);
            this.remove_item1.Name = "remove_item1";
            this.remove_item1.Size = new System.Drawing.Size(781, 514);
            this.remove_item1.TabIndex = 6;
            // 
            // userControl31
            // 
            this.userControl31.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.userControl31, Guna.UI2.AnimatorNS.DecorationType.None);
            this.userControl31.Location = new System.Drawing.Point(0, 0);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(781, 514);
            this.userControl31.TabIndex = 5;
            // 
            // place_order1
            // 
            this.place_order1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.place_order1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.place_order1.Location = new System.Drawing.Point(0, -3);
            this.place_order1.Name = "place_order1";
            this.place_order1.Size = new System.Drawing.Size(781, 514);
            this.place_order1.TabIndex = 4;
            // 
            // userControl22
            // 
            this.userControl22.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.userControl22, Guna.UI2.AnimatorNS.DecorationType.None);
            this.userControl22.Location = new System.Drawing.Point(0, -3);
            this.userControl22.Name = "userControl22";
            this.userControl22.Size = new System.Drawing.Size(781, 514);
            this.userControl22.TabIndex = 3;
            this.userControl22.Visible = false;
            // 
            // userControl12
            // 
            this.userControl12.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.userControl12, Guna.UI2.AnimatorNS.DecorationType.None);
            this.userControl12.Location = new System.Drawing.Point(0, -3);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(781, 514);
            this.userControl12.TabIndex = 2;
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.userControl21, Guna.UI2.AnimatorNS.DecorationType.None);
            this.userControl21.Location = new System.Drawing.Point(-11, 0);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(781, 514);
            this.userControl21.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.userControl11, Guna.UI2.AnimatorNS.DecorationType.None);
            this.userControl11.Location = new System.Drawing.Point(-11, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(781, 514);
            this.userControl11.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1004, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnPlace;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnExit;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2Button BtnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.LinkLabel btnlogout;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private allusercontrol.UserControl1 userControl11;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private allusercontrol.UserControl2 userControl21;
        private allusercontrol.UserControl1 userControl12;
        private allusercontrol.UserControl2 userControl22;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private allusercontrol.place_order place_order1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private allusercontrol.UserControl3 userControl31;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse7;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse8;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse9;
        private allusercontrol.remove_item remove_item1;
    }
}