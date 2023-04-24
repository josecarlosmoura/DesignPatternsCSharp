using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ChainOfResponsability.Exercise.TextFormats
{
	public class Xml : IProcessFormat
	{
		private IProcessFormat NextProcess { get; set; }

		public Xml(IProcessFormat nextProcess)
		{
			this.NextProcess = nextProcess;
		}

		public string Process(Format format, BankAccount bankAccount)
		{
			if (format == Format.XML)
			{
				using (var stringwriter = new StringWriter())
				{
					var serializer = new XmlSerializer(bankAccount.GetType());
					serializer.Serialize(stringwriter, bankAccount);
					return stringwriter.ToString();
				}
			}

			return NextProcess.Process(format, bankAccount);
		}
	}
}
