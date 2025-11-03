namespace SportClubApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlHeader = new Panel();
            flpHeaderButtons = new FlowLayoutPanel();
            btnModoOscuro = new Button();
            btnAcceder = new Button();
            btnRegistro = new Button();
            lblAppName = new Label();
            pictureBox1 = new PictureBox();
            toolTip1 = new ToolTip(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            instagramBox = new PictureBox();
            linkedinBox = new PictureBox();
            youtubeBox = new PictureBox();
            pnlHeader.SuspendLayout();
            flpHeaderButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)instagramBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)linkedinBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)youtubeBox).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Navy;
            pnlHeader.Controls.Add(flpHeaderButtons);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(805, 63);
            pnlHeader.TabIndex = 0;
            // 
            // flpHeaderButtons
            // 
            flpHeaderButtons.Controls.Add(btnModoOscuro);
            flpHeaderButtons.Controls.Add(btnAcceder);
            flpHeaderButtons.Controls.Add(btnRegistro);
            flpHeaderButtons.Dock = DockStyle.Right;
            flpHeaderButtons.FlowDirection = FlowDirection.BottomUp;
            flpHeaderButtons.Location = new Point(421, 0);
            flpHeaderButtons.Margin = new Padding(3, 4, 3, 4);
            flpHeaderButtons.Name = "flpHeaderButtons";
            flpHeaderButtons.RightToLeft = RightToLeft.Yes;
            flpHeaderButtons.Size = new Size(384, 63);
            flpHeaderButtons.TabIndex = 0;
            // 
            // btnModoOscuro
            // 
            btnModoOscuro.BackColor = Color.DarkGray;
            btnModoOscuro.FlatStyle = FlatStyle.Flat;
            btnModoOscuro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnModoOscuro.ForeColor = Color.Black;
            btnModoOscuro.Location = new Point(237, 11);
            btnModoOscuro.Margin = new Padding(17, 4, 6, 10);
            btnModoOscuro.Name = "btnModoOscuro";
            btnModoOscuro.Size = new Size(130, 42);
            btnModoOscuro.TabIndex = 0;
            btnModoOscuro.Text = "Modo Oscuro";
            btnModoOscuro.UseVisualStyleBackColor = false;
            btnModoOscuro.Click += btnModoOscuro_Click;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.Green;
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceder.ForeColor = Color.White;
            btnAcceder.Location = new Point(139, 11);
            btnAcceder.Margin = new Padding(3, 4, 3, 10);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(89, 42);
            btnAcceder.TabIndex = 1;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.Green;
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegistro.ForeColor = Color.White;
            btnRegistro.Location = new Point(41, 11);
            btnRegistro.Margin = new Padding(6, 4, 6, 10);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(89, 42);
            btnRegistro.TabIndex = 2;
            btnRegistro.Text = "Registro";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Candara", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAppName.Location = new Point(480, 253);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(224, 42);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "SportClubApp";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(119, 143);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 271);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(instagramBox);
            flowLayoutPanel1.Controls.Add(linkedinBox);
            flowLayoutPanel1.Controls.Add(youtubeBox);
            flowLayoutPanel1.Location = new Point(506, 353);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(205, 61);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // instagramBox
            // 
            instagramBox.Image = (Image)resources.GetObject("instagramBox.Image");
            instagramBox.Location = new Point(3, 4);
            instagramBox.Margin = new Padding(3, 4, 9, 4);
            instagramBox.Name = "instagramBox";
            instagramBox.Size = new Size(56, 57);
            instagramBox.SizeMode = PictureBoxSizeMode.Zoom;
            instagramBox.TabIndex = 0;
            instagramBox.TabStop = false;
            instagramBox.Click += pictureBoxInstagram_Click;
            // 
            // linkedinBox
            // 
            linkedinBox.Image = (Image)resources.GetObject("linkedinBox.Image");
            linkedinBox.Location = new Point(71, 4);
            linkedinBox.Margin = new Padding(3, 4, 9, 4);
            linkedinBox.Name = "linkedinBox";
            linkedinBox.Size = new Size(57, 57);
            linkedinBox.SizeMode = PictureBoxSizeMode.Zoom;
            linkedinBox.TabIndex = 1;
            linkedinBox.TabStop = false;
            linkedinBox.Click += pictureBoxLinkedIn_Click;
            // 
            // youtubeBox
            // 
            youtubeBox.Image = (Image)resources.GetObject("youtubeBox.Image");
            youtubeBox.Location = new Point(140, 4);
            youtubeBox.Margin = new Padding(3, 4, 3, 4);
            youtubeBox.Name = "youtubeBox";
            youtubeBox.Size = new Size(59, 57);
            youtubeBox.SizeMode = PictureBoxSizeMode.Zoom;
            youtubeBox.TabIndex = 2;
            youtubeBox.TabStop = false;
            youtubeBox.Click += pictureBoxYoutube_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 521);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(lblAppName);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "SportClubApp";
            Load += Form1_Load;
            pnlHeader.ResumeLayout(false);
            flpHeaderButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)instagramBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)linkedinBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)youtubeBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private FlowLayoutPanel flpHeaderButtons;
        private Button btnModoOscuro;
        private Button btnAcceder;
        private Button btnRegistro;
        private Label lblAppName;
        private PictureBox pictureBox1;
        private ToolTip toolTip1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox instagramBox;
        private PictureBox linkedinBox;
        private PictureBox youtubeBox;
    }
}
