﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PMICalculatorDll;
using System.IO;

namespace PMISpecificCalculator
{
    public partial class MainForm : Form
    {
        private string DataXMLFilePathMold;
        private string DataXMLFilePathSimpleSubstance;
        public MainForm()
        {
            InitializeComponent();
            PMICalculatorDll.FormCommonOperate.SetFormToFixedSingleDialog(this);
            //这里初始化所有的数据文件路径
            DataXMLFilePathMold = Path.Combine(Environment.CurrentDirectory, "XMLData", "MoldData.xml");
            DataXMLFilePathSimpleSubstance = Path.Combine(Environment.CurrentDirectory, "XMLData", "SubstanceData.xml");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculatorArchimedesDensity adc = new CalculatorArchimedesDensity();
            adc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculatorRectangleTargetDensity rtdc = new CalculatorRectangleTargetDensity();
            rtdc.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalculatorCircleTargetDensity ctdc = new CalculatorCircleTargetDensity();
            ctdc.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CalculatorPressureFromT1D1D2ToT2 calculator = new CalculatorPressureFromT1D1D2ToT2();
            calculator.DataXMLFilePath = DataXMLFilePathMold;
            calculator.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CalculatorPressureFromPDtoT calculator = new CalculatorPressureFromPDtoT();
            calculator.DataXMLFilePath = DataXMLFilePathMold;
            calculator.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CalculatorPressureFromTDToP calculator = new CalculatorPressureFromTDToP();
            calculator.DataXMLFilePath = DataXMLFilePathMold;
            calculator.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CalculatorWeightingDensityByWt calculator = new CalculatorWeightingDensityByWt();
            calculator.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CalculatorWeightingDensityByAt calculator = new CalculatorWeightingDensityByAt();
            calculator.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CalculatorMaterialRequirement calculator = new CalculatorMaterialRequirement();
            calculator.DataXMLFilePath = DataXMLFilePathMold;
            calculator.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CalculatorSimpleSubstanceOfEveryCompound calcualtor = new CalculatorSimpleSubstanceOfEveryCompound();
            calcualtor.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            CalculatorFillMaterials calculator = new CalculatorFillMaterials();
            calculator.DataXMLFilePath = DataXMLFilePathMold;
            calculator.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string ExcelDir = Path.Combine(Environment.CurrentDirectory, "CalculationExcels");
            List<FileInfo> ExcelSheets = new List<FileInfo>();
            if (Directory.Exists(ExcelDir))
            {
                foreach (var item in Directory.GetFiles(ExcelDir))
                {
                    FileInfo tmp = new FileInfo(item);
                    ExcelSheets.Add(tmp);
                }
            }
            CalculatorExcelSheets calcualtor = new CalculatorExcelSheets();
            calcualtor.ExcelSheets = ExcelSheets;
            calcualtor.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", "http://www.cd-pmi.com");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                string pariodicTablePath = Path.Combine(Environment.CurrentDirectory, "ExtraTool", "PeriodicTable.exe");
                System.Diagnostics.Process.Start(pariodicTablePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            InventoryMold IM = new InventoryMold();
            IM.DataXMLFilePath = DataXMLFilePathMold;
            IM.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            InventorySimpleElement ise = new InventorySimpleElement();
            ise.DataXMLFilePath = DataXMLFilePathSimpleSubstance;
            ise.ShowDialog();
        }
    }
}
