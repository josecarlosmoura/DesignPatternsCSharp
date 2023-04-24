using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Exercise.TextFormats
{
	public class NoFormat : IProcessFormat
	{
		private IProcessFormat NextProcess { get; set; }

		public NoFormat() { }

		public NoFormat(IProcessFormat nextProcess)
		{
			NextProcess = nextProcess;
		}

		public string Process(Format format, BankAccount bankAccount)
		{
			return string.Empty;
		}
	}
}
