using System.Windows.Forms;
using Tyuiu.NovikovDS.SprintReview.Task6.V23.Lib;

namespace Tyuiu.NovikovDS.SprintReview.Task6.V23
{
    public partial class MainForm : Form
    {
        DataService ds = new DataService();

        private int[,] matrix;

        private void ButtonGen_NDS_Click(object sender, EventArgs e)
        {
            // Проверка данных на правильность
            if (!int.TryParse(TextBoxIntN_NDS.Text, out int N) || N <= 0 ||
                !int.TryParse(TextBoxIntM_NDS.Text, out int M) || M <= 0 ||
                !int.TryParse(TextBoxIntn1_NDS.Text, out int n1) ||
                !int.TryParse(TextBoxIntn2_NDS.Text, out int n2) || n1 >= n2)
            {
                MessageBox.Show("Некорректный ввод данных. Убедитесь, что n1 < n2 и N, M > 0.");
                return;
            }

            matrix = new int[N, M];
            matrix = ds.RandMatrix(matrix, n1, n2);

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            DataGridViewMass_NDS.ColumnCount = columns;
            DataGridViewMass_NDS.RowCount = rows;

            //for (int i = 0; i < columns; i++) DataGridViewMass_NDS.Columns[i].Width = 35;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    DataGridViewMass_NDS.Rows[i].Cells[j].Value = matrix[i, j].ToString();
            }

            DataGridViewMass_NDS.AllowUserToResizeRows = false;
            DataGridViewMass_NDS.AllowUserToResizeColumns = false;

            foreach (DataGridViewColumn column in DataGridViewMass_NDS.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            DataGridViewMass_NDS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void ButtonToDo_NDS_Click(object sender, EventArgs e)
        {
            if (matrix == null)
            {
                MessageBox.Show("Сначала сгенерируйте массив.");
                return;
            }

            if (!int.TryParse(TextBoxIntc_NDS.Text, out int c) || c < 0 || c >= matrix.GetLength(0) ||
                !int.TryParse(TextBoxIntk_NDS.Text, out int k) || k < 0 ||
                !int.TryParse(TextBoxIntl_NDS.Text, out int l) || l < k || l >= matrix.GetLength(1))
            {
                MessageBox.Show("Некорректный ввод данных. Проверьте значения c, k и l.");
                return;
            }

            int p = ds.GetMatrix(matrix, c, k, l);

            TextBoxRes_NDS.Text = p.ToString();
        }

        private void Button_About_NovikovDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт Ревью 6 выполнил студент группы РППб-24-1 Новиков Дмитрий Семенович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public MainForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}
