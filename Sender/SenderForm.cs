using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Common;

using MassTransit;

using N3.Sormo;

namespace Sender
{
	public partial class SenderForm : Form
	{
		private IBusControl _busControl;
		public SenderForm()
		{
			InitializeComponent();
			var s = Properties.Settings.Default;
			try
			{
				_busControl = ConfigureBus(s.Url, s.VHost, s.User, s.Password);
				_busControl.Start();
			}
			catch (Exception e)
			{
				buttonSend.Enabled = false;
				MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}


		private  void buttonSend_Click(object sender, EventArgs e)
		{
			switch (tabControlContracts.SelectedIndex)
			{
				case 0://MessageTextContract
					{
						var msg = new MessageTextContract { Message = textBoxMessage.Text };
						Task.Factory.StartNew(async () => await _busControl.Publish(msg));
						break;

					}
				case 1://SormoNewCaseContract
					{
						Task.Factory.StartNew(async () => await _busControl.Publish(new SormoNewCaseContract()
						{
							CaseId = (int)numericUpDownCaseId.Value,
							PatientId = textBoxPatientId.Text,
							Diagnosis = textBoxDiagnosis.Text,
							CaseTypeId = (int)numericUpDownCaseIdType.Value,
							CloseDate = dateTimePickerCloseDate.Value,
							LpuId = textBoxLpuId.Text
						}));
						break;
					}
			}
 
		}

		private void SenderForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			_busControl.Stop();
		}

		public static IBusControl ConfigureBus(string url, string vhost, string user, string password)
		{
			return Bus.Factory.CreateUsingRabbitMq(cfg =>
				{
					var host = cfg.Host(url, vhost, h =>
						{
							h.Username(user);
							h.Password(password);
						});

				});
		}
	}
}
