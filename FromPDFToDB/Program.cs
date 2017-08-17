using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromPDFToDB
{
	class Program
	{
		static void Main(string[] args)
		{
			Bitmap bimage = new Bitmap(@"C:\Solomiya\K&K Uni Ftwr PYG OCT 12 209417.bmp");
			Console.WriteLine(GetTextFromImg.GetText(bimage));
			Console.Read();
		}
	}
}
