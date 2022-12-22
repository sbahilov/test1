
namespace qqq
{
    partial class Form1
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
            this.vertexCreateButton = new System.Windows.Forms.Button();
            this.vertexConnectButton = new System.Windows.Forms.Button();
            this.graphContainer = new System.Windows.Forms.PictureBox();
            this.matrixContainer = new System.Windows.Forms.ListBox();
            this.buildMatrixButton = new System.Windows.Forms.Button();
            this.pairedDisjunctsContainer = new System.Windows.Forms.ListBox();
            this.buildPairedDisjunctsButton = new System.Windows.Forms.Button();
            this.DNFContainer = new System.Windows.Forms.ListBox();
            this.buildDNFButton = new System.Windows.Forms.Button();
            this.resultContainer = new System.Windows.Forms.ListBox();
            this.resultButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.graphContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // vertexCreateButton
            // 
            this.vertexCreateButton.Location = new System.Drawing.Point(12, 12);
            this.vertexCreateButton.Name = "vertexCreateButton";
            this.vertexCreateButton.Size = new System.Drawing.Size(173, 23);
            this.vertexCreateButton.TabIndex = 0;
            this.vertexCreateButton.Text = "Задать вершину";
            this.vertexCreateButton.UseVisualStyleBackColor = true;
            this.vertexCreateButton.Click += new System.EventHandler(this.vertexCreateButton_Click);
            // 
            // vertexConnectButton
            // 
            this.vertexConnectButton.Location = new System.Drawing.Point(191, 11);
            this.vertexConnectButton.Name = "vertexConnectButton";
            this.vertexConnectButton.Size = new System.Drawing.Size(163, 23);
            this.vertexConnectButton.TabIndex = 1;
            this.vertexConnectButton.Text = "Соединить вершины";
            this.vertexConnectButton.UseVisualStyleBackColor = true;
            this.vertexConnectButton.Click += new System.EventHandler(this.vertexConnectButton_Click);
            // 
            // graphContainer
            // 
            this.graphContainer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.graphContainer.Location = new System.Drawing.Point(12, 41);
            this.graphContainer.Name = "graphContainer";
            this.graphContainer.Size = new System.Drawing.Size(341, 537);
            this.graphContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.graphContainer.TabIndex = 2;
            this.graphContainer.TabStop = false;
            this.graphContainer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphContainer_MouseClick);
            // 
            // matrixContainer
            // 
            this.matrixContainer.FormattingEnabled = true;
            this.matrixContainer.Location = new System.Drawing.Point(396, 12);
            this.matrixContainer.Name = "matrixContainer";
            this.matrixContainer.Size = new System.Drawing.Size(392, 95);
            this.matrixContainer.TabIndex = 3;
            // 
            // buildMatrixButton
            // 
            this.buildMatrixButton.Location = new System.Drawing.Point(396, 113);
            this.buildMatrixButton.Name = "buildMatrixButton";
            this.buildMatrixButton.Size = new System.Drawing.Size(392, 23);
            this.buildMatrixButton.TabIndex = 4;
            this.buildMatrixButton.Text = "Построить матрицу смежности";
            this.buildMatrixButton.UseVisualStyleBackColor = true;
            this.buildMatrixButton.Click += new System.EventHandler(this.buildMatrixButton_Click);
            // 
            // pairedDisjunctsContainer
            // 
            this.pairedDisjunctsContainer.FormattingEnabled = true;
            this.pairedDisjunctsContainer.Location = new System.Drawing.Point(395, 160);
            this.pairedDisjunctsContainer.Name = "pairedDisjunctsContainer";
            this.pairedDisjunctsContainer.Size = new System.Drawing.Size(392, 95);
            this.pairedDisjunctsContainer.TabIndex = 5;
            // 
            // buildPairedDisjunctsButton
            // 
            this.buildPairedDisjunctsButton.Location = new System.Drawing.Point(394, 261);
            this.buildPairedDisjunctsButton.Name = "buildPairedDisjunctsButton";
            this.buildPairedDisjunctsButton.Size = new System.Drawing.Size(393, 23);
            this.buildPairedDisjunctsButton.TabIndex = 6;
            this.buildPairedDisjunctsButton.Text = "Построить парные дизъюнкты";
            this.buildPairedDisjunctsButton.UseVisualStyleBackColor = true;
            this.buildPairedDisjunctsButton.Click += new System.EventHandler(this.buildPairedDisjunctsButton_Click);
            // 
            // DNFContainer
            // 
            this.DNFContainer.FormattingEnabled = true;
            this.DNFContainer.Location = new System.Drawing.Point(393, 306);
            this.DNFContainer.Name = "DNFContainer";
            this.DNFContainer.Size = new System.Drawing.Size(392, 95);
            this.DNFContainer.TabIndex = 7;
            // 
            // buildDNFButton
            // 
            this.buildDNFButton.Location = new System.Drawing.Point(393, 407);
            this.buildDNFButton.Name = "buildDNFButton";
            this.buildDNFButton.Size = new System.Drawing.Size(393, 23);
            this.buildDNFButton.TabIndex = 8;
            this.buildDNFButton.Text = " Построить ДНФ";
            this.buildDNFButton.UseVisualStyleBackColor = true;
            this.buildDNFButton.Click += new System.EventHandler(this.buildDNFButton_Click);
            // 
            // resultContainer
            // 
            this.resultContainer.FormattingEnabled = true;
            this.resultContainer.Location = new System.Drawing.Point(393, 454);
            this.resultContainer.Name = "resultContainer";
            this.resultContainer.Size = new System.Drawing.Size(393, 95);
            this.resultContainer.TabIndex = 9;
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(393, 555);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(393, 23);
            this.resultButton.TabIndex = 10;
            this.resultButton.Text = "Результат";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.resultContainer);
            this.Controls.Add(this.buildDNFButton);
            this.Controls.Add(this.DNFContainer);
            this.Controls.Add(this.buildPairedDisjunctsButton);
            this.Controls.Add(this.pairedDisjunctsContainer);
            this.Controls.Add(this.buildMatrixButton);
            this.Controls.Add(this.matrixContainer);
            this.Controls.Add(this.graphContainer);
            this.Controls.Add(this.vertexConnectButton);
            this.Controls.Add(this.vertexCreateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.graphContainer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vertexCreateButton;
        private System.Windows.Forms.Button vertexConnectButton;
        private System.Windows.Forms.PictureBox graphContainer;
        private System.Windows.Forms.ListBox matrixContainer;
        private System.Windows.Forms.Button buildMatrixButton;
        private System.Windows.Forms.ListBox pairedDisjunctsContainer;
        private System.Windows.Forms.Button buildPairedDisjunctsButton;
        private System.Windows.Forms.ListBox DNFContainer;
        private System.Windows.Forms.Button buildDNFButton;
        private System.Windows.Forms.ListBox resultContainer;
        private System.Windows.Forms.Button resultButton;
    }
}

