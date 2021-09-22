using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace PracticeWork04CurrencyConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FillComboboxesItems();

        }

        private int _SelectedInputCurrency = 0;
        private int _SelectedOutputCurrency = 0;

        private void TB_Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            ConvertCurrency();
        }


        private void FillComboboxesItems()
        {
            ((Button)CB_Input.Items[0]).Content = "$";
            ((Button)CB_Input.Items[1]).Content = "€";
            ((Button)CB_Input.Items[2]).Content = "₽";
            ((Button)CB_Input.Items[3]).Content = "¥";
            CB_Input.SelectedIndex = 0;

            ((Button)CB_Output.Items[0]).Content = "$";
            ((Button)CB_Output.Items[1]).Content = "€";
            ((Button)CB_Output.Items[2]).Content = "₽";
            ((Button)CB_Output.Items[3]).Content = "¥";
            CB_Output.SelectedIndex = 0;
        }

        private void ComboButtonInputPressed(object sender, RoutedEventArgs args)
        {
            _SelectedInputCurrency = Convert.ToInt32(((Button)sender).Uid);
            ConvertCurrency();
        }

        private void ComboButtonOutputPressed(object sender, EventArgs args)
        {
            _SelectedOutputCurrency = Convert.ToInt32(((Button)sender).Uid);
            ConvertCurrency();
        }
        private void ConvertCurrency()
        {
            if(TB_Output == null || TB_Input == null)
            {
                return;
            }
            if(TB_Output.Text.Length <= 0 || TB_Input.Text.Length <= 0)
            {
                return;
            }
            double _Output = 0.0;
            switch(_SelectedInputCurrency)
            {
                case 0:
                    {
                        switch (_SelectedOutputCurrency)
                        {
                            case 0:
                                {
                                    _Output = Convert.ToDouble(TB_Input.Text);
                                }break;
                            case 1:
                                {
                                    _Output = Convert.ToDouble(TB_Input.Text)*0.85;
                                }
                                break;
                            case 2:
                                {
                                    _Output = Convert.ToDouble(TB_Input.Text)*72.89;
                                }
                                break;
                            case 3:
                                {
                                    _Output = Convert.ToDouble(TB_Input.Text)*6.47;
                                }
                                break;
                        }
                    }break;
                case 1:
                    {
                        switch(_SelectedOutputCurrency)
                        {
                            case 0:
                                {
                                    _Output = Convert.ToDouble(TB_Input.Text)*1.17;
                                }
                                break;
                            case 1:
                                {
                                    _Output = Convert.ToDouble(TB_Input.Text);
                                }
                                break;
                            case 2:
                                {
                                    _Output = Convert.ToDouble(TB_Input.Text)*85.52;
                                }
                                break;
                            case 3:
                                {
                                    _Output = Convert.ToDouble(TB_Input.Text)*7.59;
                                }
                                break;
                        }
                    }break;
                case 2:
                    {
                        switch (_SelectedOutputCurrency)
                        {
                            case 0:
                                {
                                    _Output = Convert.ToDouble(TB_Input.Text)*0.014;
                                }
                                break;
                            case 1:
                                {
                                    _Output = Convert.ToDouble(TB_Input.Text)*0.012;
                                }
                                break;
                            case 2:
                                {
                                    _Output = Convert.ToDouble(TB_Input.Text);
                                }
                                break;
                            case 3:
                                {
                                    _Output = Convert.ToDouble(TB_Input.Text)*0.088;
                                }
                                break;
                        }
                    }
                    break;
                case 3:
                    {
                        switch (_SelectedOutputCurrency)
                        {
                            case 0:
                                {
                                    _Output = Convert.ToDouble(TB_Input.Text)*0.15;
                                }
                                break;
                            case 1:
                                {
                                    _Output = Convert.ToDouble(TB_Input.Text)*0.13;
                                }
                                break;
                            case 2:
                                {
                                    _Output = Convert.ToDouble(TB_Input.Text)*11.32;
                                }
                                break;
                            case 3:
                                {
                                    _Output = Convert.ToDouble(TB_Input.Text);
                                }
                                break;
                        }
                    }
                    break;
            }
            TB_Output.Text = Convert.ToString(_Output);
        }


        private void CB_Input_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox _comboBox = (ComboBox)sender;
            Button _button = (Button)_comboBox.SelectedItem;
            _SelectedInputCurrency = Convert.ToInt32(_button.Uid);
            ConvertCurrency();
        }

        private void CB_Output_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox _comboBox = (ComboBox)sender;
            Button _button = (Button)_comboBox.SelectedItem;
            _SelectedOutputCurrency = Convert.ToInt32(_button.Uid);
            ConvertCurrency();
        }
    }
}
