using ChainOfResponsability.Exercise.TextFormats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Exercise
{
	public class GenerateChain
	{
		public string Generate(Format format, BankAccount bankAccount) 
		{
			IProcessFormat processFormat = new NoFormat();
			IProcessFormat processFormatThree = new Xml(processFormat);
			IProcessFormat processFormatTwo = new Percent(processFormatThree);
			IProcessFormat processFormatOne = new Csv(processFormatTwo);
			
			return processFormatOne.Process(format, bankAccount);
		}
	}
}
