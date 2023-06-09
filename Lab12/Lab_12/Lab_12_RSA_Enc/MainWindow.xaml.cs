﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_12_RSA_Enc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Stopwatch stopwatch = new Stopwatch();
        long freq = Stopwatch.Frequency;

        static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";

        private static bool IsSimple(int n)
        {
            for (int i = 2; i <= (int)(n / 2); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void LetterValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private int NOD(int first, int second)
        {
            int a, b, q, r = 1;
            if (first >= second)
            {
                a = first;
                b = second;
            }
            else
            {
                a = second;
                b = first;
            }
            while (r != 0)
            {
                q = (int)(a / b);
                r = (a % b);
                a = b;
                b = r;
            }
            return a;
        }

        private static int LetterNumber(char letter)
        {
            int number = 0;
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == letter)
                {
                    number = i;
                }
            }
            return number;
        }

        private void Encrypt(object sender, RoutedEventArgs e)
        {
            RichTextEnc.Document.Blocks.Clear();
            if (RichText.GetText(RichTextOrig) != String.Empty)
            {
                stopwatch.Start();
                int p = 61;
                int q = 53;
                int E = 7;
                if (IsSimple(p) && IsSimple(q))
                {
                    int n = p * q;
                    int fn = (p - 1) * (q - 1);
                    if (E < n && NOD(E, fn) == 1)
                    {
                        int d = 0;
                        while (((d * E) % fn) != 1)
                        {
                            d++;
                        }
                        string text = RichText.GetText(RichTextOrig);
                        text = text.Substring(0, text.Length - 2);

                        var md5 = MD5.Create();
                        var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(text));
                        text = Convert.ToBase64String(hash);

                        string encText = "";
                        for (int i = 0; i < text.Length; i++)
                        {
                            if (alphabet.Contains(text[i]))
                            {
                                encText += ((int)(Math.Pow(LetterNumber(text[i]), E) % n)).ToString() + " ";
                            }
                        }

                        RichText.SetText(RichTextEnc, "S: " + encText + "\nH: " + text);
                    }
                    else
                    {
                        MessageBox.Show("Коэффициент e не является взаимнопростым с f(n). Исправьте это");
                    }
                }
                else
                {
                    MessageBox.Show("Числа p и q не являются простыми. Исправьте это");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
            stopwatch.Stop();
            EncrTime.Content += $"{(double)stopwatch.ElapsedTicks / freq} sec \n";
            stopwatch.Reset();
        }


        private void Decrypt(object sender, RoutedEventArgs e)
        {
            RichTextOrigDecr.Document.Blocks.Clear();
            if (RichText.GetText(RichTextDecr) != String.Empty)
            {
                stopwatch.Start();
                int p = 61;
                int q = 53;
                int E = 7;
                if (IsSimple(p) && IsSimple(q))
                {
                    int n = p * q;
                    int fn = (p - 1) * (q - 1);
                    if (E < n && NOD(E, fn) == 1)
                    {
                        int d = 0;
                        while (((d * E) % fn) != 1)
                        {
                            d++;
                        }
                        string encText = RichText.GetText(RichTextDecr);
                        encText = encText.Substring(0, encText.Length - 2);
                        string[] letters = encText.Split(' ');
                        string text = "";

                        foreach (string letter in letters)
                        {
                            int number = Int32.Parse(letter);
                            int result = (int)BigInteger.ModPow(number, d, n);
                            try
                            {
                                text += alphabet[result];
                            }
                            catch
                            {
                                text += "";
                            }

                        }

                        RichText.SetText(RichTextOrigDecr, "H: " + text + "==");
                    }
                    else
                    {
                        MessageBox.Show("Коэффициент e не является взаимнопростым с f(n). Исправьте это");
                    }
                }
                else
                {
                    MessageBox.Show("Числа p и q не являются простыми. Исправьте это");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
            stopwatch.Stop();
            DecrTime.Content += $"{(double)stopwatch.ElapsedTicks / freq} sec \n";
            stopwatch.Reset();
        }
    }

    public static class RichText
    {
        public static void SetText(this RichTextBox richTextBox, string text)
        {
            richTextBox.Document.Blocks.Clear();
            richTextBox.Document.Blocks.Add(new Paragraph(new Run(text)));
        }

        public static string GetText(this RichTextBox richTextBox)
        {
            return new TextRange(richTextBox.Document.ContentStart,
                richTextBox.Document.ContentEnd).Text;
        }
    }
}
