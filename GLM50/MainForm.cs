using Bosch.GLM100C.CommunicationHandler;
using GLM50.Calculations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GLM50
{
    public partial class MainForm : Form
    {

        private ICalculationDialog activeCalculationDialog = null;

        public MainForm()
        {
            InitializeComponent();
            BTCommunicationBridge.Instance.MeasurementDataReceived += this.Instance_MeasurementDataReceived;
            BTCommunicationBridge.Instance.OnConnectClick += this.Instance_OnConnectClick;
            BTCommunicationBridge.Instance.OnBTDisConnect += this.Instance_OnBTDisConnect;
            this.calculationsDropDown.Items.Add("Calculations:");
            this.calculationsDropDown.Items.Add(new CalculationCreator<TriangleCalculation>("Triangle"));
            this.calculationsDropDown.SelectedIndex = 0;
            this.calculationsDropDown.SelectedValueChanged += this.CalculationsDropDown_SelectedValueChanged;
        }

        private void CalculationsDropDown_SelectedValueChanged(object sender, EventArgs e)
        {
            var idx = this.calculationsDropDown.SelectedIndex;

            if (idx < 1)
                return;

            var creator = this.calculationsDropDown.SelectedItem as ICalculationCreator;
            using (var dialog = creator.CreateInstance())
            {
                this.activeCalculationDialog = dialog;
                dialog.ShowDialog();
                this.activeCalculationDialog = null;
            }
            this.calculationsDropDown.SelectedIndex = 0;
        }

        private void Instance_OnBTDisConnect(object sender, EventArgs e)
        {
            this.BeginInvoke((Action)(() =>
            {
                this.statusLabel.Text = "Disconnected";
                this.devicesList.Enabled = true;
                this.connectButton.Enabled = true;
                this.getListOfDevicesBtn.Enabled = true;
            }));
        }

        private void Instance_OnConnectClick(object sender, EventArgs e)
        {
            this.BeginInvoke((Action)(() =>
            {
                this.statusLabel.Text = "Connected";
                this.devicesList.Enabled = false;
                this.connectButton.Enabled = false;
                this.getListOfDevicesBtn.Enabled = false;
            }));
        }

        private void Instance_MeasurementDataReceived(object sender, BTMeasurementDataEventArgs e)
        {
            float measuredValue = e.MeasurementData.FloatMeasurement;
            if (measuredValue > 0)
            {
                this.BeginInvoke((Action)(() =>
                {
                    measuredValue = measuredValue * (float)scaleValueBy.Value;
                    this.measuredValueLabel.Text = measuredValue.ToString();
                    if (this.activeCalculationDialog != null)
                    {
                        this.activeCalculationDialog.MeasurementReceived(measuredValue);
                    }
                    else
                    {
                        if (this.sendMeasuredValueCb.Checked)
                        {
                            string format = this.sendMeasuredValueFormat.Text;
                            bool enter = format.Contains("{ENTER}");
                            format = format.Replace("{ENTER}", "{1}");
                            SendKeys.SendWait(String.Format(format, measuredValue, enter ? "{ENTER}" : null));
                        }
                    }
                }));
            }
        }


        private void getListOfDevicesBtn_Click(object sender, EventArgs e)
        {
            if (BTCommunicationBridge.Instance.DeviceConnStatus())
                BTCommunicationBridge.Instance.DisconnectDevice();

            this.getListOfDevicesBtn.Enabled = false;
            this.UseWaitCursor = true;
            this.statusLabel.Text = "Searching ...";
            ThreadPool.QueueUserWorkItem((cb) =>
            {
                BTCommunicationBridge.Instance.DiscoverBTDevices();
                var devices = BTCommunicationBridge.Instance.Devices;

                this.BeginInvoke((Action)(() =>
                {
                    this.devicesList.Items.Clear();
                    this.devicesList.Items.AddRange(devices.Select(d => d.Key).Cast<object>().ToArray());
                    if (devices.Count > 0)
                    {
                        this.devicesList.SelectedIndex = 0;
                    }
                    this.UseWaitCursor = false;
                    this.getListOfDevicesBtn.Enabled = true;
                    this.statusLabel.Text = "Disconnected";
                }));

            });

        }

        private void devicesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.connectButton.Enabled = this.devicesList.SelectedIndex > -1;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            var selected = this.devicesList.SelectedItem;

            if (selected == null)
                return;
            this.statusLabel.Text = "Connecting ...";
            Application.DoEvents();
            var dvcId = (string)selected;
            BTCommunicationBridge.Instance.StartCommunication(dvcId);
        }

    }
}
