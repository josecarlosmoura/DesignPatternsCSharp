using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Exercise
{
	public interface IProcessFormat
	{
		string Process(Format format, BankAccount bankAccount);
	}
}
