namespace WindowsFormsApp1
{
    partial class Form5
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
            this.mASTERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aVTO_BASEDataSet = new WindowsFormsApp1.AVTO_BASEDataSet();
            this.mASTERTableAdapter = new WindowsFormsApp1.AVTO_BASEDataSetTableAdapters.MASTERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mASTERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aVTO_BASEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // mASTERBindingSource
            // 
            this.mASTERBindingSource.DataMember = "MASTER";
            this.mASTERBindingSource.DataSource = this.aVTO_BASEDataSet;
            // 
            // aVTO_BASEDataSet
            // 
            this.aVTO_BASEDataSet.DataSetName = "AVTO_BASEDataSet";
            this.aVTO_BASEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mASTERTableAdapter
            // 
            this.mASTERTableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Name = "Form5";
            this.Text = "СВЕДЕНИЯ О СОТРУДНИКАХ";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mASTERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aVTO_BASEDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AVTO_BASEDataSet aVTO_BASEDataSet;
        private System.Windows.Forms.BindingSource mASTERBindingSource;
        private AVTO_BASEDataSetTableAdapters.MASTERTableAdapter mASTERTableAdapter;
    }
}