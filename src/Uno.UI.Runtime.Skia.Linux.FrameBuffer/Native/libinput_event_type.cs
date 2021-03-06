// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//
// Base interactions with libinput derived from https://github.com/AvaloniaUI/Avalonia

namespace Uno.UI.Runtime.Skia.Native
{
	public enum libinput_event_type
	{
		LIBINPUT_EVENT_NONE = 0,

		LIBINPUT_EVENT_DEVICE_ADDED,
		LIBINPUT_EVENT_DEVICE_REMOVED,

		LIBINPUT_EVENT_KEYBOARD_KEY = 300,

		LIBINPUT_EVENT_POINTER_MOTION = 400,
		LIBINPUT_EVENT_POINTER_MOTION_ABSOLUTE,
		LIBINPUT_EVENT_POINTER_BUTTON,
		LIBINPUT_EVENT_POINTER_AXIS,

		LIBINPUT_EVENT_TOUCH_DOWN = 500,
		LIBINPUT_EVENT_TOUCH_UP,
		LIBINPUT_EVENT_TOUCH_MOTION,
		LIBINPUT_EVENT_TOUCH_CANCEL,
		LIBINPUT_EVENT_TOUCH_FRAME,

		LIBINPUT_EVENT_TABLET_TOOL_AXIS = 600,
		LIBINPUT_EVENT_TABLET_TOOL_PROXIMITY,
		LIBINPUT_EVENT_TABLET_TOOL_TIP,
		LIBINPUT_EVENT_TABLET_TOOL_BUTTON,

		LIBINPUT_EVENT_TABLET_PAD_BUTTON = 700,
		LIBINPUT_EVENT_TABLET_PAD_RING,
		LIBINPUT_EVENT_TABLET_PAD_STRIP,

		LIBINPUT_EVENT_GESTURE_SWIPE_BEGIN = 800,
		LIBINPUT_EVENT_GESTURE_SWIPE_UPDATE,
		LIBINPUT_EVENT_GESTURE_SWIPE_END,
		LIBINPUT_EVENT_GESTURE_PINCH_BEGIN,
		LIBINPUT_EVENT_GESTURE_PINCH_UPDATE,
		LIBINPUT_EVENT_GESTURE_PINCH_END,

		LIBINPUT_EVENT_SWITCH_TOGGLE = 900,
	}
}
