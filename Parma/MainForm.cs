namespace Parma
{
    public partial class MainForm : Form
    {
        private ComboBox cmbProduct = null!;
        private NumericUpDown nudQuantity = null!;
        private Button btnAdd = null!;
        private DataGridView dgvProducts = null!;
        private Label lblTotal = null!;
        private Label lblTotalValue = null!;

        // Product catalog
        private Dictionary<string, decimal> productCatalog = new Dictionary<string, decimal>
        {
            { "Cuaderno", 5.50m },
            { "Lápiz", 0.75m },
            { "Borrador", 1.25m },
            { "Regla", 2.00m },
            { "Libro", 15.00m },
            { "Mochila", 25.00m },
            { "Calculadora", 12.50m },
            { "Pegamento", 3.00m }
        };

        public MainForm()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void InitializeComponent()
        {
            this.Text = "Parma - Sistema de Ventas para Librería";
            this.Size = new Size(800, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Label for product
            Label lblProduct = new Label
            {
                Text = "Producto:",
                Location = new Point(20, 20),
                Size = new Size(100, 20)
            };
            this.Controls.Add(lblProduct);

            // ComboBox for product selection
            cmbProduct = new ComboBox
            {
                Location = new Point(130, 18),
                Size = new Size(200, 25),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            this.Controls.Add(cmbProduct);

            // Label for quantity
            Label lblQuantity = new Label
            {
                Text = "Cantidad:",
                Location = new Point(350, 20),
                Size = new Size(100, 20)
            };
            this.Controls.Add(lblQuantity);

            // NumericUpDown for quantity
            nudQuantity = new NumericUpDown
            {
                Location = new Point(460, 18),
                Size = new Size(80, 25),
                Minimum = 1,
                Maximum = 999,
                Value = 1
            };
            this.Controls.Add(nudQuantity);

            // Button to add product
            btnAdd = new Button
            {
                Text = "Agregar",
                Location = new Point(560, 16),
                Size = new Size(100, 30)
            };
            btnAdd.Click += BtnAdd_Click;
            this.Controls.Add(btnAdd);

            // DataGridView to show products
            dgvProducts = new DataGridView
            {
                Location = new Point(20, 60),
                Size = new Size(740, 320),
                AllowUserToAddRows = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            // Configure columns
            dgvProducts.Columns.Add("Product", "Producto");
            dgvProducts.Columns.Add("Quantity", "Cantidad");
            dgvProducts.Columns.Add("UnitPrice", "Precio Unitario");
            dgvProducts.Columns.Add("TotalPrice", "Precio Total");

            // Format price columns
            dgvProducts.Columns["UnitPrice"].DefaultCellStyle.Format = "C2";
            dgvProducts.Columns["UnitPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProducts.Columns["TotalPrice"].DefaultCellStyle.Format = "C2";
            dgvProducts.Columns["TotalPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProducts.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.Controls.Add(dgvProducts);

            // Label for total
            lblTotal = new Label
            {
                Text = "TOTAL:",
                Location = new Point(560, 395),
                Size = new Size(100, 25),
                Font = new Font(this.Font.FontFamily, 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleRight
            };
            this.Controls.Add(lblTotal);

            // Label to show total value
            lblTotalValue = new Label
            {
                Text = "$0.00",
                Location = new Point(660, 395),
                Size = new Size(100, 25),
                Font = new Font(this.Font.FontFamily, 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleRight,
                ForeColor = Color.DarkGreen
            };
            this.Controls.Add(lblTotalValue);
        }

        private void LoadProducts()
        {
            cmbProduct.Items.Clear();
            foreach (var product in productCatalog.Keys)
            {
                cmbProduct.Items.Add(product);
            }
            if (cmbProduct.Items.Count > 0)
            {
                cmbProduct.SelectedIndex = 0;
            }
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            if (cmbProduct.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione un producto.", "Advertencia", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string productName = cmbProduct.SelectedItem.ToString() ?? "";
            int quantity = (int)nudQuantity.Value;
            decimal unitPrice = productCatalog[productName];
            decimal totalPrice = quantity * unitPrice;

            // Add row to DataGridView
            dgvProducts.Rows.Add(productName, quantity, unitPrice, totalPrice);

            // Update total
            UpdateTotal();

            // Reset quantity
            nudQuantity.Value = 1;
        }

        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (row.Cells["TotalPrice"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["TotalPrice"].Value);
                }
            }
            lblTotalValue.Text = total.ToString("C2");
        }
    }
}
