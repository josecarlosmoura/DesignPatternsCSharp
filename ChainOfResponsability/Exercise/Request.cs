using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Exercise
{
	public class Request
	{
		public Format format { get; private set; }

		public Request(Format format)
		{
			this.format = format;
		}
	}
}
