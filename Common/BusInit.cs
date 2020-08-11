using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MassTransit;

namespace Common
{
	public  class BusInit
	{
		public static IBusControl ConfigureBus(string url, string vhost, string user, string password)
		{
			return Bus.Factory.CreateUsingRabbitMq(cfg =>
				{
					var host = cfg.Host(url,vhost, h =>
						{
							h.Username(user);
							h.Password(password);
						});

				});
		}
	}
}
