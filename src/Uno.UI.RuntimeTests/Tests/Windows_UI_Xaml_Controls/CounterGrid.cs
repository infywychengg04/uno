using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Uno.UI.RuntimeTests.Tests.Windows_UI_Xaml_Controls
{
	internal partial class CounterGrid : Grid
	{
		/// <summary>
		/// How many instances of this type have been created?
		/// </summary>
		public static int CreationCount { get; private set; }

		/// <summary>
		/// How many times has an instance of this type been data-bound?
		/// </summary>
		public static int BindCount { get; private set; }

		/// <summary>
		/// Raised whenever an instance of this type is created or data-bound.
		/// </summary>
		public static event Action WasUpdated;

		public CounterGrid()
		{
			CreationCount++;
			WasUpdated?.Invoke();

			DataContextChanged += On_DataContextChanged;
		}

		private void On_DataContextChanged(DependencyObject sender, DataContextChangedEventArgs args)
		{
			if (args.NewValue != null)
			{
				BindCount++;
				WasUpdated?.Invoke();
			}
		}

		public static void Reset()
		{
			CreationCount = 0;
			BindCount = 0;
		}
	}

	internal partial class CounterGrid2 : Grid
	{
		public static int CreationCount { get; private set; }

		public static int BindCount { get; private set; }

		public static event Action WasUpdated;

		public CounterGrid2()
		{
			CreationCount++;
			WasUpdated?.Invoke();

			DataContextChanged += On_DataContextChanged;
		}

		private void On_DataContextChanged(DependencyObject sender, DataContextChangedEventArgs args)
		{
			if (args.NewValue != null)
			{
				BindCount++;
				WasUpdated?.Invoke();
			}
		}

		public static void Reset()
		{
			CreationCount = 0;
			BindCount = 0;
		}
	}
}
