
namespace Json_reader
{
    partial class JsonPoliceStation
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Information_about_Poilcestation = new System.Windows.Forms.TabControl();
            this.Policemen_tabpage = new System.Windows.Forms.TabPage();
            this.Policemen_dataGridView = new System.Windows.Forms.DataGridView();
            this.Prisoners_tabPage = new System.Windows.Forms.TabPage();
            this.Prisoners_dataGridView = new System.Windows.Forms.DataGridView();
            this.Prisonrooms_tabPage = new System.Windows.Forms.TabPage();
            this.Prisonroom_dataGridView = new System.Windows.Forms.DataGridView();
            this.Information_about_Poilcestation.SuspendLayout();
            this.Policemen_tabpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Policemen_dataGridView)).BeginInit();
            this.Prisoners_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Prisoners_dataGridView)).BeginInit();
            this.Prisonrooms_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Prisonroom_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Information_about_Poilcestation
            // 
            this.Information_about_Poilcestation.Controls.Add(this.Policemen_tabpage);
            this.Information_about_Poilcestation.Controls.Add(this.Prisoners_tabPage);
            this.Information_about_Poilcestation.Controls.Add(this.Prisonrooms_tabPage);
            this.Information_about_Poilcestation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Information_about_Poilcestation.Location = new System.Drawing.Point(0, 0);
            this.Information_about_Poilcestation.Name = "Information_about_Poilcestation";
            this.Information_about_Poilcestation.SelectedIndex = 0;
            this.Information_about_Poilcestation.Size = new System.Drawing.Size(800, 450);
            this.Information_about_Poilcestation.TabIndex = 0;
            // 
            // Policemen_tabpage
            // 
            this.Policemen_tabpage.Controls.Add(this.Policemen_dataGridView);
            this.Policemen_tabpage.Location = new System.Drawing.Point(4, 22);
            this.Policemen_tabpage.Name = "Policemen_tabpage";
            this.Policemen_tabpage.Padding = new System.Windows.Forms.Padding(3);
            this.Policemen_tabpage.Size = new System.Drawing.Size(792, 424);
            this.Policemen_tabpage.TabIndex = 0;
            this.Policemen_tabpage.Text = "Полицейские";
            this.Policemen_tabpage.UseVisualStyleBackColor = true;
            // 
            // Policemen_dataGridView
            // 
            this.Policemen_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Policemen_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Policemen_dataGridView.Location = new System.Drawing.Point(3, 3);
            this.Policemen_dataGridView.Name = "Policemen_dataGridView";
            this.Policemen_dataGridView.Size = new System.Drawing.Size(786, 418);
            this.Policemen_dataGridView.TabIndex = 0;
            // 
            // Prisoners_tabPage
            // 
            this.Prisoners_tabPage.Controls.Add(this.Prisoners_dataGridView);
            this.Prisoners_tabPage.Location = new System.Drawing.Point(4, 22);
            this.Prisoners_tabPage.Name = "Prisoners_tabPage";
            this.Prisoners_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Prisoners_tabPage.Size = new System.Drawing.Size(792, 424);
            this.Prisoners_tabPage.TabIndex = 1;
            this.Prisoners_tabPage.Text = "Заключенные";
            this.Prisoners_tabPage.UseVisualStyleBackColor = true;
            // 
            // Prisoners_dataGridView
            // 
            this.Prisoners_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Prisoners_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Prisoners_dataGridView.Location = new System.Drawing.Point(3, 3);
            this.Prisoners_dataGridView.Name = "Prisoners_dataGridView";
            this.Prisoners_dataGridView.Size = new System.Drawing.Size(786, 418);
            this.Prisoners_dataGridView.TabIndex = 0;
            // 
            // Prisonrooms_tabPage
            // 
            this.Prisonrooms_tabPage.Controls.Add(this.Prisonroom_dataGridView);
            this.Prisonrooms_tabPage.Location = new System.Drawing.Point(4, 22);
            this.Prisonrooms_tabPage.Name = "Prisonrooms_tabPage";
            this.Prisonrooms_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Prisonrooms_tabPage.Size = new System.Drawing.Size(792, 424);
            this.Prisonrooms_tabPage.TabIndex = 2;
            this.Prisonrooms_tabPage.Text = "Камеры задержания";
            this.Prisonrooms_tabPage.UseVisualStyleBackColor = true;
            // 
            // Prisonroom_dataGridView
            // 
            this.Prisonroom_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Prisonroom_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Prisonroom_dataGridView.Location = new System.Drawing.Point(3, 3);
            this.Prisonroom_dataGridView.Name = "Prisonroom_dataGridView";
            this.Prisonroom_dataGridView.Size = new System.Drawing.Size(786, 418);
            this.Prisonroom_dataGridView.TabIndex = 0;
            // 
            // JsonPoliceStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Information_about_Poilcestation);
            this.Name = "JsonPoliceStation";
            this.Text = "Данные о полицейском участке";
            this.Load += new System.EventHandler(this.JsonPoliceStation_Load);
            this.Information_about_Poilcestation.ResumeLayout(false);
            this.Policemen_tabpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Policemen_dataGridView)).EndInit();
            this.Prisoners_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Prisoners_dataGridView)).EndInit();
            this.Prisonrooms_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Prisonroom_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl Information_about_Poilcestation;
        private System.Windows.Forms.TabPage Policemen_tabpage;
        private System.Windows.Forms.TabPage Prisoners_tabPage;
        private System.Windows.Forms.TabPage Prisonrooms_tabPage;
        private System.Windows.Forms.DataGridView Policemen_dataGridView;
        private System.Windows.Forms.DataGridView Prisoners_dataGridView;
        private System.Windows.Forms.DataGridView Prisonroom_dataGridView;
    }
}

