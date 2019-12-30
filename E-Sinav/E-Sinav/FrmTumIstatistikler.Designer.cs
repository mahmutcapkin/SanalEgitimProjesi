namespace E_Sinav
{
    partial class FrmTumIstatistikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGetirT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.chartTarih = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTarihO = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGetirK = new Bunifu.Framework.UI.BunifuFlatButton();
            this.chartKonu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKonuO = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTarih)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartKonu)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(863, 502);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGetirT);
            this.tabPage1.Controls.Add(this.chartTarih);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmbTarihO);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(855, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tarihe Göre İstatistikler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGetirT
            // 
            this.btnGetirT.Active = false;
            this.btnGetirT.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGetirT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGetirT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGetirT.BorderRadius = 0;
            this.btnGetirT.ButtonText = "Getir";
            this.btnGetirT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetirT.DisabledColor = System.Drawing.Color.Gray;
            this.btnGetirT.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGetirT.Iconimage = null;
            this.btnGetirT.Iconimage_right = null;
            this.btnGetirT.Iconimage_right_Selected = null;
            this.btnGetirT.Iconimage_Selected = null;
            this.btnGetirT.IconMarginLeft = 0;
            this.btnGetirT.IconMarginRight = 0;
            this.btnGetirT.IconRightVisible = true;
            this.btnGetirT.IconRightZoom = 0D;
            this.btnGetirT.IconVisible = true;
            this.btnGetirT.IconZoom = 90D;
            this.btnGetirT.IsTab = false;
            this.btnGetirT.Location = new System.Drawing.Point(528, 25);
            this.btnGetirT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetirT.Name = "btnGetirT";
            this.btnGetirT.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGetirT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGetirT.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGetirT.selected = false;
            this.btnGetirT.Size = new System.Drawing.Size(115, 25);
            this.btnGetirT.TabIndex = 27;
            this.btnGetirT.Text = "Getir";
            this.btnGetirT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGetirT.Textcolor = System.Drawing.Color.White;
            this.btnGetirT.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetirT.Click += new System.EventHandler(this.btnGetirT_Click);
            // 
            // chartTarih
            // 
            chartArea3.Name = "ChartArea1";
            this.chartTarih.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartTarih.Legends.Add(legend3);
            this.chartTarih.Location = new System.Drawing.Point(6, 57);
            this.chartTarih.Name = "chartTarih";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Notlar";
            this.chartTarih.Series.Add(series3);
            this.chartTarih.Size = new System.Drawing.Size(852, 418);
            this.chartTarih.TabIndex = 4;
            this.chartTarih.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "İstatistiğini Görüntülemek İstediğiniz Öğrenciyi Seçiniz";
            // 
            // cmbTarihO
            // 
            this.cmbTarihO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarihO.FormattingEnabled = true;
            this.cmbTarihO.Location = new System.Drawing.Point(358, 25);
            this.cmbTarihO.Name = "cmbTarihO";
            this.cmbTarihO.Size = new System.Drawing.Size(121, 24);
            this.cmbTarihO.TabIndex = 2;
            this.cmbTarihO.SelectedIndexChanged += new System.EventHandler(this.cmbTarihO_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGetirK);
            this.tabPage2.Controls.Add(this.chartKonu);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cmbKonuO);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(855, 473);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hangi Öğrencinin Hangi Konuda Eksiği Var ?";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGetirK
            // 
            this.btnGetirK.Active = false;
            this.btnGetirK.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGetirK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGetirK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGetirK.BorderRadius = 0;
            this.btnGetirK.ButtonText = "Getir";
            this.btnGetirK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetirK.DisabledColor = System.Drawing.Color.Gray;
            this.btnGetirK.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGetirK.Iconimage = null;
            this.btnGetirK.Iconimage_right = null;
            this.btnGetirK.Iconimage_right_Selected = null;
            this.btnGetirK.Iconimage_Selected = null;
            this.btnGetirK.IconMarginLeft = 0;
            this.btnGetirK.IconMarginRight = 0;
            this.btnGetirK.IconRightVisible = false;
            this.btnGetirK.IconRightZoom = 0D;
            this.btnGetirK.IconVisible = false;
            this.btnGetirK.IconZoom = 90D;
            this.btnGetirK.IsTab = false;
            this.btnGetirK.Location = new System.Drawing.Point(527, 17);
            this.btnGetirK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetirK.Name = "btnGetirK";
            this.btnGetirK.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGetirK.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGetirK.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGetirK.selected = false;
            this.btnGetirK.Size = new System.Drawing.Size(115, 24);
            this.btnGetirK.TabIndex = 28;
            this.btnGetirK.Text = "Getir";
            this.btnGetirK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGetirK.Textcolor = System.Drawing.Color.White;
            this.btnGetirK.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetirK.Click += new System.EventHandler(this.btnGetirK_Click);
            // 
            // chartKonu
            // 
            chartArea4.Name = "ChartArea1";
            this.chartKonu.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartKonu.Legends.Add(legend4);
            this.chartKonu.Location = new System.Drawing.Point(9, 55);
            this.chartKonu.Name = "chartKonu";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "SoruMiktar";
            this.chartKonu.Series.Add(series4);
            this.chartKonu.Size = new System.Drawing.Size(846, 406);
            this.chartKonu.TabIndex = 7;
            this.chartKonu.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "İstatistiğini Görüntülemek İstediğiniz Öğrenciyi Seçiniz";
            // 
            // cmbKonuO
            // 
            this.cmbKonuO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKonuO.FormattingEnabled = true;
            this.cmbKonuO.Location = new System.Drawing.Point(357, 17);
            this.cmbKonuO.Name = "cmbKonuO";
            this.cmbKonuO.Size = new System.Drawing.Size(121, 24);
            this.cmbKonuO.TabIndex = 5;
            this.cmbKonuO.SelectedIndexChanged += new System.EventHandler(this.cmbKonuO_SelectedIndexChanged);
            // 
            // FrmTumIstatistikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(869, 540);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmTumIstatistikler";
            this.Text = "FrmTumIstatistikler";
            this.Load += new System.EventHandler(this.FrmTumIstatistikler_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTarih)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartKonu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTarihO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKonuO;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTarih;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKonu;
        private Bunifu.Framework.UI.BunifuFlatButton btnGetirT;
        private Bunifu.Framework.UI.BunifuFlatButton btnGetirK;
    }
}