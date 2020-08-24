﻿using Windows.ApplicationModel.DataTransfer;

namespace Microsoft.UI.Xaml.Controls
{
	public class TabViewTabDragCompletedEventArgs
    {
		internal TabViewTabDragCompletedEventArgs(DataPackageOperation dropResult, object item, TabViewItem tab)
		{
			DropResult = dropResult;
			Item = item;
			Tab = tab;
		}

		public DataPackageOperation DropResult { get; }

		public object Item { get; }

		public TabViewItem Tab { get; }
	}
}