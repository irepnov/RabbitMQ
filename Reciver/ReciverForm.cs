using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MassTransit;

using N3.DliFed;
using N3.Sormo;

using RabbitMQ.Client;

namespace Reciver
{
	public partial class ReciverForm : Form
	{
		private IBusControl _busControl;

		private bool _isConnected;

		public bool IsConnected
		{
			get
			{

				return _isConnected;
			}
			set
			{
				buttonConnect.Text = value ? "Отключить" : "Подключить";
				_isConnected = value;
			}
		}

		public ReciverForm()
		{
			InitializeComponent();
			Action<string> d = s => {
					if (InvokeRequired)
					{
						this.Invoke((MethodInvoker)delegate { textBox1.Text += $"\r\n{s}"; });
					}
					else
					{
						textBox1.Text += $"\r\n{s}";

				}
			};
			TextBoxWriter.Init(d);
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void buttonConnect_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxQueueName.Text))
			{
				MessageBox.Show("Имя очереди незаполнено", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			if (comboBoxContarcts.SelectedIndex == -1)
			{
				MessageBox.Show("Контракт не выбран", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			if (_busControl != null)
			{
				IsConnected = false;
				_busControl.Stop();
				_busControl = null;
				return;
			}
 
			IsConnected = true;
			var s = Properties.Settings.Default;
			switch (comboBoxContarcts.SelectedIndex)
			{
				case 0:
					{
						_busControl = Bus.Factory.CreateUsingRabbitMq(cfg =>
							{
								var host = cfg.Host(s.Url, s.VHost, h =>
									{
										h.Username(s.User);
										h.Password(s.Password);
									});
								cfg.ReceiveEndpoint(host, textBoxQueueName.Text, c => c.Consumer<MessageContractConsumer>());
							});
						_busControl.Start();
						break;	

					}
				case 1:
					{
						_busControl = Bus.Factory.CreateUsingRabbitMq(cfg =>
							{
								var host = cfg.Host(s.Url, s.VHost, h =>
									{
										h.Username(s.User);
										h.Password(s.Password);
									});
								cfg.ReceiveEndpoint(host, textBoxQueueName.Text, c => c.Consumer<SormoNewCaseContractConsumer>());
							});
						_busControl.Start();
						break;

					}
				case 2:
					{
						_busControl = Bus.Factory.CreateUsingRabbitMq(cfg =>
							{
								var host = cfg.Host(s.Url, s.VHost, h =>
									{
										h.Username(s.User);
										h.Password(s.Password);
									});
								cfg.ReceiveEndpoint(host, textBoxQueueName.Text, c => c.Consumer<DliFedNewResultConsumer>());
							});
						_busControl.Start();
						break;

					}
				case 3:
					{
						_busControl = Bus.Factory.CreateUsingRabbitMq(cfg =>
							{
								var host = cfg.Host(s.Url, s.VHost, h =>
									{
										h.Username(s.User);
										h.Password(s.Password);
									});
								cfg.ReceiveEndpoint(host, textBoxQueueName.Text, c => c.Consumer<DliMsgNewResultConsumer>());
							});
						_busControl.Start();
						break;

					}
			}
		 
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			try {
				ConnectionFactory factory = new ConnectionFactory();
				var s = Properties.Settings.Default;
				factory.UserName = s.User;
				factory.Password = s.Password;
				factory.VirtualHost = s.VHost;
				factory.HostName = s.Url;

				IConnection conn = factory.CreateConnection();
				var model = conn.CreateModel();
				model.QueueDelete(textBoxQueueName.Text, false, false);
				
				conn.Close();
				MessageBox.Show($"Очередь '{textBoxQueueName.Text}' удалена");
			}
			catch (Exception exception)
			{
				//MessageBox.Show($"Очередь '{textBoxQueueName.Text}' удалена");
				
			}
			
		}
	}

	public static class TextBoxWriter
	{
		private static Action<string> _tb;
		public static void Init(Action<string> tb)
		{
			_tb = tb;
		}

		public static void Write(string str)
		{
			_tb.Invoke(str);
		}
	}

	public class MessageContractConsumer : IConsumer<MessageTextContract>
	{
		
		public async Task Consume(ConsumeContext<MessageTextContract> context)
		{
			TextBoxWriter.Write(context.Message.ToString());
			//await Console.Out.WriteLineAsync($"Updating customer: {context.Message}");

			// update the customer address
		}
	}
	public class SormoNewCaseContractConsumer : IConsumer<SormoNewCaseContract>
	{
		public async Task Consume(ConsumeContext<SormoNewCaseContract> context)
		{
			TextBoxWriter.Write(context.Message.ToString());

			// update the customer address
		}
	}
	public class DliFedNewResultConsumer : IConsumer<DliFedNewResult>
	{
		public async Task Consume(ConsumeContext<DliFedNewResult> context)
		{
			TextBoxWriter.Write(context.Message.ToString());

			// update the customer address
		}
	}
	public class DliMsgNewResultConsumer : IConsumer<DliMsgNewResult>
	{
		public async Task Consume(ConsumeContext<DliMsgNewResult> context)
		{
			TextBoxWriter.Write(context.Message.ToString());

			// update the customer address
		}
	}
}
