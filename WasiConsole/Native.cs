﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WasiConsole;

internal static class Native
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern void Print(string input);
}