using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Xml.Linq;
using WeightedDensityCalculator.Models;
using WeightedDensityCalculator.Service;

namespace WeightedDensityCalculator.ViewＭodel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainWindowViewModel : ViewModelBase
    {
        private WeightedDensityCalculationService service;
        /// <summary>
        /// Initializes a new instance of the MainWindowViewModel class.
        /// </summary>
        /// 
        public MainWindowViewModel()
        {
            service = new WeightedDensityCalculationService();

            LoadData();
            CalculatedList = new ObservableCollection<CalculationSubstance>();
            SelectedCalculationSubstance = new CalculationSubstance() { ElementName = "空" };


            SelectCommand = new RelayCommand<Substance>(SelectAction);
            AddCommand = new RelayCommand(AddAction, CanAdd);
            DeleteCommand = new RelayCommand<CalculationSubstance>(DeleteAction);

        }

        private bool CanAdd()
        {
            if (SelectedCalculationSubstance.ElementName == "空" || string.IsNullOrEmpty(SelectedCalculationSubstance.ElementName))
            {
                return false;
            }
            return true;
        }

        private void LoadData()
        {
            string datafile = System.IO.Path.Combine(Environment.CurrentDirectory, "Data", "SubstanceData.xml");
            XDocument document = XDocument.Load(datafile);
            var query = from element in document.Descendants("Substance")
                        orderby int.Parse(element.Attribute("ANumber").Value)
                        select new Substance()
                        {
                            ElementName = element.Attribute("ElementName").Value,
                            ANumber = int.Parse(element.Attribute("ANumber").Value),
                            MolWeight = double.Parse(element.Element("MolWeight").Value),
                            Density = double.Parse(element.Element("Density").Value)
                        };
            Substances = new ObservableCollection<Substance>(query.ToList<Substance>());
        }

        private void DeleteAction(CalculationSubstance substance)
        {
            CalculatedList.Remove(substance);
            CalculateWeightedDensity();
        }

        private void AddAction()
        {
            CalculatedList.Add(SelectedCalculationSubstance);
            CalculateWeightedDensity();
        }

        private void SelectAction(Substance substance)
        {
            SelectedCalculationSubstance = new Models.CalculationSubstance()
            {
                ElementName = substance.ElementName,
                ANumber = substance.ANumber,
                MolWeight = substance.MolWeight,
                Density = substance.Density,
                At = 5,
                Wt = 0
            };

        }
        private void CalculateWeightedDensity()
        {
            if (CalculatedList.Count > 0)
            {
                service.SubstanceGroup = CalculatedList.ToList();
                WeightedDensity = service.GetWeightedDensity();
                //重新将列表值赋值
                CalculatedList = new ObservableCollection<CalculationSubstance>(service.SubstanceGroup);
                RaisePropertyChanged(nameof(CalculatedList));
            }
            else
            {
                WeightedDensity = 0;
            }
        }


        #region Properties
        public ObservableCollection<CalculationSubstance> CalculatedList { get; set; }
        public ObservableCollection<Substance> Substances { get; set; }


        private double weightedDensity;
        public double WeightedDensity
        {
            get
            {
                return weightedDensity;
            }
            set
            {
                weightedDensity = value;
                RaisePropertyChanged(nameof(weightedDensity));
            }
        }

        private CalculationSubstance selectedCalculationSubstance;
        public CalculationSubstance SelectedCalculationSubstance
        {
            get
            {
                return selectedCalculationSubstance;
            }
            set
            {
                if (value == selectedCalculationSubstance)
                {
                    return;
                }
                selectedCalculationSubstance = value;
                RaisePropertyChanged(nameof(SelectedCalculationSubstance));
            }
        }
        #endregion
        #region Commands
        public RelayCommand<Substance> SelectCommand { get; set; }
        public RelayCommand AddCommand { get; set; }
        public RelayCommand<CalculationSubstance> DeleteCommand { get; set; }

        #endregion

    }
}