using NETCoreUI.Platform.Linux.X11.Types;
using System.Runtime.InteropServices;

//source
//https://github.com/AnatolyRybchych/PureX11

namespace X11;

using  __u_char = System.Byte;
using  __u_short = System.UInt16;
using  __u_int = System.UInt32;
using  __u_long = System.UInt64;
using  __int8_t = System.SByte;
using  __uint8_t = System.Byte;
using  __int16_t = System.Int16;
using  __uint16_t = System.UInt16;
using  __int32_t = System.Int32;
using  __uint32_t = System.UInt32;
using  __int64_t = System.Int64;
using  __uint64_t = System.UInt64;
using  __int_least8_t = System.SByte;
using  __uint_least8_t = System.SByte;
using  __int_least16_t = System.Int32;
using  __uint_least16_t = System.Int32;
using  __int_least32_t = System.Int32;
using  __uint_least32_t = System.Int32;
using  __int_least64_t = System.Int32;
using  __uint_least64_t = System.Int32;
using  __quad_t = System.Int64;
using  __u_quad_t = System.UInt64;
using  __intmax_t = System.Int64;
using  __uintmax_t = System.UInt64;
using  __dev_t = System.UInt64;
using  __uid_t = System.UInt32;
using  __gid_t = System.UInt32;
using  __ino_t = System.UInt64;
using  __ino64_t = System.UInt64;
using  __mode_t = System.UInt32;
using  __nlink_t = System.UInt64;
using  __off_t = System.Int64;
using  __off64_t = System.Int64;
using  __pid_t = System.Int32;
using  __clock_t = System.Int64;
using  __rlim_t = System.UInt64;
using  __rlim64_t = System.UInt64;
using  __id_t = System.UInt32;
using  __time_t = System.Int64;
using  __useconds_t = System.UInt32;
using  __suseconds_t = System.Int64;
using  __daddr_t = System.Int32;
using  __key_t = System.Int32;
using  __clockid_t = System.Int32;
using  __timer_t = System.IntPtr /*void*/;
using  __blksize_t = System.Int64;
using  __blkcnt_t = System.Int64;
using  __blkcnt64_t = System.Int64;
using  __fsblkcnt_t = System.UInt64;
using  __fsblkcnt64_t = System.UInt64;
using  __fsfilcnt_t = System.UInt64;
using  __fsfilcnt64_t = System.UInt64;
using  __fsword_t = System.Int64;
using  __ssize_t = System.Int64;
using  __syscall_slong_t = System.Int64;
using  __syscall_ulong_t = System.UInt64;
using  __loff_t = System.Int32;
using  __caddr_t = System.IntPtr /*System.SByte*/;
using  __intptr_t = System.Int64;
using  __socklen_t = System.UInt32;
using  __sig_atomic_t = System.Int32;
using  u_char = System.SByte;
using  u_short = System.Int32;
using  u_int = System.Int32;
using  u_long = System.Int32;
using  quad_t = System.Int32;
using  u_quad_t = System.Int32;
using  loff_t = System.Int32;
using  ino_t = System.Int32;
using  dev_t = System.Int32;
using  gid_t = System.Int32;
using  mode_t = System.Int32;
using  nlink_t = System.Int32;
using  uid_t = System.Int32;
using  off_t = System.Int32;
using  pid_t = System.Int32;
using  id_t = System.Int32;
using  ssize_t = System.Int32;
using  daddr_t = System.Int32;
using  caddr_t = System.SByte;
using  key_t = System.Int32;
using  clock_t = System.Int32;
using  clockid_t = System.Int32;
using  time_t = System.Int32;
using  timer_t = System.IntPtr;
using  int8_t = System.SByte;
using  int16_t = System.Int32;
using  int32_t = System.Int32;
using  int64_t = System.Int32;
using  u_int8_t = System.SByte;
using  u_int16_t = System.Int32;
using  u_int32_t = System.Int32;
using  u_int64_t = System.Int32;
using  suseconds_t = System.Int32;
using  __fd_mask = System.Int64;
using  fd_mask = System.Int32;
using  blksize_t = System.Int32;
using  blkcnt_t = System.Int32;
using  fsblkcnt_t = System.Int32;
using  fsfilcnt_t = System.Int32;
using  pthread_t = System.UInt64;
using  pthread_key_t = System.UInt32;
using  pthread_once_t = System.Int32;
using  XID = System.UInt64;
using  Mask = System.UInt64;
using  Atom = System.UInt64;
using  VisualID = System.UInt64;
using  Time = System.UInt64;
using  Window = System.Int64;
using  Drawable = System.Int64;
using  Font = System.Int64;
using  Pixmap = System.Int64;
using  Cursor = System.Int64;
using  Colormap = System.Int64;
using  GContext = System.Int64;
using  KeySym = System.Int64;
using  KeyCode = System.Byte;
using  ptrdiff_t = System.Int64;
using  wchar_t = System.Int32;
using  XPointer = System.IntPtr /*System.SByte*/;
using  GC = System.IntPtr /*|_XGC*|*/ ;
using  Display = System.IntPtr;
using  XOM = System.IntPtr /*|_XOM*|*/ ;
using  XIM = System.IntPtr /*|_XIM*|*/ ;
using  XIC = System.IntPtr /*|_XIC*|*/ ;
using  XIMStyle = System.UInt64;
using  XVaNestedList = System.IntPtr /*void*/;
using  XIMFeedback = System.UInt64;
using  XIMPreeditState = System.UInt64;
using  XIMResetState = System.UInt64;
using  XIMStringConversionFeedback = System.UInt64;
using  XIMStringConversionPosition = System.UInt16;
using  XIMStringConversionType = System.UInt16;
using  XIMStringConversionOperation = System.UInt16;
using  XIMHotKeyState = System.UInt64;
public struct __fsid_t {
    public System.Int32 __val1;
    public System.Int32 __val2;
}

public struct __sigset_t {
}

public struct fd_set {
}

public struct __pthread_list_t {
    public System.IntPtr /*|__pthread_internal_list*|*/  __prev;
    public System.IntPtr /*|__pthread_internal_list*|*/  __next;
}



[StructLayout(LayoutKind.Explicit, Size = StructSize)]
public struct XEvent {
    public const int StructSize = 24 * sizeof(long);

    [System.Runtime.InteropServices.FieldOffset(0)] public EventType type;		/* must not be changed; first element */
	[System.Runtime.InteropServices.FieldOffset(0)] public XAnyEvent xany;
	[System.Runtime.InteropServices.FieldOffset(0)] public XKeyEvent xkey;
	[System.Runtime.InteropServices.FieldOffset(0)] public XButtonEvent xbutton;
	[System.Runtime.InteropServices.FieldOffset(0)] public XMotionEvent xmotion;
	[System.Runtime.InteropServices.FieldOffset(0)] public XCrossingEvent xcrossing;
	[System.Runtime.InteropServices.FieldOffset(0)] public XFocusChangeEvent xfocus;
	[System.Runtime.InteropServices.FieldOffset(0)] public XExposeEvent xexpose;
	[System.Runtime.InteropServices.FieldOffset(0)] public XGraphicsExposeEvent xgraphicsexpose;
	[System.Runtime.InteropServices.FieldOffset(0)] public XNoExposeEvent xnoexpose;
	[System.Runtime.InteropServices.FieldOffset(0)] public XVisibilityEvent xvisibility;
	[System.Runtime.InteropServices.FieldOffset(0)] public XCreateWindowEvent xcreatewindow;
	[System.Runtime.InteropServices.FieldOffset(0)] public XDestroyWindowEvent xdestroywindow;
	[System.Runtime.InteropServices.FieldOffset(0)] public XUnmapEvent xunmap;
	[System.Runtime.InteropServices.FieldOffset(0)] public XMapEvent xmap;
	[System.Runtime.InteropServices.FieldOffset(0)] public XMapRequestEvent xmaprequest;
	[System.Runtime.InteropServices.FieldOffset(0)] public XReparentEvent xreparent;
	[System.Runtime.InteropServices.FieldOffset(0)] public XConfigureEvent xconfigure;
	[System.Runtime.InteropServices.FieldOffset(0)] public XGravityEvent xgravity;
	[System.Runtime.InteropServices.FieldOffset(0)] public XResizeRequestEvent xresizerequest;
	[System.Runtime.InteropServices.FieldOffset(0)] public XConfigureRequestEvent xconfigurerequest;
	[System.Runtime.InteropServices.FieldOffset(0)] public XCirculateEvent xcirculate;
	[System.Runtime.InteropServices.FieldOffset(0)] public XCirculateRequestEvent xcirculaterequest;
	[System.Runtime.InteropServices.FieldOffset(0)] public XPropertyEvent xproperty;
	[System.Runtime.InteropServices.FieldOffset(0)] public XSelectionClearEvent xselectionclear;
	[System.Runtime.InteropServices.FieldOffset(0)] public XSelectionRequestEvent xselectionrequest;
	[System.Runtime.InteropServices.FieldOffset(0)] public XSelectionEvent xselection;
	[System.Runtime.InteropServices.FieldOffset(0)] public XColormapEvent xcolormap;
	[System.Runtime.InteropServices.FieldOffset(0)] public XClientMessageEvent xclient;
	[System.Runtime.InteropServices.FieldOffset(0)] public XMappingEvent xmapping;
	[System.Runtime.InteropServices.FieldOffset(0)] public XErrorEvent xerror;
	[System.Runtime.InteropServices.FieldOffset(0)] public XKeymapEvent xkeymap;
	[System.Runtime.InteropServices.FieldOffset(0)] public XGenericEvent xgeneric;
	[System.Runtime.InteropServices.FieldOffset(0)] public XGenericEventCookie xcookie;
}

public struct __pthread_slist_t {
    public System.IntPtr /*|__pthread_internal_slist*|*/  __next;
}

public struct max_align_t {
}

public struct XExtData {
    public System.Int32 number;
    public System.IntPtr /*|_XExtData*|*/  next;
    public XPointer private_data;
}

public struct XExtCodes {
    public System.Int32 extension;
    public System.Int32 major_opcode;
    public System.Int32 first_event;
    public System.Int32 first_error;
}

public struct XPixmapFormatValues {
    public System.Int32 depth;
    public System.Int32 bits_per_pixel;
    public System.Int32 scanline_pad;
}

public struct XGCValues {
    public System.Int32 function;
    public System.UInt64 plane_mask;
    public System.UInt64 foreground;
    public System.UInt64 background;
    public System.Int32 line_width;
    public System.Int32 line_style;
    public System.Int32 cap_style;
    public System.Int32 join_style;
    public System.Int32 fill_style;
    public System.Int32 fill_rule;
    public System.Int32 arc_mode;
    public Pixmap tile;
    public Pixmap stipple;
    public System.Int32 ts_x_origin;
    public System.Int32 ts_y_origin;
    public Font font;
    public System.Int32 subwindow_mode;
    public System.Int32 graphics_exposures;
    public System.Int32 clip_x_origin;
    public System.Int32 clip_y_origin;
    public Pixmap clip_mask;
    public System.Int32 dash_offset;
    public System.SByte dashes;
}

public struct Visual {
    public System.IntPtr /*|XExtData*|*/  ext_data;
    public VisualID visualid;
    public System.Int32 class_;
    public System.Int32 bits_per_rgb;
    public System.Int32 map_entries;
}

public struct Depth {
    public System.Int32 depth;
    public System.Int32 nvisuals;
    public System.IntPtr /*|Visual*|*/  visuals;
}

public struct Screen {
    public System.IntPtr /*|XExtData*|*/  ext_data;
    public System.IntPtr /*|_XDisplay*|*/  display;
    public Window root;
    public System.Int32 ndepths;
    public System.IntPtr /*|Depth*|*/  depths;
    public System.Int32 root_depth;
    public System.IntPtr /*|Visual*|*/  root_visual;
    public GC default_gc;
    public Colormap cmap;
    public System.UInt64 white_pixel;
    public System.UInt64 black_pixel;
    public System.Int32 backing_store;
    public System.Int32 save_unders;
    public System.Int64 root_input_mask;
}

public struct ScreenFormat {
    public System.IntPtr /*|XExtData*|*/  ext_data;
    public System.Int32 depth;
    public System.Int32 bits_per_pixel;
    public System.Int32 scanline_pad;
}

public struct XSetWindowAttributes {
    public Pixmap background_pixmap;
    public System.UInt64 background_pixel;
    public Pixmap border_pixmap;
    public System.UInt64 border_pixel;
    public System.Int32 bit_gravity;
    public System.Int32 win_gravity;
    public System.Int32 backing_store;
    public System.UInt64 backing_planes;
    public System.UInt64 backing_pixel;
    public System.Int32 save_under;
    public System.Int64 event_mask;
    public System.Int64 do_not_propagate_mask;
    public System.Int32 override_redirect;
    public Colormap colormap;
    public Cursor cursor;
}

public struct XWindowAttributes {
    public System.Int32 border_width;
    public System.Int32 depth;
    public System.IntPtr /*|Visual*|*/  visual;
    public Window root;
    public System.Int32 class_;
    public System.Int32 bit_gravity;
    public System.Int32 win_gravity;
    public System.Int32 backing_store;
    public System.UInt64 backing_planes;
    public System.UInt64 backing_pixel;
    public System.Int32 save_under;
    public Colormap colormap;
    public System.Int32 map_installed;
    public System.Int32 map_state;
    public System.Int64 all_event_masks;
    public System.Int64 your_event_mask;
    public System.Int64 do_not_propagate_mask;
    public System.Int32 override_redirect;
    public System.IntPtr /*|Screen*|*/  screen;
}

public struct XHostAddress {
    public System.Int32 family;
    public System.Int32 length;
    public System.IntPtr /*System.SByte*/ address;
}

public struct XServerInterpretedAddress {
    public System.Int32 typelength;
    public System.Int32 valuelength;
    public System.IntPtr /*System.SByte*/ type;
    public System.IntPtr /*System.SByte*/ value;
}

public struct XImage {
    public System.Int32 xoffset;
    public System.Int32 format;
    public System.IntPtr /*System.SByte*/ data;
    public System.Int32 byte_order;
    public System.Int32 bitmap_unit;
    public System.Int32 bitmap_bit_order;
    public System.Int32 bitmap_pad;
    public System.Int32 depth;
    public System.Int32 bytes_per_line;
    public System.Int32 bits_per_pixel;
    public System.UInt64 red_mask;
    public System.UInt64 green_mask;
    public System.UInt64 blue_mask;
    public XPointer obdata;
    public IntPtr f;
}

public struct XWindowChanges {
    public System.Int32 border_width;
    public Window sibling;
    public System.Int32 stack_mode;
}

public struct XColor {
    public System.UInt64 pixel;
    public System.SByte flags;
    public System.SByte pad;
}

public struct XSegment {
}

public struct XPoint {
}

public struct XRectangle {
}

public struct XArc {
}

public struct XKeyboardControl {
    public System.Int32 key_click_percent;
    public System.Int32 bell_percent;
    public System.Int32 bell_pitch;
    public System.Int32 bell_duration;
    public System.Int32 led;
    public System.Int32 led_mode;
    public System.Int32 key;
    public System.Int32 auto_repeat_mode;
}

public struct XKeyboardState {
    public System.Int32 key_click_percent;
    public System.Int32 bell_percent;
    public System.UInt64 led_mask;
    public System.Int32 global_auto_repeat;
}

public struct XTimeCoord {
    public Time time;
}

public struct XModifierKeymap {
    public System.Int32 max_keypermod;
    public System.IntPtr /*|KeyCode*|*/  modifiermap;
}



public struct XKeyEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Window window;
    public Window root;
    public Window subwindow;
    public Time time;
    public int x, y, root_x, root_y;
    public System.UInt32 state;
    public System.UInt32 keycode;
    public System.Int32 same_screen;
}

public struct XButtonEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Window window;
    public Window root;
    public Window subwindow;
    public Time time;
    public int x, y, root_x, root_y;
    public System.UInt32 state;
    public System.UInt32 button;
    public System.Int32 same_screen;
}

public struct XMotionEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Window window;
    public Window root;
    public Window subwindow;
    public Time time;
    public int x, y, root_x, root_y;
    public System.UInt32 state;
    public System.SByte is_hint;
    public System.Int32 same_screen;
}

public struct XCrossingEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Window window;
    public Window root;
    public Window subwindow;
    public Time time;
    public int x, y, root_x, root_y;
    public System.Int32 mode;
    public System.Int32 detail;
    public System.Int32 same_screen;
    public System.Int32 focus;
    public System.UInt32 state;
}

public struct XFocusChangeEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Window window;
    public System.Int32 mode;
    public System.Int32 detail;
}

public struct XKeymapEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Window window;
}

public struct XExposeEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Window window;
    public System.Int32 count;
}

public struct XGraphicsExposeEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Drawable drawable;
    public System.Int32 count;
    public System.Int32 major_code;
    public System.Int32 minor_code;
}

public struct XNoExposeEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Drawable drawable;
    public System.Int32 major_code;
    public System.Int32 minor_code;
}

public struct XVisibilityEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Window window;
    public System.Int32 state;
}

public struct XCreateWindowEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Window parent;
    public Window window;
    public System.Int32 border_width;
    public System.Int32 override_redirect;
}

public struct XDestroyWindowEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Window event_;
    public Window window;
}

public struct XUnmapEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Window event_;
    public Window window;
    public System.Int32 from_configure;
}

public struct XMapEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Window event_;
    public Window window;
    public System.Int32 override_redirect;
}

public struct XMapRequestEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Window parent;
    public Window window;
}

public struct XReparentEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Window event_;
    public Window window;
    public Window parent;
    public System.Int32 override_redirect;
}

public struct XConfigureEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Window event_;
    public Window window;
    public System.Int32 border_width;
    public Window above;
    public System.Int32 override_redirect;
}

public struct XGravityEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Window event_;
    public Window window;
}

public struct XResizeRequestEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Window window;
}

public struct XConfigureRequestEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Window parent;
    public Window window;
    public System.Int32 border_width;
    public Window above;
    public System.Int32 detail;
    public System.UInt64 value_mask;
}

public struct XCirculateEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Window event_;
    public Window window;
    public System.Int32 place;
}

public struct XCirculateRequestEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Window parent;
    public Window window;
    public System.Int32 place;
}

public struct XPropertyEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Window window;
    public Atom atom;
    public Time time;
    public System.Int32 state;
}

public struct XSelectionClearEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Window window;
    public Atom selection;
    public Time time;
}

public struct XSelectionRequestEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Window owner;
    public Window requestor;
    public Atom selection;
    public Atom target;
    public Atom property;
    public Time time;
}

public struct XSelectionEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Window requestor;
    public Atom selection;
    public Atom target;
    public Atom property;
    public Time time;
}

public struct XColormapEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Window window;
    public Colormap colormap;
    public System.Int32 new_;
    public System.Int32 state;
}

public struct XEDataObject{ 
    public IntPtr display;
    public GC gc;
    public IntPtr visual;
    public IntPtr screen;
    public IntPtr pixmap_format;
    public IntPtr font; 
}

[StructLayout(LayoutKind.Sequential, Size = 20)]
public struct _BUFFER20BYTES{};

[StructLayout(LayoutKind.Sequential, Size = 40)]
public struct _BUFFER40BYTES { };

public struct XClientMessageEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Window window;
    public Atom message_type;
    public System.Int32 format;

    public _BUFFER40BYTES l;
    public _BUFFER20BYTES data;
}

public struct XMappingEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Window window;
    public System.Int32 request;
    public System.Int32 first_keycode;
    public System.Int32 count;
}

public struct XErrorEvent {
    public System.Int32 type;
    public System.IntPtr /*|Display*|*/  display;
    public XID resourceid;
    public System.UInt64 serial;
    public System.Byte error_code;
    public System.Byte request_code;
    public System.Byte minor_code;
}

public struct XAnyEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public Window window;
}

public struct XGenericEvent {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public System.Int32 extension;
    public System.Int32 evtype;
}

public struct XGenericEventCookie {
    public System.Int32 type;
    public System.UInt64 serial;
    public System.Int32 send_event;
    public System.IntPtr /*|Display*|*/  display;
    public System.Int32 extension;
    public System.Int32 evtype;
    public System.UInt32 cookie;
    public System.IntPtr /*void*/ data;
}

public struct XCharStruct {
    public System.Int16 lbearing;
    public System.Int16 rbearing;
    public System.Int16 width;
    public System.Int16 ascent;
    public System.Int16 descent;
    public System.UInt16 attributes;
}

public struct XFontProp {
    public Atom name;
    public System.UInt64 card32;
}

public struct XFontStruct {
    public System.IntPtr /*|XExtData*|*/  ext_data;
    public Font fid;
    public uint direction;
    public uint min_char_or_byte2;
    public uint max_char_or_byte2;
    public uint min_byte1;
    public uint max_byte1;
    public System.Int32 all_chars_exist;
    public uint default_char;
    public System.Int32 n_properties;
    public System.IntPtr /*|XFontProp*|*/  properties;
    public XCharStruct min_bounds;
    public XCharStruct max_bounds;
    public System.IntPtr /*|XCharStruct*|*/  per_char;
    public System.Int32 ascent;
    public System.Int32 descent;
}

public struct XTextItem {
    public System.IntPtr /*System.SByte*/ chars;
    public System.Int32 nchars;
    public System.Int32 delta;
    public Font font;
}

public struct XChar2b {
    public System.Byte byte1;
    public System.Byte byte2;
}

public struct XTextItem16 {
    public System.IntPtr /*|XChar2b*|*/  chars;
    public System.Int32 nchars;
    public System.Int32 delta;
    public Font font;
}

public struct XFontSetExtents {
    public XRectangle max_ink_extent;
    public XRectangle max_logical_extent;
}

public struct XmbTextItem {
    public System.IntPtr /*System.SByte*/ chars;
    public System.Int32 nchars;
    public System.Int32 delta;
    public IntPtr font_set;
}

public struct XwcTextItem {
    public System.IntPtr /*|wchar_t*|*/  chars;
    public System.Int32 nchars;
    public System.Int32 delta;
    public IntPtr font_set;
}

public struct XOMCharSetList {
    public System.Int32 charset_count;
    public System.IntPtr /*System.SByte*/ charset_list;
}

public struct XOMOrientation {
    public System.Int32 num_orientation;
    public System.IntPtr /*|XOrientation*|*/  orientation;
}

public struct XOMFontInfo {
    public System.Int32 num_font;
    public System.IntPtr /*|XFontStruct**|*/  font_struct_list;
    public System.IntPtr /*System.SByte*/ font_name_list;
}

public struct XIMStyles {
    public System.UInt16 count_styles;
    public System.IntPtr /*|XIMStyle*|*/  supported_styles;
}

public struct XIMCallback {
    public XPointer client_data;
    public IntPtr callback;
}

public struct XICCallback {
    public XPointer client_data;
    public IntPtr callback;
}

public struct XIMText {
    public System.UInt16 length;
    public System.IntPtr /*|XIMFeedback*|*/  feedback;
    public System.Int32 encoding_is_wchar;
    public System.IntPtr /*System.SByte*/ multi_byte;
    public System.IntPtr /*|wchar_t*|*/  wide_char;
    public IntPtr string_;
}

public struct XIMPreeditStateNotifyCallbackStruct {
    public XIMPreeditState state;
}

public struct XIMStringConversionText {
    public System.UInt16 length;
    public System.IntPtr /*|XIMStringConversionFeedback*|*/  feedback;
    public System.Int32 encoding_is_wchar;
    public System.IntPtr /*System.SByte*/ mbs;
    public System.IntPtr /*|wchar_t*|*/  wcs;
    public IntPtr string_;
}

public struct XIMStringConversionCallbackStruct {
    public XIMStringConversionPosition position;
    public int direction;
    public XIMStringConversionOperation operation;
    public System.UInt16 factor;
    public System.IntPtr /*|XIMStringConversionText*|*/  text;
}

public struct XIMPreeditDrawCallbackStruct {
    public System.Int32 caret;
    public System.Int32 chg_first;
    public System.Int32 chg_length;
    public System.IntPtr /*|XIMText*|*/  text;
}

public struct XIMPreeditCaretCallbackStruct {
    public System.Int32 position;
    public int direction;
    public int style;
}

public struct XIMStatusDrawCallbackStruct {
    public int type;
    public System.IntPtr /*|XIMText*|*/  text;
    public Pixmap bitmap;
    public IntPtr data;
}

public struct XIMHotKeyTrigger {
    public KeySym keysym;
    public System.Int32 modifier;
    public System.Int32 modifier_mask;
}

public struct XIMHotKeyTriggers {
    public System.Int32 num_hot_key;
    public System.IntPtr /*|XIMHotKeyTrigger*|*/  key;
}

public struct XIMValuesList {
    public System.UInt16 count_values;
    public System.IntPtr /*System.SByte*/ supported_values;
}



public static class X{
    public const string LibPath = "libX11.so.6";
    
    
    public const string XNRequiredCharSet = "requiredCharSet";
    public const string XNQueryOrientation = "queryOrientation";
    public const string XNBaseFontName = "baseFontName";
    public const string XNOMAutomatic = "omAutomatic";
    public const string XNMissingCharSet = "missingCharSet";
    public const string XNDefaultString = "defaultString";
    public const string XNOrientation = "orientation";
    public const string XNDirectionalDependentDrawing = "directionalDependentDrawing";
    public const string XNContextualDrawing = "contextualDrawing";
    public const string XNFontInfo = "fontInfo";
    public const string XNVaNestedList = "XNVaNestedList";
    public const string XNQueryInputStyle = "queryInputStyle";
    public const string XNClientWindow = "clientWindow";
    public const string XNInputStyle = "inputStyle";
    public const string XNFocusWindow = "focusWindow";
    public const string XNResourceName = "resourceName";
    public const string XNResourceClass = "resourceClass";
    public const string XNGeometryCallback = "geometryCallback";
    public const string XNDestroyCallback = "destroyCallback";
    public const string XNFilterEvents = "filterEvents";
    public const string XNPreeditStartCallback = "preeditStartCallback";
    public const string XNPreeditDoneCallback = "preeditDoneCallback";
    public const string XNPreeditDrawCallback = "preeditDrawCallback";
    public const string XNPreeditCaretCallback = "preeditCaretCallback";
    public const string XNPreeditStateNotifyCallback = "preeditStateNotifyCallback";
    public const string XNPreeditAttributes = "preeditAttributes";
    public const string XNStatusStartCallback = "statusStartCallback";
    public const string XNStatusDoneCallback = "statusDoneCallback";
    public const string XNStatusDrawCallback = "statusDrawCallback";
    public const string XNStatusAttributes = "statusAttributes";
    public const string XNArea = "area";
    public const string XNAreaNeeded = "areaNeeded";
    public const string XNSpotLocation = "spotLocation";
    public const string XNColormap = "colorMap";
    public const string XNStdColormap = "stdColorMap";
    public const string XNForeground = "foreground";
    public const string XNBackground = "background";
    public const string XNBackgroundPixmap = "backgroundPixmap";
    public const string XNFontSet = "fontSet";
    public const string XNLineSpace = "lineSpace";
    public const string XNCursor = "cursor";
    public const string XNQueryIMValuesList = "queryIMValuesList";
    public const string XNQueryICValuesList = "queryICValuesList";
    public const string XNVisiblePosition = "visiblePosition";
    public const string XNR6PreeditCallback = "r6PreeditCallback";
    public const string XNStringConversionCallback = "stringConversionCallback";
    public const string XNStringConversion = "stringConversion";
    public const string XNResetState = "resetState";
    public const string XNHotKey = "hotKey";
    public const string XNHotKeyState = "hotKeyState";
    public const string XNPreeditState = "preeditState";
    public const string XNSeparatorofNestedList = "separatorofNestedList";
    public const long X_HAVE_UTF8_STRING = 1;
    public const long True = 1;
    public const long False = 0;
    public const long QueuedAlready = 0;
    public const long QueuedAfterReading = 1;
    public const long QueuedAfterFlush = 2;
    public const long AllPlanes = ((long)~0L);
    public const long XIMPreeditArea = 0x0001L;
    public const long XIMPreeditCallbacks = 0x0002L;
    public const long XIMPreeditPosition = 0x0004L;
    public const long XIMPreeditNothing = 0x0008L;
    public const long XIMPreeditNone = 0x0010L;
    public const long XIMStatusArea = 0x0100L;
    public const long XIMStatusCallbacks = 0x0200L;
    public const long XIMStatusNothing = 0x0400L;
    public const long XIMStatusNone = 0x0800L;
    public const long XBufferOverflow = -1;
    public const long XLookupNone = 1;
    public const long XLookupChars = 2;
    public const long XLookupKeySym = 3;
    public const long XLookupBoth = 4;
    public const long XIMReverse = 1L;
    public const long XIMUnderline = (1L<<1);
    public const long XIMHighlight = (1L<<2);
    public const long XIMPrimary = (1L<<5);
    public const long XIMSecondary = (1L<<6);
    public const long XIMTertiary = (1L<<7);
    public const long XIMVisibleToForward = (1L<<8);
    public const long XIMVisibleToBackword = (1L<<9);
    public const long XIMVisibleToCenter = (1L<<10);
    public const long XIMPreeditUnKnown = 0L;
    public const long XIMPreeditEnable = 1L;
    public const long XIMPreeditDisable = (1L<<1);
    public const long XIMInitialState = 1L;
    public const long XIMPreserveState = (1L<<1);
    public const long XIMStringConversionLeftEdge = (0x00000001);
    public const long XIMStringConversionRightEdge = (0x00000002);
    public const long XIMStringConversionTopEdge = (0x00000004);
    public const long XIMStringConversionBottomEdge = (0x00000008);
    public const long XIMStringConversionConcealed = (0x00000010);
    public const long XIMStringConversionWrapped = (0x00000020);
    public const long XIMStringConversionBuffer = (0x0001);
    public const long XIMStringConversionLine = (0x0002);
    public const long XIMStringConversionWord = (0x0003);
    public const long XIMStringConversionChar = (0x0004);
    public const long XIMStringConversionSubstitution = (0x0001);
    public const long XIMStringConversionRetrieval = (0x0002);
    public const long XIMHotKeyStateON = (0x0001L);
    public const long XIMHotKeyStateOFF = (0x0002L);
    
    
    
    [DllImport(LibPath)]
    public static extern System.Int32 _Xmblen ( System.IntPtr /*System.SByte*/ str, System.Int32 len);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|XFontStruct*|*/  XLoadQueryFont ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|XFontStruct*|*/  XQueryFont ( System.IntPtr /*|Display*|*/  arg0, XID arg1);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|XTimeCoord*|*/  XGetMotionEvents ( System.IntPtr /*|Display*|*/  arg0, Window arg1, Time arg2, Time arg3, System.IntPtr /*System.Int32*/ arg4);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|XModifierKeymap*|*/  XDeleteModifiermapEntry ( System.IntPtr /*|XModifierKeymap*|*/  arg0, KeyCode arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|XModifierKeymap*|*/  XGetModifierMapping ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|XModifierKeymap*|*/  XInsertModifiermapEntry ( System.IntPtr /*|XModifierKeymap*|*/  arg0, KeyCode arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|XModifierKeymap*|*/  XNewModifiermap ( System.Int32 arg0);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|XImage*|*/  XCreateImage ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|Visual*|*/  arg1, System.Int32 arg2, System.Int32 arg3, System.Int32 arg4, System.IntPtr /*System.SByte*/ arg5, System.Int32 arg6, System.Int32 arg7, System.Int32 arg8, System.Int32 arg9);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XInitImage ( System.IntPtr /*|XImage*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|XImage*|*/  XGetImage ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, System.Int32 arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5, System.Int64 arg6, System.Int32 arg7);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|XImage*|*/  XGetSubImage ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, System.Int32 arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5, System.Int64 arg6, System.Int32 arg7, System.IntPtr /*|XImage*|*/  arg8, System.Int32 arg9, System.Int32 arg10);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|Display*|*/  XOpenDisplay ( System.IntPtr /*System.SByte*/ arg0);
    
    [DllImport(LibPath)]
    public static extern void XrmInitialize ();
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*System.SByte*/ XFetchBytes ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.Int32*/ arg1);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*System.SByte*/ XFetchBuffer ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.Int32*/ arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*System.SByte*/ XGetAtomName ( System.IntPtr /*|Display*|*/  arg0, Atom arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XGetAtomNames ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|Atom*|*/  arg1, System.Int32 arg2, System.IntPtr /*System.SByte*/ arg3);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*System.SByte*/ XGetDefault ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.IntPtr /*System.SByte*/ arg2);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*System.SByte*/ XDisplayName ( System.IntPtr /*System.SByte*/ arg0);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*System.SByte*/ XKeysymToString ( KeySym arg0);
    
    [DllImport(LibPath)]
    public static extern Atom XInternAtom ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XInternAtoms ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2, System.Int32 arg3, System.IntPtr /*|Atom*|*/  arg4);
    
    [DllImport(LibPath)]
    public static extern Colormap XCopyColormapAndFree ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1);
    
    [DllImport(LibPath)]
    public static extern Colormap XCreateColormap ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*|Visual*|*/  arg2, System.Int32 arg3);
    
    [DllImport(LibPath)]
    public static extern Cursor XCreatePixmapCursor ( System.IntPtr /*|Display*|*/  arg0, Pixmap arg1, Pixmap arg2, System.IntPtr /*|XColor*|*/  arg3, System.IntPtr /*|XColor*|*/  arg4, System.Int32 arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static extern Cursor XCreateGlyphCursor ( System.IntPtr /*|Display*|*/  arg0, Font arg1, Font arg2, System.Int32 arg3, System.Int32 arg4, System.IntPtr /*|XColor*|*/  arg5, System.IntPtr /*|XColor*|*/  arg6);
    
    [DllImport(LibPath)]
    public static extern Cursor XCreateFontCursor ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static extern Font XLoadFont ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1);
    
    [DllImport(LibPath)]
    public static extern GC XCreateGC ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, System.Int64 arg2, System.IntPtr /*|XGCValues*|*/  arg3);
    
    [DllImport(LibPath)]
    public static extern GContext XGContextFromGC ( GC arg0);
    
    [DllImport(LibPath)]
    public static extern void XFlushGC ( System.IntPtr /*|Display*|*/  arg0, GC arg1);
    
    [DllImport(LibPath)]
    public static extern Pixmap XCreatePixmap ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, System.Int32 arg2, System.Int32 arg3, System.Int32 arg4);
    
    [DllImport(LibPath)]
    public static extern Pixmap XCreateBitmapFromData ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, System.IntPtr /*System.SByte*/ arg2, System.Int32 arg3, System.Int32 arg4);
    
    [DllImport(LibPath)]
    public static extern Pixmap XCreatePixmapFromBitmapData ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, System.IntPtr /*System.SByte*/ arg2, System.Int32 arg3, System.Int32 arg4, System.Int64 arg5, System.Int64 arg6, System.Int32 arg7);
    
    [DllImport(LibPath)]
    public static extern Window XCreateSimpleWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2, System.Int32 arg3, System.UInt32 arg4, System.UInt32 arg5, System.UInt32 arg6, System.Int64 arg7, System.Int64 arg8);
    
    [DllImport(LibPath)]
    public static extern Window XGetSelectionOwner ( System.IntPtr /*|Display*|*/  arg0, Atom arg1);
    
    [DllImport(LibPath)]
    public static extern Window XCreateWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6, System.Int32 arg7, System.Int32 arg8, System.IntPtr /*|Visual*|*/  arg9, System.Int64 arg10, System.IntPtr /*|XSetWindowAttributes*|*/  arg11);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|Colormap*|*/  XListInstalledColormaps ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*System.Int32*/ arg2);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*System.SByte*/ XListFonts ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2, System.IntPtr /*System.Int32*/ arg3);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*System.SByte*/ XListFontsWithInfo ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2, System.IntPtr /*System.Int32*/ arg3, System.IntPtr /*|XFontStruct**|*/  arg4);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*System.SByte*/ XGetFontPath ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.Int32*/ arg1);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*System.SByte*/ XListExtensions ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.Int32*/ arg1);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|Atom*|*/  XListProperties ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*System.Int32*/ arg2);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|XHostAddress*|*/  XListHosts ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.Int32*/ arg1, System.IntPtr /*System.Int32*/ arg2);
    
    [DllImport(LibPath)]
    public static extern KeySym XKeycodeToKeysym ( System.IntPtr /*|Display*|*/  arg0, KeyCode arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern KeySym XLookupKeysym ( System.IntPtr /*|XKeyEvent*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|KeySym*|*/  XGetKeyboardMapping ( System.IntPtr /*|Display*|*/  arg0, KeyCode arg1, System.Int32 arg2, System.IntPtr /*System.Int32*/ arg3);
    
    [DllImport(LibPath)]
    public static extern KeySym XStringToKeysym ( System.IntPtr /*System.SByte*/ arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int64 XMaxRequestSize ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int64 XExtendedMaxRequestSize ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*System.SByte*/ XResourceManagerString ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*System.SByte*/ XScreenResourceString ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.UInt64 XDisplayMotionBufferSize ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern VisualID XVisualIDFromVisual ( System.IntPtr /*|Visual*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XInitThreads ();
    
    [DllImport(LibPath)]
    public static extern void XLockDisplay ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern void XUnlockDisplay ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|XExtCodes*|*/  XInitExtension ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|XExtCodes*|*/  XAddExtension ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|XExtData*|*/  XFindOnExtensionList ( System.IntPtr /*|XExtData**|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|XExtData**|*/  XEHeadOfExtensionList ( XEDataObject arg0);
    
    [DllImport(LibPath)]
    public static extern Window XRootWindow ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static extern Window XDefaultRootWindow ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern Window XRootWindowOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|Visual*|*/  XDefaultVisual ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|Visual*|*/  XDefaultVisualOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern GC XDefaultGC ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static extern GC XDefaultGCOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.UInt64 XBlackPixel ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static extern System.UInt64 XWhitePixel ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static extern System.UInt64 XAllPlanes ();
    
    [DllImport(LibPath)]
    public static extern System.UInt64 XBlackPixelOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.UInt64 XWhitePixelOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.UInt64 XNextRequest ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.UInt64 XLastKnownRequestProcessed ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*System.SByte*/ XServerVendor ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*System.SByte*/ XDisplayString ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern Colormap XDefaultColormap ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static extern Colormap XDefaultColormapOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|Display*|*/  XDisplayOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|Screen*|*/  XScreenOfDisplay ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|Screen*|*/  XDefaultScreenOfDisplay ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int64 XEventMaskOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XScreenNumberOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern IntPtr XSetErrorHandler ( IntPtr arg0);
    
    [DllImport(LibPath)]
    public static extern IntPtr XSetIOErrorHandler ( IntPtr arg0);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|XPixmapFormatValues*|*/  XListPixmapFormats ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.Int32*/ arg1);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*System.Int32*/ XListDepths ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1, System.IntPtr /*System.Int32*/ arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XReconfigureWMWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2, System.Int32 arg3, System.IntPtr /*|XWindowChanges*|*/  arg4);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XGetWMProtocols ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*|Atom**|*/  arg2, System.IntPtr /*System.Int32*/ arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetWMProtocols ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*|Atom*|*/  arg2, System.Int32 arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XIconifyWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XWithdrawWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XGetCommand ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*System.SByte*/ arg2, System.IntPtr /*System.Int32*/ arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XGetWMColormapWindows ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*|Window**|*/  arg2, System.IntPtr /*System.Int32*/ arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetWMColormapWindows ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*|Window*|*/  arg2, System.Int32 arg3);
    
    [DllImport(LibPath)]
    public static extern void XFreeStringList ( System.IntPtr /*System.SByte*/ arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetTransientForHint ( System.IntPtr /*|Display*|*/  arg0, Window arg1, Window arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XActivateScreenSaver ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XAddHost ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XHostAddress*|*/  arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XAddHosts ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XHostAddress*|*/  arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XAddToExtensionList ( System.IntPtr /*|_XExtData**|*/  arg0, System.IntPtr /*|XExtData*|*/  arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XAddToSaveSet ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XAllocColor ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1, System.IntPtr /*|XColor*|*/  arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XAllocColorCells ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1, System.Int32 arg2, System.IntPtr /*System.Int64*/ arg3, System.Int32 arg4, System.IntPtr /*System.Int64*/ arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XAllocColorPlanes ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1, System.Int32 arg2, System.IntPtr /*System.Int64*/ arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6, System.Int32 arg7, System.IntPtr /*System.Int64*/ arg8, System.IntPtr /*System.Int64*/ arg9, System.IntPtr /*System.Int64*/ arg10);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XAllocNamedColor ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1, System.IntPtr /*System.SByte*/ arg2, System.IntPtr /*|XColor*|*/  arg3, System.IntPtr /*|XColor*|*/  arg4);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XAllowEvents ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1, Time arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XAutoRepeatOff ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XAutoRepeatOn ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XBell ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XBitmapBitOrder ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XBitmapPad ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XBitmapUnit ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XCellsOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XChangeActivePointerGrab ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1, Cursor arg2, Time arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XChangeGC ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int64 arg2, System.IntPtr /*|XGCValues*|*/  arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XChangeKeyboardControl ( System.IntPtr /*|Display*|*/  arg0, System.Int64 arg1, System.IntPtr /*|XKeyboardControl*|*/  arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XChangeKeyboardMapping ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1, System.Int32 arg2, System.IntPtr /*|KeySym*|*/  arg3, System.Int32 arg4);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XChangePointerControl ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1, System.Int32 arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XChangeProperty ( System.IntPtr /*|Display*|*/  arg0, Window arg1, Atom arg2, Atom arg3, System.Int32 arg4, System.Int32 arg5, System.IntPtr /*System.SByte*/ arg6, System.Int32 arg7);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XChangeSaveSet ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XChangeWindowAttributes ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int64 arg2, System.IntPtr /*|XSetWindowAttributes*|*/  arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XCheckIfEvent ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XEvent*|*/  arg1, System.Int32 arg2, System.IntPtr /*|Display*|*/  arg3, System.IntPtr /*|XEvent*|*/  arg4, XPointer arg5, XPointer arg6);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XCheckMaskEvent ( System.IntPtr /*|Display*|*/  arg0, System.Int64 arg1, System.IntPtr /*|XEvent*|*/  arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XCheckTypedEvent ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1, System.IntPtr /*|XEvent*|*/  arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XCheckTypedWindowEvent ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2, System.IntPtr /*|XEvent*|*/  arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XCheckWindowEvent ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int64 arg2, System.IntPtr /*|XEvent*|*/  arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XCirculateSubwindows ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XCirculateSubwindowsDown ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XCirculateSubwindowsUp ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XClearArea ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XClearWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XCloseDisplay ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XConfigureWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2, System.IntPtr /*|XWindowChanges*|*/  arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XConnectionNumber ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XConvertSelection ( System.IntPtr /*|Display*|*/  arg0, Atom arg1, Atom arg2, Atom arg3, Window arg4, Time arg5);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XCopyArea ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, Drawable arg2, GC arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6, System.Int32 arg7, System.Int32 arg8, System.Int32 arg9);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XCopyGC ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int64 arg2, GC arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XCopyPlane ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, Drawable arg2, GC arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6, System.Int32 arg7, System.Int32 arg8, System.Int32 arg9, System.Int64 arg10);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDefaultDepth ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDefaultDepthOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDefaultScreen ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDefineCursor ( System.IntPtr /*|Display*|*/  arg0, Window arg1, Cursor arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDeleteProperty ( System.IntPtr /*|Display*|*/  arg0, Window arg1, Atom arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDestroyWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDestroySubwindows ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDoesBackingStore ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDoesSaveUnders ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDisableAccessControl ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDisplayCells ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDisplayHeight ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDisplayHeightMM ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDisplayKeycodes ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.Int32*/ arg1, System.IntPtr /*System.Int32*/ arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDisplayPlanes ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDisplayWidth ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDisplayWidthMM ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDrawArc ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6, System.Int32 arg7, System.Int32 arg8);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDrawArcs ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.IntPtr /*|XArc*|*/  arg3, System.Int32 arg4);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDrawImageString ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4, System.IntPtr /*System.SByte*/ arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDrawImageString16 ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4, System.IntPtr /*|XChar2b*|*/  arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDrawLine ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDrawLines ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.IntPtr /*|XPoint*|*/  arg3, System.Int32 arg4, System.Int32 arg5);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDrawPoint ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDrawPoints ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.IntPtr /*|XPoint*|*/  arg3, System.Int32 arg4, System.Int32 arg5);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDrawRectangle ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDrawRectangles ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.IntPtr /*|XRectangle*|*/  arg3, System.Int32 arg4);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDrawSegments ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.IntPtr /*|XSegment*|*/  arg3, System.Int32 arg4);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDrawString ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4, System.IntPtr /*System.SByte*/ arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDrawString16 ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4, System.IntPtr /*|XChar2b*|*/  arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDrawText ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4, System.IntPtr /*|XTextItem*|*/  arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDrawText16 ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4, System.IntPtr /*|XTextItem16*|*/  arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XEnableAccessControl ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XEventsQueued ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XFetchName ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*System.SByte*/ arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XFillArc ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6, System.Int32 arg7, System.Int32 arg8);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XFillArcs ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.IntPtr /*|XArc*|*/  arg3, System.Int32 arg4);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XFillPolygon ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.IntPtr /*|XPoint*|*/  arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XFillRectangle ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XFillRectangles ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.IntPtr /*|XRectangle*|*/  arg3, System.Int32 arg4);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XFlush ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XForceScreenSaver ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XFree ( System.IntPtr /*void*/ arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XFreeColormap ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XFreeColors ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1, System.IntPtr /*System.Int64*/ arg2, System.Int32 arg3, System.Int64 arg4);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XFreeCursor ( System.IntPtr /*|Display*|*/  arg0, Cursor arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XFreeExtensionList ( System.IntPtr /*System.SByte*/ arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XFreeFont ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XFontStruct*|*/  arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XFreeFontInfo ( System.IntPtr /*System.SByte*/ arg0, System.IntPtr /*|XFontStruct*|*/  arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XFreeFontNames ( System.IntPtr /*System.SByte*/ arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XFreeFontPath ( System.IntPtr /*System.SByte*/ arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XFreeGC ( System.IntPtr /*|Display*|*/  arg0, GC arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XFreeModifiermap ( System.IntPtr /*|XModifierKeymap*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XFreePixmap ( System.IntPtr /*|Display*|*/  arg0, Pixmap arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XGeometry ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1, System.IntPtr /*System.SByte*/ arg2, System.IntPtr /*System.SByte*/ arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6, System.Int32 arg7, System.Int32 arg8, System.IntPtr /*System.Int32*/ arg9, System.IntPtr /*System.Int32*/ arg10, System.IntPtr /*System.Int32*/ arg11, System.IntPtr /*System.Int32*/ arg12);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XGetErrorDatabaseText ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.IntPtr /*System.SByte*/ arg2, System.IntPtr /*System.SByte*/ arg3, System.IntPtr /*System.SByte*/ arg4, System.Int32 arg5);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XGetErrorText ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1, System.IntPtr /*System.SByte*/ arg2, System.Int32 arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XGetFontProperty ( System.IntPtr /*|XFontStruct*|*/  arg0, Atom arg1, System.IntPtr /*System.Int64*/ arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XGetGCValues ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int64 arg2, System.IntPtr /*|XGCValues*|*/  arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XGetGeometry ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, System.IntPtr /*|Window*|*/  arg2, System.IntPtr /*System.Int32*/ arg3, System.IntPtr /*System.Int32*/ arg4, System.IntPtr /*System.Int32*/ arg5, System.IntPtr /*System.Int32*/ arg6, System.IntPtr /*System.Int32*/ arg7, System.IntPtr /*System.Int32*/ arg8);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XGetIconName ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*System.SByte*/ arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XGetInputFocus ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|Window*|*/  arg1, System.IntPtr /*System.Int32*/ arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XGetKeyboardControl ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XKeyboardState*|*/  arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XGetPointerControl ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.Int32*/ arg1, System.IntPtr /*System.Int32*/ arg2, System.IntPtr /*System.Int32*/ arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XGetPointerMapping ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XGetScreenSaver ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.Int32*/ arg1, System.IntPtr /*System.Int32*/ arg2, System.IntPtr /*System.Int32*/ arg3, System.IntPtr /*System.Int32*/ arg4);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XGetTransientForHint ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*|Window*|*/  arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XGetWindowProperty ( System.IntPtr /*|Display*|*/  arg0, Window arg1, Atom arg2, System.Int64 arg3, System.Int64 arg4, System.Int32 arg5, Atom arg6, System.IntPtr /*|Atom*|*/  arg7, System.IntPtr /*System.Int32*/ arg8, System.IntPtr /*System.Int64*/ arg9, System.IntPtr /*System.Int64*/ arg10, System.IntPtr /*System.SByte*/ arg11);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XGetWindowAttributes ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*|XWindowAttributes*|*/  arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XGrabButton ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1, System.Int32 arg2, Window arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6, System.Int32 arg7, Window arg8, Cursor arg9);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XGrabKey ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1, System.Int32 arg2, Window arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XGrabKeyboard ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2, System.Int32 arg3, System.Int32 arg4, Time arg5);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XGrabPointer ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5, Window arg6, Cursor arg7, Time arg8);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XGrabServer ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XHeightMMOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XHeightOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XIfEvent ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XEvent*|*/  arg1, System.Int32 arg2, System.IntPtr /*|Display*|*/  arg3, System.IntPtr /*|XEvent*|*/  arg4, XPointer arg5, XPointer arg6);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XImageByteOrder ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XInstallColormap ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1);
    
    [DllImport(LibPath)]
    public static extern KeyCode XKeysymToKeycode ( System.IntPtr /*|Display*|*/  arg0, KeySym arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XKillClient ( System.IntPtr /*|Display*|*/  arg0, XID arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XLookupColor ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1, System.IntPtr /*System.SByte*/ arg2, System.IntPtr /*|XColor*|*/  arg3, System.IntPtr /*|XColor*|*/  arg4);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XLowerWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XMapRaised ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XMapSubwindows ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XMapWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XMaskEvent ( System.IntPtr /*|Display*|*/  arg0, System.Int64 arg1, System.IntPtr /*|XEvent*|*/  arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XMaxCmapsOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XMinCmapsOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XMoveResizeWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XMoveWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2, System.Int32 arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XNextEvent ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XEvent*|*/  arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XNoOp ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XParseColor ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1, System.IntPtr /*System.SByte*/ arg2, System.IntPtr /*|XColor*|*/  arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XParseGeometry ( System.IntPtr /*System.SByte*/ arg0, System.IntPtr /*System.Int32*/ arg1, System.IntPtr /*System.Int32*/ arg2, System.IntPtr /*System.Int32*/ arg3, System.IntPtr /*System.Int32*/ arg4);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XPeekEvent ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XEvent*|*/  arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XPeekIfEvent ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XEvent*|*/  arg1, System.Int32 arg2, System.IntPtr /*|Display*|*/  arg3, System.IntPtr /*|XEvent*|*/  arg4, XPointer arg5, XPointer arg6);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XPending ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XPlanesOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XProtocolRevision ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XProtocolVersion ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XPutBackEvent ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XEvent*|*/  arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XPutImage ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.IntPtr /*|XImage*|*/  arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6, System.Int32 arg7, System.Int32 arg8, System.Int32 arg9);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XQLength ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XQueryBestCursor ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, System.Int32 arg2, System.Int32 arg3, System.IntPtr /*System.Int32*/ arg4, System.IntPtr /*System.Int32*/ arg5);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XQueryBestSize ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1, Drawable arg2, System.Int32 arg3, System.Int32 arg4, System.IntPtr /*System.Int32*/ arg5, System.IntPtr /*System.Int32*/ arg6);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XQueryBestStipple ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, System.Int32 arg2, System.Int32 arg3, System.IntPtr /*System.Int32*/ arg4, System.IntPtr /*System.Int32*/ arg5);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XQueryBestTile ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, System.Int32 arg2, System.Int32 arg3, System.IntPtr /*System.Int32*/ arg4, System.IntPtr /*System.Int32*/ arg5);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XQueryColor ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1, System.IntPtr /*|XColor*|*/  arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XQueryColors ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1, System.IntPtr /*|XColor*|*/  arg2, System.Int32 arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XQueryExtension ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.IntPtr /*System.Int32*/ arg2, System.IntPtr /*System.Int32*/ arg3, System.IntPtr /*System.Int32*/ arg4);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XQueryKeymap ( System.IntPtr /*|Display*|*/  arg0, IntPtr arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XQueryPointer ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*|Window*|*/  arg2, System.IntPtr /*|Window*|*/  arg3, System.IntPtr /*System.Int32*/ arg4, System.IntPtr /*System.Int32*/ arg5, System.IntPtr /*System.Int32*/ arg6, System.IntPtr /*System.Int32*/ arg7, System.IntPtr /*System.Int32*/ arg8);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XQueryTextExtents ( System.IntPtr /*|Display*|*/  arg0, XID arg1, System.IntPtr /*System.SByte*/ arg2, System.Int32 arg3, System.IntPtr /*System.Int32*/ arg4, System.IntPtr /*System.Int32*/ arg5, System.IntPtr /*System.Int32*/ arg6, System.IntPtr /*|XCharStruct*|*/  arg7);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XQueryTextExtents16 ( System.IntPtr /*|Display*|*/  arg0, XID arg1, System.IntPtr /*|XChar2b*|*/  arg2, System.Int32 arg3, System.IntPtr /*System.Int32*/ arg4, System.IntPtr /*System.Int32*/ arg5, System.IntPtr /*System.Int32*/ arg6, System.IntPtr /*|XCharStruct*|*/  arg7);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XQueryTree ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*|Window*|*/  arg2, System.IntPtr /*|Window*|*/  arg3, System.IntPtr /*|Window**|*/  arg4, System.IntPtr /*System.Int32*/ arg5);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XRaiseWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XReadBitmapFile ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, System.IntPtr /*System.SByte*/ arg2, System.IntPtr /*System.Int32*/ arg3, System.IntPtr /*System.Int32*/ arg4, System.IntPtr /*|Pixmap*|*/  arg5, System.IntPtr /*System.Int32*/ arg6, System.IntPtr /*System.Int32*/ arg7);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XReadBitmapFileData ( System.IntPtr /*System.SByte*/ arg0, System.IntPtr /*System.Int32*/ arg1, System.IntPtr /*System.Int32*/ arg2, System.IntPtr /*System.SByte*/ arg3, System.IntPtr /*System.Int32*/ arg4, System.IntPtr /*System.Int32*/ arg5);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XRebindKeysym ( System.IntPtr /*|Display*|*/  arg0, KeySym arg1, System.IntPtr /*|KeySym*|*/  arg2, System.Int32 arg3, System.IntPtr /*System.SByte*/ arg4, System.Int32 arg5);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XRecolorCursor ( System.IntPtr /*|Display*|*/  arg0, Cursor arg1, System.IntPtr /*|XColor*|*/  arg2, System.IntPtr /*|XColor*|*/  arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XRefreshKeyboardMapping ( System.IntPtr /*|XMappingEvent*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XRemoveFromSaveSet ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XRemoveHost ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XHostAddress*|*/  arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XRemoveHosts ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XHostAddress*|*/  arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XReparentWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1, Window arg2, System.Int32 arg3, System.Int32 arg4);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XResetScreenSaver ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XResizeWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2, System.Int32 arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XRestackWindows ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|Window*|*/  arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XRotateBuffers ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XRotateWindowProperties ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*|Atom*|*/  arg2, System.Int32 arg3, System.Int32 arg4);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XScreenCount ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSelectInput ( System.IntPtr /*|Display*|*/  arg0, Window arg1, EventMask arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSendEvent ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2, System.Int64 arg3, System.IntPtr /*|XEvent*|*/  arg4);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetAccessControl ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetArcMode ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetBackground ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int64 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetClipMask ( System.IntPtr /*|Display*|*/  arg0, GC arg1, Pixmap arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetClipOrigin ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int32 arg2, System.Int32 arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetClipRectangles ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int32 arg2, System.Int32 arg3, System.IntPtr /*|XRectangle*|*/  arg4, System.Int32 arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetCloseDownMode ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetCommand ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*System.SByte*/ arg2, System.Int32 arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetDashes ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int32 arg2, System.IntPtr /*System.SByte*/ arg3, System.Int32 arg4);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetFillRule ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetFillStyle ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetFont ( System.IntPtr /*|Display*|*/  arg0, GC arg1, Font arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetFontPath ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetForeground ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int64 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetFunction ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetGraphicsExposures ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetIconName ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*System.SByte*/ arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetInputFocus ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2, Time arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetLineAttributes ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int32 arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetModifierMapping ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XModifierKeymap*|*/  arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetPlaneMask ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int64 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetPointerMapping ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetScreenSaver ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1, System.Int32 arg2, System.Int32 arg3, System.Int32 arg4);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetSelectionOwner ( System.IntPtr /*|Display*|*/  arg0, Atom arg1, Window arg2, Time arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetState ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int64 arg2, System.Int64 arg3, System.Int32 arg4, System.Int64 arg5);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetStipple ( System.IntPtr /*|Display*|*/  arg0, GC arg1, Pixmap arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetSubwindowMode ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetTSOrigin ( System.IntPtr /*|Display*|*/  arg0, GC arg1, System.Int32 arg2, System.Int32 arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetTile ( System.IntPtr /*|Display*|*/  arg0, GC arg1, Pixmap arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetWindowBackground ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int64 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetWindowBackgroundPixmap ( System.IntPtr /*|Display*|*/  arg0, Window arg1, Pixmap arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetWindowBorder ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int64 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetWindowBorderPixmap ( System.IntPtr /*|Display*|*/  arg0, Window arg1, Pixmap arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetWindowBorderWidth ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSetWindowColormap ( System.IntPtr /*|Display*|*/  arg0, Window arg1, Colormap arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XStoreBuffer ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2, System.Int32 arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XStoreBytes ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XStoreColor ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1, System.IntPtr /*|XColor*|*/  arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XStoreColors ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1, System.IntPtr /*|XColor*|*/  arg2, System.Int32 arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XStoreName ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.IntPtr /*System.SByte*/ arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XStoreNamedColor ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1, System.IntPtr /*System.SByte*/ arg2, System.Int64 arg3, System.Int32 arg4);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSync ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XTextExtents ( System.IntPtr /*|XFontStruct*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2, System.IntPtr /*System.Int32*/ arg3, System.IntPtr /*System.Int32*/ arg4, System.IntPtr /*System.Int32*/ arg5, System.IntPtr /*|XCharStruct*|*/  arg6);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XTextExtents16 ( System.IntPtr /*|XFontStruct*|*/  arg0, System.IntPtr /*|XChar2b*|*/  arg1, System.Int32 arg2, System.IntPtr /*System.Int32*/ arg3, System.IntPtr /*System.Int32*/ arg4, System.IntPtr /*System.Int32*/ arg5, System.IntPtr /*|XCharStruct*|*/  arg6);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XTextWidth ( System.IntPtr /*|XFontStruct*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XTextWidth16 ( System.IntPtr /*|XFontStruct*|*/  arg0, System.IntPtr /*|XChar2b*|*/  arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XTranslateCoordinates ( System.IntPtr /*|Display*|*/  arg0, Window arg1, Window arg2, System.Int32 arg3, System.Int32 arg4, System.IntPtr /*System.Int32*/ arg5, System.IntPtr /*System.Int32*/ arg6, System.IntPtr /*|Window*|*/  arg7);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XUndefineCursor ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XUngrabButton ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1, System.Int32 arg2, Window arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XUngrabKey ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1, System.Int32 arg2, Window arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XUngrabKeyboard ( System.IntPtr /*|Display*|*/  arg0, Time arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XUngrabPointer ( System.IntPtr /*|Display*|*/  arg0, Time arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XUngrabServer ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XUninstallColormap ( System.IntPtr /*|Display*|*/  arg0, Colormap arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XUnloadFont ( System.IntPtr /*|Display*|*/  arg0, Font arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XUnmapSubwindows ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XUnmapWindow ( System.IntPtr /*|Display*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XVendorRelease ( System.IntPtr /*|Display*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XWarpPointer ( System.IntPtr /*|Display*|*/  arg0, Window arg1, Window arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6, System.Int32 arg7, System.Int32 arg8);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XWidthMMOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XWidthOfScreen ( System.IntPtr /*|Screen*|*/  arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XWindowEvent ( System.IntPtr /*|Display*|*/  arg0, Window arg1, System.Int64 arg2, System.IntPtr /*|XEvent*|*/  arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XWriteBitmapFile ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, Pixmap arg2, System.Int32 arg3, System.Int32 arg4, System.Int32 arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XSupportsLocale ();
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*System.SByte*/ XSetLocaleModifiers ( System.IntPtr /*System.SByte*/ arg0);
    
    [DllImport(LibPath)]
    public static extern XOM XOpenOM ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|_XrmHashBucketRec*|*/  arg1, System.IntPtr /*System.SByte*/ arg2, System.IntPtr /*System.SByte*/ arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XCloseOM ( XOM arg0);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|Display*|*/  XDisplayOfOM ( XOM arg0);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*System.SByte*/ XLocaleOfOM ( XOM arg0);
    
    [DllImport(LibPath)]
    public static extern void XDestroyOC ( IntPtr arg0);
    
    [DllImport(LibPath)]
    public static extern XOM XOMOfOC ( IntPtr arg0);
    
    [DllImport(LibPath)]
    public static extern IntPtr XCreateFontSet ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.IntPtr /*System.SByte*/ arg2, System.IntPtr /*System.Int32*/ arg3, System.IntPtr /*System.SByte*/ arg4);
    
    [DllImport(LibPath)]
    public static extern void XFreeFontSet ( System.IntPtr /*|Display*|*/  arg0, IntPtr arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XFontsOfFontSet ( IntPtr arg0, System.IntPtr /*|XFontStruct***|*/  arg1, System.IntPtr /*System.SByte*/ arg2);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*System.SByte*/ XBaseFontNameListOfFontSet ( IntPtr arg0);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*System.SByte*/ XLocaleOfFontSet ( IntPtr arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XContextDependentDrawing ( IntPtr arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XDirectionalDependentDrawing ( IntPtr arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XContextualDrawing ( IntPtr arg0);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|XFontSetExtents*|*/  XExtentsOfFontSet ( IntPtr arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XmbTextEscapement ( IntPtr arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XwcTextEscapement ( IntPtr arg0, System.IntPtr /*|wchar_t*|*/  arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 Xutf8TextEscapement ( IntPtr arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XmbTextExtents ( IntPtr arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2, System.IntPtr /*|XRectangle*|*/  arg3, System.IntPtr /*|XRectangle*|*/  arg4);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XwcTextExtents ( IntPtr arg0, System.IntPtr /*|wchar_t*|*/  arg1, System.Int32 arg2, System.IntPtr /*|XRectangle*|*/  arg3, System.IntPtr /*|XRectangle*|*/  arg4);
    
    [DllImport(LibPath)]
    public static extern System.Int32 Xutf8TextExtents ( IntPtr arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2, System.IntPtr /*|XRectangle*|*/  arg3, System.IntPtr /*|XRectangle*|*/  arg4);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XmbTextPerCharExtents ( IntPtr arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2, System.IntPtr /*|XRectangle*|*/  arg3, System.IntPtr /*|XRectangle*|*/  arg4, System.Int32 arg5, System.IntPtr /*System.Int32*/ arg6, System.IntPtr /*|XRectangle*|*/  arg7, System.IntPtr /*|XRectangle*|*/  arg8);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XwcTextPerCharExtents ( IntPtr arg0, System.IntPtr /*|wchar_t*|*/  arg1, System.Int32 arg2, System.IntPtr /*|XRectangle*|*/  arg3, System.IntPtr /*|XRectangle*|*/  arg4, System.Int32 arg5, System.IntPtr /*System.Int32*/ arg6, System.IntPtr /*|XRectangle*|*/  arg7, System.IntPtr /*|XRectangle*|*/  arg8);
    
    [DllImport(LibPath)]
    public static extern System.Int32 Xutf8TextPerCharExtents ( IntPtr arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2, System.IntPtr /*|XRectangle*|*/  arg3, System.IntPtr /*|XRectangle*|*/  arg4, System.Int32 arg5, System.IntPtr /*System.Int32*/ arg6, System.IntPtr /*|XRectangle*|*/  arg7, System.IntPtr /*|XRectangle*|*/  arg8);
    
    [DllImport(LibPath)]
    public static extern void XmbDrawText ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4, System.IntPtr /*|XmbTextItem*|*/  arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static extern void XwcDrawText ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4, System.IntPtr /*|XwcTextItem*|*/  arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static extern void Xutf8DrawText ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, GC arg2, System.Int32 arg3, System.Int32 arg4, System.IntPtr /*|XmbTextItem*|*/  arg5, System.Int32 arg6);
    
    [DllImport(LibPath)]
    public static extern void XmbDrawString ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, IntPtr arg2, GC arg3, System.Int32 arg4, System.Int32 arg5, System.IntPtr /*System.SByte*/ arg6, System.Int32 arg7);
    
    [DllImport(LibPath)]
    public static extern void XwcDrawString ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, IntPtr arg2, GC arg3, System.Int32 arg4, System.Int32 arg5, System.IntPtr /*|wchar_t*|*/  arg6, System.Int32 arg7);
    
    [DllImport(LibPath)]
    public static extern void Xutf8DrawString ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, IntPtr arg2, GC arg3, System.Int32 arg4, System.Int32 arg5, System.IntPtr /*System.SByte*/ arg6, System.Int32 arg7);
    
    [DllImport(LibPath)]
    public static extern void XmbDrawImageString ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, IntPtr arg2, GC arg3, System.Int32 arg4, System.Int32 arg5, System.IntPtr /*System.SByte*/ arg6, System.Int32 arg7);
    
    [DllImport(LibPath)]
    public static extern void XwcDrawImageString ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, IntPtr arg2, GC arg3, System.Int32 arg4, System.Int32 arg5, System.IntPtr /*|wchar_t*|*/  arg6, System.Int32 arg7);
    
    [DllImport(LibPath)]
    public static extern void Xutf8DrawImageString ( System.IntPtr /*|Display*|*/  arg0, Drawable arg1, IntPtr arg2, GC arg3, System.Int32 arg4, System.Int32 arg5, System.IntPtr /*System.SByte*/ arg6, System.Int32 arg7);
    
    [DllImport(LibPath)]
    public static extern XIM XOpenIM ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|_XrmHashBucketRec*|*/  arg1, System.IntPtr /*System.SByte*/ arg2, System.IntPtr /*System.SByte*/ arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XCloseIM ( XIM arg0);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|Display*|*/  XDisplayOfIM ( XIM arg0);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*System.SByte*/ XLocaleOfIM ( XIM arg0);
    
    [DllImport(LibPath)]
    public static extern void XDestroyIC ( XIC arg0);
    
    [DllImport(LibPath)]
    public static extern void XSetICFocus ( XIC arg0);
    
    [DllImport(LibPath)]
    public static extern void XUnsetICFocus ( XIC arg0);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*|wchar_t*|*/  XwcResetIC ( XIC arg0);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*System.SByte*/ XmbResetIC ( XIC arg0);
    
    [DllImport(LibPath)]
    public static extern System.IntPtr /*System.SByte*/ Xutf8ResetIC ( XIC arg0);
    
    [DllImport(LibPath)]
    public static extern XIM XIMOfIC ( XIC arg0);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XFilterEvent ( System.IntPtr /*|XEvent*|*/  arg0, Window arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XmbLookupString ( XIC arg0, System.IntPtr /*|XKeyPressedEvent*|*/  arg1, System.IntPtr /*System.SByte*/ arg2, System.Int32 arg3, System.IntPtr /*|KeySym*|*/  arg4, System.IntPtr /*System.Int32*/ arg5);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XwcLookupString ( XIC arg0, System.IntPtr /*|XKeyPressedEvent*|*/  arg1, System.IntPtr /*|wchar_t*|*/  arg2, System.Int32 arg3, System.IntPtr /*|KeySym*|*/  arg4, System.IntPtr /*System.Int32*/ arg5);
    
    [DllImport(LibPath)]
    public static extern System.Int32 Xutf8LookupString ( XIC arg0, System.IntPtr /*|XKeyPressedEvent*|*/  arg1, System.IntPtr /*System.SByte*/ arg2, System.Int32 arg3, System.IntPtr /*|KeySym*|*/  arg4, System.IntPtr /*System.Int32*/ arg5);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XRegisterIMInstantiateCallback ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|_XrmHashBucketRec*|*/  arg1, System.IntPtr /*System.SByte*/ arg2, System.IntPtr /*System.SByte*/ arg3, IntPtr arg4, XPointer arg5);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XUnregisterIMInstantiateCallback ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|_XrmHashBucketRec*|*/  arg1, System.IntPtr /*System.SByte*/ arg2, System.IntPtr /*System.SByte*/ arg3, IntPtr arg4, XPointer arg5);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XInternalConnectionNumbers ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*System.Int32*/ arg1, System.IntPtr /*System.Int32*/ arg2);
    
    [DllImport(LibPath)]
    public static extern void XProcessInternalConnection ( System.IntPtr /*|Display*|*/  arg0, System.Int32 arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XAddConnectionWatch ( System.IntPtr /*|Display*|*/  arg0, IntPtr arg1, XPointer arg2);
    
    [DllImport(LibPath)]
    public static extern void XRemoveConnectionWatch ( System.IntPtr /*|Display*|*/  arg0, IntPtr arg1, XPointer arg2);
    
    [DllImport(LibPath)]
    public static extern void XSetAuthorization ( System.IntPtr /*System.SByte*/ arg0, System.Int32 arg1, System.IntPtr /*System.SByte*/ arg2, System.Int32 arg3);
    
    [DllImport(LibPath)]
    public static extern System.Int32 _Xmbtowc ( System.IntPtr /*|wchar_t*|*/  arg0, System.IntPtr /*System.SByte*/ arg1, System.Int32 arg2);
    
    [DllImport(LibPath)]
    public static extern System.Int32 _Xwctomb ( System.IntPtr /*System.SByte*/ arg0, wchar_t arg1);
    
    [DllImport(LibPath)]
    public static extern System.Int32 XGetEventData ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XGenericEventCookie*|*/  arg1);
    
    [DllImport(LibPath)]
    public static extern void XFreeEventData ( System.IntPtr /*|Display*|*/  arg0, System.IntPtr /*|XGenericEventCookie*|*/  arg1);
    
    
    
    
    
    public struct funcs {
    }
    
    [StructLayout(LayoutKind.Explicit)] 
    public struct Type_2_data {
        [FieldOffset(0)] public System.Int32 type;
        [FieldOffset(0)] public System.UInt64 serial;
        [FieldOffset(0)] public System.Int32 send_event;
        [FieldOffset(0)] public System.IntPtr /*|Display*|*/  display;
        [FieldOffset(0)] public Window window;
        [FieldOffset(0)] public Atom message_type;
        [FieldOffset(0)] public System.Int32 format;
        [FieldOffset(0)] public _BUFFER40BYTES l;
    }
    
    [StructLayout(LayoutKind.Explicit)] 
    public struct Type_3_string_ {
        [FieldOffset(0)] public System.UInt16 length;
        [FieldOffset(0)] public System.IntPtr /*|XIMFeedback*|*/  feedback;
        [FieldOffset(0)] public System.Int32 encoding_is_wchar;
        [FieldOffset(0)] public System.IntPtr /*System.SByte*/ multi_byte;
        [FieldOffset(0)] public System.IntPtr /*|wchar_t*|*/  wide_char;
    }
    
    [StructLayout(LayoutKind.Explicit)] 
    public struct Type_4_string_ {
        [FieldOffset(0)] public System.UInt16 length;
        [FieldOffset(0)] public System.IntPtr /*|XIMStringConversionFeedback*|*/  feedback;
        [FieldOffset(0)] public System.Int32 encoding_is_wchar;
        [FieldOffset(0)] public System.IntPtr /*System.SByte*/ mbs;
        [FieldOffset(0)] public System.IntPtr /*|wchar_t*|*/  wcs;
    }
    
    [StructLayout(LayoutKind.Explicit)] 
    public struct Type_5_data {
        [FieldOffset(0)] public int type;
        [FieldOffset(0)] public System.IntPtr /*|XIMText*|*/  text;
        [FieldOffset(0)] public Pixmap bitmap;
    }
    
    
}