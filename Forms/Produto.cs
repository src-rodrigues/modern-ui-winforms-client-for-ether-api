﻿namespace FlatUI.Forms
{
  public partial class Produto : Form
  {
    public Produto()
    {
      InitializeComponent();

      for (int i = 0; i < 100; i++)
      {
        //LabGrid.Rows.Add(new object[] { i, "Victor", 23, "Male", "Yes" });
      }
    }

    private void ProdutoBtn_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Panguão");
    }

    private void Produto_Load(object sender, EventArgs e)
    {

    }

    private void kpmButton1_Click(object sender, EventArgs e)
    {

    }
  }
}