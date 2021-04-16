﻿using System;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Uno.UI.Toolkit
{
	public partial class TabBar
	{
		#region TabBarItemTemplateSelector
		public DataTemplateSelector TabBarItemTemplateSelector
		{
			get { return (DataTemplateSelector)GetValue(ItemTemplateSelectorProperty); }
			set { SetValue(ItemTemplateSelectorProperty, value); }
		}

		public static DependencyProperty ItemTemplateSelectorProperty { get; } =
			DependencyProperty.Register(nameof(TabBarItemTemplateSelector), typeof(DataTemplateSelector), typeof(TabBar), new PropertyMetadata(default));
		#endregion

		#region TabBarItemTemplate
		public DataTemplate TabBarItemTemplate
		{
			get { return (DataTemplate)GetValue(ItemTemplateProperty); }
			set { SetValue(ItemTemplateProperty, value); }
		}

		public static DependencyProperty ItemTemplateProperty { get; } =
			DependencyProperty.Register(nameof(TabBarItemTemplate), typeof(DataTemplate), typeof(TabBar), new PropertyMetadata(default));
		#endregion

		#region TabBarItemContainerStyleSelector
		public StyleSelector TabBarItemContainerStyleSelector
		{
			get { return (StyleSelector)GetValue(ItemContainerStyleSelectorProperty); }
			set { SetValue(ItemContainerStyleSelectorProperty, value); }
		}

		public static DependencyProperty ItemContainerStyleSelectorProperty { get; } =
			DependencyProperty.Register(nameof(TabBarItemContainerStyleSelector), typeof(StyleSelector), typeof(TabBar), new PropertyMetadata(default));
		#endregion

		#region TabBarItemContainerStyle
		public Style TabBarItemContainerStyle
		{
			get { return (Style)GetValue(ItemContainerStyleProperty); }
			set { SetValue(ItemContainerStyleProperty, value); }
		}

		public static DependencyProperty ItemContainerStyleProperty { get; } =
			DependencyProperty.Register(nameof(TabBarItemContainerStyle), typeof(Style), typeof(TabBar), new PropertyMetadata(default));

		#endregion

		#region TabBarItemsPanel
		public ItemsPanelTemplate TabBarItemsPanel
		{
			get { return (ItemsPanelTemplate)GetValue(TabBarItemsPanelProperty); }
			set { SetValue(TabBarItemsPanelProperty, value); }
		}

		public static DependencyProperty TabBarItemsPanelProperty { get; } =
			DependencyProperty.Register(nameof(TabBarItemsPanel), typeof(ItemsPanelTemplate), typeof(TabBar), new PropertyMetadata(default));
		#endregion

		#region Items
		public IList<object> Items
		{
			get { return (IList<object>)GetValue(ItemsProperty); }
			set { SetValue(ItemsProperty, value); }
		}

		public static DependencyProperty ItemsProperty { get; } =
			DependencyProperty.Register(nameof(Items), typeof(IList<object>), typeof(TabBar), new PropertyMetadata(default, OnPropertyChanged));
		#endregion

		#region ItemsSource
		public object ItemsSource
		{
			get => (object)GetValue(ItemsSourceProperty);
			set => SetValue(ItemsSourceProperty, value);
		}

		public static DependencyProperty ItemsSourceProperty { get; } =
			DependencyProperty.Register(nameof(ItemsSource), typeof(object), typeof(TabBar), new PropertyMetadata(null));

		#endregion

		#region SelectedItem
		public object SelectedItem
		{
			get { return (object)GetValue(SelectedItemProperty); }
			set { SetValue(SelectedItemProperty, value); }
		}

		public static DependencyProperty SelectedItemProperty { get; } =
			DependencyProperty.Register(nameof(SelectedItem), typeof(object), typeof(TabBar), new PropertyMetadata(default, OnPropertyChanged));
		#endregion


		#region ShowSelectionIndicator
		public bool ShowSelectionIndicator
		{
			get { return (bool)GetValue(ShowSelectionIndicatorProperty); }
			set { SetValue(ShowSelectionIndicatorProperty, value); }
		}

		public static DependencyProperty ShowSelectionIndicatorProperty { get; } =
			DependencyProperty.Register(nameof(ShowSelectionIndicator), typeof(bool), typeof(TabBar), new PropertyMetadata(true));
		#endregion

		#region AnimateSelectionIndicator
		public bool AnimateSelectionIndicator
		{
			get { return (bool)GetValue(AnimateSelectionIndicatorProperty); }
			set { SetValue(AnimateSelectionIndicatorProperty, value); }
		}

		public static DependencyProperty AnimateSelectionIndicatorProperty { get; } =
			DependencyProperty.Register(nameof(AnimateSelectionIndicator), typeof(bool), typeof(TabBar), new PropertyMetadata(true));

		#endregion

		#region SelectionIndicatorPlacement
		public SelectionIndicatorPlacement SelectionIndicatorPlacement
		{
			get { return (SelectionIndicatorPlacement)GetValue(SelectionIndicatorPlacementProperty); }
			set { SetValue(SelectionIndicatorPlacementProperty, value); }
		}

		public static DependencyProperty SelectionIndicatorPlacementProperty { get; } =
			DependencyProperty.Register(nameof(SelectionIndicatorPlacement), typeof(SelectionIndicatorPlacement), typeof(TabBar), new PropertyMetadata(SelectionIndicatorPlacement.Below, OnPropertyChanged));
		#endregion

		#region SelectionIndicator
		public UIElement SelectionIndicator
		{
			get { return (UIElement)GetValue(SelectionIndicatorProperty); }
			set { SetValue(SelectionIndicatorProperty, value); }
		}

		public static DependencyProperty SelectionIndicatorProperty { get; } =
			DependencyProperty.Register(nameof(SelectionIndicator), typeof(UIElement), typeof(TabBar), new PropertyMetadata(default));
		#endregion

		#region SelectionIndicatorStyle
		public Style SelectionIndicatorStyle
		{
			get { return (Style)GetValue(SelectionIndicatorStyleProperty); }
			set { SetValue(SelectionIndicatorStyleProperty, value); }
		}

		public static DependencyProperty SelectionIndicatorStyleProperty { get; } =
			DependencyProperty.Register(nameof(SelectionIndicatorStyle), typeof(Style), typeof(TabBar), new PropertyMetadata(default));

		#endregion

		#region SelectionIndicatorTemplate
		public DataTemplate SelectionIndicatorTemplate
		{
			get { return (DataTemplate)GetValue(SelectionIndicatorTemplateProperty); }
			set { SetValue(SelectionIndicatorTemplateProperty, value); }
		}

		public static DependencyProperty SelectionIndicatorTemplateProperty { get; } =
			DependencyProperty.Register(nameof(SelectionIndicatorTemplate), typeof(DataTemplate), typeof(TabBar), new PropertyMetadata(default));
		#endregion

		#region SelectionIndicatorTemplateSelector
		public DataTemplateSelector SelectionIndicatorTemplateSelector
		{
			get { return (DataTemplateSelector)GetValue(SelectionIndicatorTemplateSelectorProperty); }
			set { SetValue(SelectionIndicatorTemplateSelectorProperty, value); }
		}

		public static DependencyProperty SelectionIndicatorTemplateSelectorProperty { get; } =
			DependencyProperty.Register(nameof(SelectionIndicatorTemplateSelector), typeof(DataTemplateSelector), typeof(TabBar), new PropertyMetadata(default));
		#endregion

		private static void OnPropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
		{
			var owner = (TabBar)sender;
			owner.OnPropertyChanged(args);
		}
	}
}
