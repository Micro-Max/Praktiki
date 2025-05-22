using System;
using System.Windows.Forms;
using System.Linq;

namespace WinFormsApp15
{
    public partial class Form1 : Form
    {
        private int[] array = new int[100];
        private int[] sortedArray = new int[100];
        private int iterations;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 1000);
            }
            DisplayArray(array, dataGridViewOriginal);
        }

        private void btnLinearSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchValue.Text, out int value))
            {
                int index = -1;
                iterations = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    iterations++;
                    if (array[i] == value)
                    {
                        index = i;
                        break;
                    }
                }
                lblLinearResult.Text = index != -1 ? $"Найден на позиции {index}" : "Не найден";
                lblLinearIterations.Text = $"Итераций: {iterations}";
            }
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            int[] copyArray = (int[])array.Clone();
            iterations = BubbleSort(ref copyArray);
            sortedArray = copyArray;
            DisplayArray(sortedArray, dataGridViewSorted);
            lblBubbleIterations.Text = $"Итераций: {iterations}";
        }

        private int BubbleSort(ref int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    count++;
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return count;
        }

        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            int[] copyArray = (int[])array.Clone();
            iterations = SelectionSort(ref copyArray);
            sortedArray = copyArray;
            DisplayArray(sortedArray, dataGridViewSorted);
            lblSelectionIterations.Text = $"Итераций: {iterations}";
        }

        private int SelectionSort(ref int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    count++;
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                }
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
            return count;
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            int[] copyArray = (int[])array.Clone();
            iterations = 0;
            QuickSort(ref copyArray, 0, copyArray.Length - 1);
            sortedArray = copyArray;
            DisplayArray(sortedArray, dataGridViewSorted);
            lblQuickIterations.Text = $"Итераций: {iterations}";
        }

        private void QuickSort(ref int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);
                QuickSort(ref arr, left, pivot - 1);
                QuickSort(ref arr, pivot + 1, right);
            }
        }

        private int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                iterations++;
                if (arr[j] <= pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int swap = arr[i + 1];
            arr[i + 1] = arr[right];
            arr[right] = swap;
            return i + 1;
        }

        private void btnBinarySearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchValue.Text, out int value))
            {
                iterations = 0;
                int index = BinarySearch(sortedArray, value, 0, sortedArray.Length - 1);
                lblBinaryResult.Text = index != -1 ? $"Найден на позиции {index}" : "Не найден";
                lblBinaryIterations.Text = $"Итераций: {iterations}";
            }
        }

        private int BinarySearch(int[] arr, int value, int left, int right)
        {
            iterations++;
            if (left > right) return -1;
            int mid = (left + right) / 2;
            if (arr[mid] == value) return mid;
            if (arr[mid] < value) return BinarySearch(arr, value, mid + 1, right);
            else return BinarySearch(arr, value, left, mid - 1);
        }

        private void DisplayArray(int[] arr, DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            dgv.Columns.Add("colIndex", "Индекс");
            dgv.Columns.Add("colValue", "Значение");
            for (int i = 0; i < arr.Length; i++)
            {
                dgv.Rows.Add(i, arr[i]);
            }
        }
    }
}