﻿// Learn more about F# at http://fsharp.net

module Library1

    open System.Runtime.CompilerServices

    [<MethodImplAttribute(MethodImplOptions.ForwardRef)>]
    extern int Square(int number)
