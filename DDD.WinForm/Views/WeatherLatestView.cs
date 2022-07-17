using DDD.Domain.Entities;
using DDD.WinForm.ViewModels;
using System;
using System.Windows.Forms;

namespace DDD.WinForm
{
    public partial class WeatherLatestView : Form
    {
        private WeatherLatestViewModel _viewModel
            = new WeatherLatestViewModel();
        public WeatherLatestView()
        {
            InitializeComponent();

            this.AreaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.AreaComboBox.DataBindings.Add(
                "SelectedValue", _viewModel, nameof(_viewModel.SelectedAreaId));
            this.AreaComboBox.DataBindings.Add(
                "DataSource", _viewModel, nameof(_viewModel.Areas));
            this.AreaComboBox.ValueMember = nameof(AreaEntity.AreaId);
            this.AreaComboBox.DisplayMember = nameof(AreaEntity.AreaName);

            this.DataDateLabel.DataBindings.Add(
                "Text", _viewModel, nameof(_viewModel.DataDateText));
            this.ConditionLabel.DataBindings.Add(
                "Text", _viewModel, nameof(_viewModel.ConditionText));
            this.TemperatureLabel.DataBindings.Add(
                 "Text", _viewModel, nameof(_viewModel.TemperatureText));
        }

        private void LatestButton_Click(object sender, EventArgs e)
        {
            _viewModel.Search();
        }

    }
}
