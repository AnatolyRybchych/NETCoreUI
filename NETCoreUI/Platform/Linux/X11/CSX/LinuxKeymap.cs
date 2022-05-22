using NETCoreUI.Core.Enums;
using NETCoreUI.Platform.Linux.X11.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Linux.X11.CSX
{
    public class LinuxKeymap
    {
        private Key[] map;

        public LinuxKeymap()
        {
            map = new Key[(uint)XKey._XKeyLast];

            map[(uint)XKey.Unknown0] = Key.Unknown;
            map[(uint)XKey.Unknown1] = Key.Unknown;
            map[(uint)XKey.Unknown2] = Key.Unknown;
            map[(uint)XKey.Unknown3] = Key.Unknown;
            map[(uint)XKey.Unknown4] = Key.Unknown;
            map[(uint)XKey.Unknown5] = Key.Unknown;
            map[(uint)XKey.Unknown6] = Key.Unknown;
            map[(uint)XKey.Unknown7] = Key.Unknown;
            map[(uint)XKey.Unknown8] = Key.Unknown;
            map[(uint)XKey.Escape] = Key.Esc;
            map[(uint)XKey.Key1] = Key.Key1;
            map[(uint)XKey.Key2] = Key.Key2;
            map[(uint)XKey.Key3] = Key.Key3;
            map[(uint)XKey.Key4] = Key.Key4;
            map[(uint)XKey.Key5] = Key.Key5;
            map[(uint)XKey.Key6] = Key.Key6;
            map[(uint)XKey.Key7] = Key.Key7;
            map[(uint)XKey.Key8] = Key.Key8;
            map[(uint)XKey.Key9] = Key.Key9;
            map[(uint)XKey.Key0] = Key.Key0;
            map[(uint)XKey.Minus] = Key.Minus;
            map[(uint)XKey.Equal] = Key.Plus;
            map[(uint)XKey.backspace] = Key.Backspace;
            map[(uint)XKey.Tab] = Key.Tab;
            map[(uint)XKey.Q] = Key.Q;
            map[(uint)XKey.W] = Key.W;
            map[(uint)XKey.E] = Key.E;
            map[(uint)XKey.R] = Key.R;
            map[(uint)XKey.T] = Key.T;
            map[(uint)XKey.Y] = Key.Y;
            map[(uint)XKey.U] = Key.U;
            map[(uint)XKey.I] = Key.I;
            map[(uint)XKey.O] = Key.O;
            map[(uint)XKey.P] = Key.P;
            map[(uint)XKey.OpenBracket] = Key.OpenBrackets;
            map[(uint)XKey.CloseBracket] = Key.CloseBrackets;
            map[(uint)XKey.Enter] = Key.Enter;
            map[(uint)XKey.LeftControl] = Key.LeftControl;
            map[(uint)XKey.A] = Key.A;
            map[(uint)XKey.S] = Key.S;
            map[(uint)XKey.D] = Key.D;
            map[(uint)XKey.F] = Key.F;
            map[(uint)XKey.G] = Key.G;
            map[(uint)XKey.H] = Key.H;
            map[(uint)XKey.J] = Key.J;
            map[(uint)XKey.K] = Key.K;
            map[(uint)XKey.L] = Key.L;
            map[(uint)XKey.Colon] = Key.Colon;
            map[(uint)XKey.Quote] = Key.Quotes;
            map[(uint)XKey.Tilda] = Key.Tilda;
            map[(uint)XKey.LeftShift] = Key.LeftShift;
            map[(uint)XKey.Backslah] = Key.Backslash;
            map[(uint)XKey.Z] = Key.Z;
            map[(uint)XKey.X] = Key.X;
            map[(uint)XKey.C] = Key.C;
            map[(uint)XKey.V] = Key.V;
            map[(uint)XKey.B] = Key.B;
            map[(uint)XKey.N] = Key.N;
            map[(uint)XKey.M] = Key.M;
            map[(uint)XKey.LowerThen] = Key.LowerThan;
            map[(uint)XKey.GreaterThan] = Key.GreaterThan;
            map[(uint)XKey.Slash] = Key.Slash;
            map[(uint)XKey.RigthShift] = Key.RightShift;
            map[(uint)XKey.NumpadMultiply] = Key.NumpadMultiply;
            map[(uint)XKey.LeftAlt] = Key.LeftAlt;
            map[(uint)XKey.Unknown65] = Key.Unknown;
            map[(uint)XKey.CapsLock] = Key.CapsLock;
            map[(uint)XKey.F1] = Key.F1;
            map[(uint)XKey.F2] = Key.F2;
            map[(uint)XKey.F3] = Key.F3;
            map[(uint)XKey.F4] = Key.F4;
            map[(uint)XKey.F5] = Key.F5;
            map[(uint)XKey.F6] = Key.F6;
            map[(uint)XKey.F7] = Key.F7;
            map[(uint)XKey.F8] = Key.F8;
            map[(uint)XKey.F9] = Key.F9;
            map[(uint)XKey.F10] = Key.F10;
            map[(uint)XKey.NumLock] = Key.NumpadNumLock;
            map[(uint)XKey.ScrollLock] = Key.ScrollLock;
            map[(uint)XKey.Numpad7] = Key.Numpad7;
            map[(uint)XKey.Numpad8] = Key.Numpad8;
            map[(uint)XKey.Numpad9] = Key.Numpad9;
            map[(uint)XKey.NumpadMinus] = Key.NumpadMinus;
            map[(uint)XKey.Numpad4] = Key.Numpad4;
            map[(uint)XKey.Numpad5] = Key.Numpad5;
            map[(uint)XKey.Numpad6] = Key.Numpad6;
            map[(uint)XKey.NumpadPlus] = Key.NumpadPlus;
            map[(uint)XKey.Numpad1] = Key.Numpad1;
            map[(uint)XKey.Numpad2] = Key.Numpad2;
            map[(uint)XKey.Numpad3] = Key.Numpad3;
            map[(uint)XKey.Numpad0] = Key.Numpad0;
            map[(uint)XKey.NumpadDot] = Key.NumpadDot;
            map[(uint)XKey.Unknown92] = Key.Unknown;
            map[(uint)XKey.Unknown93] = Key.Unknown;
            map[(uint)XKey.Unknown94] = Key.Unknown;
            map[(uint)XKey.F11] = Key.F11;
            map[(uint)XKey.F12] = Key.F12;
            map[(uint)XKey.Unknown97] = Key.Unknown;
            map[(uint)XKey.Unknown98] = Key.Unknown;
            map[(uint)XKey.Unknown99] = Key.Unknown;
            map[(uint)XKey.Unknown100] = Key.Unknown;
            map[(uint)XKey.Unknown101] = Key.Unknown;
            map[(uint)XKey.Unknown102] = Key.Unknown;
            map[(uint)XKey.Unknown103] = Key.Unknown;
            map[(uint)XKey.NumpadEnter] = Key.NumpadEnter;
            map[(uint)XKey.Unknown105] = Key.Unknown;
            map[(uint)XKey.NumpadDivide] = Key.NumpadDivide;
            map[(uint)XKey.Unknown107] = Key.Unknown;
            map[(uint)XKey.Unknown108] = Key.Unknown;
            map[(uint)XKey.Unknown109] = Key.Unknown;
            map[(uint)XKey.Home] = Key.Home;
            map[(uint)XKey.Unknown111] = Key.Unknown;
            map[(uint)XKey.PageUp] = Key.PageUp;
            map[(uint)XKey.Unknown113] = Key.Unknown;
            map[(uint)XKey.Unknown114] = Key.Unknown;
            map[(uint)XKey.End] = Key.End;
            map[(uint)XKey.Unknown116] = Key.Unknown;
            map[(uint)XKey.PadeDown] = Key.PageDown;
            map[(uint)XKey.Insert] = Key.Insert;
            map[(uint)XKey.Delete] = Key.Delete;
            map[(uint)XKey.Unknown120] = Key.Unknown;
            map[(uint)XKey.Unknown121] = Key.Unknown;
            map[(uint)XKey.Unknown122] = Key.Unknown;
            map[(uint)XKey.Unknown123] = Key.Unknown;
            map[(uint)XKey.Unknown124] = Key.Unknown;
            map[(uint)XKey.Unknown125] = Key.Unknown;
            map[(uint)XKey.Unknown126] = Key.Unknown;
            map[(uint)XKey.PauseBreak] = Key.PauseBreak;
            map[(uint)XKey.Unknown128] = Key.Unknown;
            map[(uint)XKey.Unknown129] = Key.Unknown;
            map[(uint)XKey.Unknown130] = Key.Unknown;
            map[(uint)XKey.Unknown131] = Key.Unknown;
            map[(uint)XKey.Unknown132] = Key.Unknown;
            map[(uint)XKey.LeftSuper] = Key.LeftSuper;

        }

        public Key Convert(uint linuxKeyCode)
        {
            if (linuxKeyCode >= (uint)XKey._XKeyLast) return Key.Unknown;
            else return map[linuxKeyCode];
        }
    }
}
