using Eagle.Entity;
using Eagle.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eagle.Test
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            IGenericDataAccessLayer<DiscUserEntity> objIGenericDataAccessLayer = Factory.Factory.CreateInstance<DiscUserEntity>();

            DiscUserEntity objDiscUserEntity = new DiscUserEntity();

            objDiscUserEntity.UserId = 1;

            objDiscUserEntity = objIGenericDataAccessLayer.SelectEntitiesByEntityCondition(objDiscUserEntity)[0];

            MessageBox.Show(objDiscUserEntity.UserName+"123");
        }
    }
}
