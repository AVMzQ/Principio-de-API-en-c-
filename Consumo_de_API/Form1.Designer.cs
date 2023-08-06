namespace Consumo_de_API
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tabGet = new System.Windows.Forms.TabPage();
            this.tabPost = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRespuestaGet = new System.Windows.Forms.TextBox();
            this.tlpPost = new System.Windows.Forms.TableLayoutPanel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPost = new System.Windows.Forms.Button();
            this.txtRespuestaPost = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tabPut = new System.Windows.Forms.TabPage();
            this.tlpPut = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDesPut = new System.Windows.Forms.TextBox();
            this.txtTituloPut = new System.Windows.Forms.TextBox();
            this.txtIdPut = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtResPut = new System.Windows.Forms.TextBox();
            this.tbControl.SuspendLayout();
            this.tabGet.SuspendLayout();
            this.tabPost.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabPut.SuspendLayout();
            this.tlpPut.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tabGet);
            this.tbControl.Controls.Add(this.tabPost);
            this.tbControl.Controls.Add(this.tabPut);
            this.tbControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControl.Location = new System.Drawing.Point(0, 0);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(583, 230);
            this.tbControl.TabIndex = 0;
            this.tbControl.SelectedIndexChanged += new System.EventHandler(this.tbControl_SelectedIndexChanged);
            // 
            // tabGet
            // 
            this.tabGet.Controls.Add(this.tableLayoutPanel1);
            this.tabGet.Location = new System.Drawing.Point(4, 22);
            this.tabGet.Name = "tabGet";
            this.tabGet.Padding = new System.Windows.Forms.Padding(3);
            this.tabGet.Size = new System.Drawing.Size(575, 204);
            this.tabGet.TabIndex = 0;
            this.tabGet.Text = "Get";
            this.tabGet.UseVisualStyleBackColor = true;
            // 
            // tabPost
            // 
            this.tabPost.Controls.Add(this.tlpPost);
            this.tabPost.Location = new System.Drawing.Point(4, 22);
            this.tabPost.Name = "tabPost";
            this.tabPost.Padding = new System.Windows.Forms.Padding(3);
            this.tabPost.Size = new System.Drawing.Size(575, 204);
            this.tabPost.TabIndex = 1;
            this.tabPost.Text = "Post";
            this.tabPost.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.50877F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.49123F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtRespuestaGet, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(569, 198);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(44, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(486, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Solicitar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRespuestaGet
            // 
            this.txtRespuestaGet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRespuestaGet.Location = new System.Drawing.Point(44, 3);
            this.txtRespuestaGet.Multiline = true;
            this.txtRespuestaGet.Name = "txtRespuestaGet";
            this.txtRespuestaGet.ReadOnly = true;
            this.txtRespuestaGet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRespuestaGet.Size = new System.Drawing.Size(486, 147);
            this.txtRespuestaGet.TabIndex = 1;
            // 
            // tlpPost
            // 
            this.tlpPost.ColumnCount = 3;
            this.tlpPost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPost.Controls.Add(this.label4, 1, 0);
            this.tlpPost.Controls.Add(this.txtDescripcion, 1, 2);
            this.tlpPost.Controls.Add(this.txtTitulo, 1, 1);
            this.tlpPost.Controls.Add(this.txtId, 1, 0);
            this.tlpPost.Controls.Add(this.label1, 0, 0);
            this.tlpPost.Controls.Add(this.label2, 0, 1);
            this.tlpPost.Controls.Add(this.label3, 0, 2);
            this.tlpPost.Controls.Add(this.btnPost, 1, 3);
            this.tlpPost.Controls.Add(this.txtRespuestaPost, 2, 1);
            this.tlpPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPost.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpPost.Location = new System.Drawing.Point(3, 3);
            this.tlpPost.Name = "tlpPost";
            this.tlpPost.RowCount = 4;
            this.tlpPost.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPost.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPost.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPost.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPost.Size = new System.Drawing.Size(569, 198);
            this.tlpPost.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(109, 3);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(256, 23);
            this.txtId.TabIndex = 0;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(109, 33);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(256, 23);
            this.txtTitulo.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(109, 62);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(256, 94);
            this.txtDescripcion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Titulo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 59);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label3.Size = new System.Drawing.Size(100, 100);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripcion";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPost.FlatAppearance.BorderSize = 0;
            this.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPost.Location = new System.Drawing.Point(109, 162);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(256, 23);
            this.btnPost.TabIndex = 6;
            this.btnPost.Text = "Enviar";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // txtRespuestaPost
            // 
            this.txtRespuestaPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRespuestaPost.Location = new System.Drawing.Point(371, 33);
            this.txtRespuestaPost.Multiline = true;
            this.txtRespuestaPost.Name = "txtRespuestaPost";
            this.txtRespuestaPost.ReadOnly = true;
            this.tlpPost.SetRowSpan(this.txtRespuestaPost, 3);
            this.txtRespuestaPost.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRespuestaPost.Size = new System.Drawing.Size(195, 162);
            this.txtRespuestaPost.TabIndex = 7;
            this.txtRespuestaPost.Text = "{}";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(371, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Aqui se mostrar la respuesta del servidor.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPut
            // 
            this.tabPut.Controls.Add(this.tlpPut);
            this.tabPut.Location = new System.Drawing.Point(4, 22);
            this.tabPut.Name = "tabPut";
            this.tabPut.Padding = new System.Windows.Forms.Padding(3);
            this.tabPut.Size = new System.Drawing.Size(575, 204);
            this.tabPut.TabIndex = 2;
            this.tabPut.Text = "Put";
            this.tabPut.UseVisualStyleBackColor = true;
            // 
            // tlpPut
            // 
            this.tlpPut.ColumnCount = 3;
            this.tlpPut.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPut.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPut.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPut.Controls.Add(this.label5, 1, 0);
            this.tlpPut.Controls.Add(this.txtDesPut, 1, 2);
            this.tlpPut.Controls.Add(this.txtTituloPut, 1, 1);
            this.tlpPut.Controls.Add(this.txtIdPut, 1, 0);
            this.tlpPut.Controls.Add(this.label6, 0, 0);
            this.tlpPut.Controls.Add(this.label7, 0, 1);
            this.tlpPut.Controls.Add(this.label8, 0, 2);
            this.tlpPut.Controls.Add(this.button2, 1, 3);
            this.tlpPut.Controls.Add(this.txtResPut, 2, 1);
            this.tlpPut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPut.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpPut.Location = new System.Drawing.Point(3, 3);
            this.tlpPut.Name = "tlpPut";
            this.tlpPut.RowCount = 4;
            this.tlpPut.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPut.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPut.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPut.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPut.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPut.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPut.Size = new System.Drawing.Size(569, 198);
            this.tlpPut.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(371, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Aqui se mostrar la respuesta del servidor.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDesPut
            // 
            this.txtDesPut.Location = new System.Drawing.Point(109, 62);
            this.txtDesPut.Multiline = true;
            this.txtDesPut.Name = "txtDesPut";
            this.txtDesPut.Size = new System.Drawing.Size(256, 94);
            this.txtDesPut.TabIndex = 2;
            // 
            // txtTituloPut
            // 
            this.txtTituloPut.Location = new System.Drawing.Point(109, 33);
            this.txtTituloPut.Name = "txtTituloPut";
            this.txtTituloPut.Size = new System.Drawing.Size(256, 23);
            this.txtTituloPut.TabIndex = 1;
            // 
            // txtIdPut
            // 
            this.txtIdPut.Location = new System.Drawing.Point(109, 3);
            this.txtIdPut.Name = "txtIdPut";
            this.txtIdPut.ReadOnly = true;
            this.txtIdPut.Size = new System.Drawing.Size(256, 23);
            this.txtIdPut.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 30);
            this.label6.TabIndex = 3;
            this.label6.Text = "Id";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Titulo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 59);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label8.Size = new System.Drawing.Size(100, 100);
            this.label8.TabIndex = 5;
            this.label8.Text = "Descripcion";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(109, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtResPut
            // 
            this.txtResPut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResPut.Location = new System.Drawing.Point(371, 33);
            this.txtResPut.Multiline = true;
            this.txtResPut.Name = "txtResPut";
            this.txtResPut.ReadOnly = true;
            this.tlpPut.SetRowSpan(this.txtResPut, 3);
            this.txtResPut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResPut.Size = new System.Drawing.Size(195, 162);
            this.txtResPut.TabIndex = 7;
            this.txtResPut.Text = "{}";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 230);
            this.Controls.Add(this.tbControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(599, 269);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumo de API";
            this.tbControl.ResumeLayout(false);
            this.tabGet.ResumeLayout(false);
            this.tabPost.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlpPost.ResumeLayout(false);
            this.tlpPost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabPut.ResumeLayout(false);
            this.tlpPut.ResumeLayout(false);
            this.tlpPut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tabGet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRespuestaGet;
        private System.Windows.Forms.TabPage tabPost;
        private System.Windows.Forms.TableLayoutPanel tlpPost;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.TextBox txtRespuestaPost;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPut;
        private System.Windows.Forms.TableLayoutPanel tlpPut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDesPut;
        private System.Windows.Forms.TextBox txtTituloPut;
        private System.Windows.Forms.TextBox txtIdPut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtResPut;
    }
}

