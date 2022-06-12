using System;
using System.Windows;

namespace System_Of_Equations
{
    /// <summary> 
    /// Interaction logic for MainWindow.xaml 
    /// </summary> 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextBox.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox.AppendText(textData: " ");
        }

        private void Button_0_Click(object sender, RoutedEventArgs e)
        {
            TextBox.AppendText(textData: "0");
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            TextBox.AppendText(textData: "1");
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            TextBox.AppendText(textData: "2");
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            TextBox.AppendText(textData: "3");
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            TextBox.AppendText(textData: "4");
        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            TextBox.AppendText(textData: "5");
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            TextBox.AppendText(textData: "6");
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            TextBox.AppendText(textData: "7");
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            TextBox.AppendText(textData: "8");
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            TextBox.AppendText(textData: "9");
        }

        private void Button_10_Click(object sender, RoutedEventArgs e)
        {
            TextBox.AppendText(textData: "-");
        }

        private void Button_11_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Clear();
        }

        private void Button_12_Click(object sender, RoutedEventArgs e)
        {
            SystemOfEquations systemOfEquations = new(str_1: TextBox.Text);
            systemOfEquations.Result();
        }
    }
    internal class SystemOfEquations
    {
        private float X { get; set; }
        private float Y { get; set; }
        private float Z { get; set; }
        private float[] Vs { get; set; } = new float[12];

        public SystemOfEquations(string str_1)
        {
            try
            {
                for (int i = 0; i < str_1.Split(' ').Length; i++)
                {
                    Vs[i] = int.Parse(str_1.Split(' ')[i]);
                }
            }
            catch (Exception) { }
            float a1 = Vs[0];
            float b1 = Vs[1];
            float c1 = Vs[2];
            float d1 = Vs[3];
            float a2 = Vs[4];
            float b2 = Vs[5];
            float c2 = Vs[6];
            float d2 = Vs[7];
            float a3 = Vs[8];
            float b3 = Vs[9];
            float c3 = Vs[10];
            float d3 = Vs[11];
            X = (float)((d1 * b2 * c3)
                        + (b1 * c2 * d3)
                        + (c1 * d2 * b3)
                        - (c1 * b2 * d3)
                        - (b1 * d2 * c3)
                        - (d1 * c2 * b3)) /
                (float)((a1 * b2 * c3)
                        + (b1 * c2 * a3)
                        + (c1 * a2 * b3)
                        - (c1 * b2 * a3)
                        - (b1 * a2 * c3)
                        - (a1 * c2 * b3));
            Y = (float)((a1 * d2 * c3)
                        + (c1 * a2 * d3)
                        + (d1 * c2 * a3)
                        - (c1 * d2 * a3)
                        - (d1 * a2 * c3)
                        - (a1 * c2 * d3)) /
                (float)((a1 * b2 * c3)
                        + (b1 * c2 * a3)
                        + (c1 * a2 * b3)
                        - (c1 * b2 * a3)
                        - (b1 * a2 * c3)
                        - (a1 * c2 * b3));
            Z = (float)((a1 * b2 * d3)
                        + (b1 * d2 * a3)
                        + (d1 * a2 * b3)
                        - (d1 * b2 * a3)
                        - (b1 * a2 * d3)
                        - (a1 * d2 * b3)) /
                (float)((a1 * b2 * c3)
                        + (b1 * c2 * a3)
                        + (c1 * a2 * b3)
                        - (c1 * b2 * a3)
                        - (b1 * a2 * c3)
                        - (a1 * c2 * b3));
            if (X == -0)
            {
                X = 0;
            }
            if (Y == -0)
            {
                Y = 0;
            }
            if (Z == -0)
            {
                Z = 0;
            }
            X.ToString();
            Y.ToString();
            Z.ToString();
        }
        public void Result()
        {
            string result = $"Сиситема уравненеий:\n\n"
                            + $"{Vs[0]}*x1 + {Vs[1]}*y1 + {Vs[2]} * z1 = {Vs[3]}\n"
                            + $"{Vs[4]}*x2 + {Vs[5]}*y2 + {Vs[6]} * z2 = {Vs[7]}\n"
                            + $"{Vs[8]}*x3 + {Vs[9]}*y3 + {Vs[10]} * z3 = {Vs[11]}\n\n"
                            + $"Ответ: X = {X}, Y = {Y}, Z = {Z}";
            MessageBox.Show(messageBoxText: result);
        }
    }
}