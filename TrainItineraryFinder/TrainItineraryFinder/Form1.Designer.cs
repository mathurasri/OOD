namespace TrainItineraryFinder
{
    partial class Form1
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
            this.btnLoadData = new System.Windows.Forms.Button();
            this.dgvTrainRoute = new System.Windows.Forms.DataGridView();
            this.dgvTrain = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainRoute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(13, 12);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(152, 46);
            this.btnLoadData.TabIndex = 0;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            // 
            // dgvTrainRoute
            // 
            this.dgvTrainRoute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainRoute.Location = new System.Drawing.Point(13, 65);
            this.dgvTrainRoute.Name = "dgvTrainRoute";
            this.dgvTrainRoute.Size = new System.Drawing.Size(666, 199);
            this.dgvTrainRoute.TabIndex = 1;
            // 
            // dgvTrain
            // 
            this.dgvTrain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrain.Location = new System.Drawing.Point(13, 284);
            this.dgvTrain.Name = "dgvTrain";
            this.dgvTrain.Size = new System.Drawing.Size(666, 150);
            this.dgvTrain.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 377);
            this.Controls.Add(this.dgvTrain);
            this.Controls.Add(this.dgvTrainRoute);
            this.Controls.Add(this.btnLoadData);
            this.Name = "Form1";
            this.Text = "Kazakhztan Rail Itinerary Finder";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainRoute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.DataGridView dgvTrainRoute;
        private System.Windows.Forms.DataGridView dgvTrain;
    }
}

