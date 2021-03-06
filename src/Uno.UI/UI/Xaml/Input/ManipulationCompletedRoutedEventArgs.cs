using Windows.Devices.Input;
using Windows.Foundation;
using Windows.UI.Input;
using Uno.UI.Xaml.Input;

namespace Windows.UI.Xaml.Input
{
	public partial class ManipulationCompletedRoutedEventArgs : RoutedEventArgs, IHandleableRoutedEventArgs
	{
		public ManipulationCompletedRoutedEventArgs() { }

		internal ManipulationCompletedRoutedEventArgs(UIElement container, ManipulationCompletedEventArgs args)
			: base(container)
		{
			Container = container;
			PointerDeviceType = args.PointerDeviceType;
			Position = args.Position;
			Cumulative = args.Cumulative;
			Velocities = args.Velocities;
			IsInertial = args.IsInertial;
		}

		public bool Handled { get; set; }

		public UIElement Container { get; }

		public PointerDeviceType PointerDeviceType { get; }
		public Point Position { get; }
		public ManipulationDelta Cumulative { get; }
		public ManipulationVelocities Velocities { get; }
		public bool IsInertial { get; }
	}
}
