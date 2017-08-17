using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace FromPDFToDB
{
	public static class GetTextFromImg
	{
		public static string GetText(Bitmap imgsource)
		{
			var ocrtext = string.Empty;
			using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
			{
				using (var img = PixConverter.ToPix(imgsource))
				{
					using (var page = engine.Process(img))
					{
						ocrtext = page.GetText();
					}
				}
			}

			return ocrtext;
		}
	}
}
