using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;
using RoundedFrameUWP.UWP;
using Xamarin.Forms.Platform.UWP;
using RoundedFrameUWP;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(RoundedFrame), typeof(RoundedFrameRenderer))]
namespace RoundedFrameUWP.UWP
{
	public class RoundedFrameRenderer : FrameRenderer
	{
		private double _radiusCorner = 15;
		private Windows.UI.Color _frameBg;

		protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
		{
			base.OnElementChanged(e);
			var myFrame = Element as RoundedFrame;

			if (Control != null)
			{
				
				if (myFrame.CornerRadius != -1 && myFrame.CornerRadius != 0)
				{
					_radiusCorner = myFrame.CornerRadius;
				}

				var frame = e.NewElement;
				_frameBg = Windows.UI.Color.FromArgb(
					(byte)(frame.BackgroundColor.A * 255),
					(byte)(frame.BackgroundColor.R * 255),
					(byte)(frame.BackgroundColor.G * 255),
					(byte)(frame.BackgroundColor.B * 255));


				CornerRadius corner;
				switch (myFrame.RoundedStyle)
				{
					case RoundedFrame.RoundedStyleEnum.Full:
						corner = new Windows.UI.Xaml.CornerRadius(_radiusCorner);
						break;
					case RoundedFrame.RoundedStyleEnum.Down:
						corner = new Windows.UI.Xaml.CornerRadius(_radiusCorner, _radiusCorner, 0, 0);
						break;
					case RoundedFrame.RoundedStyleEnum.Top:
						corner = new Windows.UI.Xaml.CornerRadius(0, 0, _radiusCorner, _radiusCorner);
						break;
					default:
						corner = new CornerRadius(_radiusCorner);
						break;
				}

				Control.CornerRadius = corner;




				Control.Background = new SolidColorBrush(_frameBg);
				frame.BackgroundColor = Xamarin.Forms.Color.Transparent;
			}

		}
	}
}
