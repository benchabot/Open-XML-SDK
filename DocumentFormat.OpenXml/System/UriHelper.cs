﻿namespace System
{
    internal static class UriHelper
    {
        public static readonly UriKind RelativeOrAbsolute = Type.GetType("Mono.Runtime") == null ? UriKind.RelativeOrAbsolute : (UriKind)300;
    }
}
