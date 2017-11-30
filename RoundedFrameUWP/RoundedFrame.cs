using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RoundedFrameUWP
{
	public class RoundedFrame : Frame
	{
		

		public RoundedStyleEnum RoundedStyle { get; set; }
		public double RadiusCorner { get; set; }

		public enum RoundedStyleEnum
		{
			Full,
			Top,
			Down
		}
	}
}
