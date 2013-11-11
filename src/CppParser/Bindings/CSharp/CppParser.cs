//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace CppSharp
{
    namespace Parser
    {
        public enum ParserDiagnosticLevel
        {
            Ignored = 0,
            Note = 1,
            Warning = 2,
            Error = 3,
            Fatal = 4
        }

        public enum ParserResultKind
        {
            Success = 0,
            Error = 1,
            FileNotFound = 2
        }

        public enum SourceLocationKind
        {
            Invalid = 0,
            Builtin = 1,
            CommandLine = 2,
            System = 3,
            User = 4
        }

        public unsafe partial class ParserOptions : IDisposable, CppSharp.Runtime.ICppMarshal
        {
            [StructLayout(LayoutKind.Explicit, Size = 112)]
            public struct Internal
            {
                [FieldOffset(0)]
                public Std.String FileName;

                [FieldOffset(24)]
                public Std.Vector IncludeDirs;

                [FieldOffset(36)]
                public Std.Vector SystemIncludeDirs;

                [FieldOffset(48)]
                public Std.Vector Defines;

                [FieldOffset(60)]
                public Std.Vector LibraryDirs;

                [FieldOffset(72)]
                public global::System.IntPtr ASTContext;

                [FieldOffset(76)]
                public int ToolSetToUse;

                [FieldOffset(80)]
                public Std.String TargetTriple;

                [FieldOffset(104)]
                public CppSharp.Parser.AST.CppAbi Abi;

                [FieldOffset(108)]
                public bool NoStandardIncludes;

                [FieldOffset(109)]
                public bool NoBuiltinIncludes;

                [FieldOffset(110)]
                public bool MicrosoftMode;

                [FieldOffset(111)]
                public bool Verbose;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                    EntryPoint="??0ParserOptions@CppParser@CppSharp@@QAE@XZ")]
                public static extern global::System.IntPtr ParserOptions_0(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                    EntryPoint="??0ParserOptions@CppParser@CppSharp@@QAE@ABU012@@Z")]
                public static extern global::System.IntPtr ParserOptions_2(global::System.IntPtr instance, global::System.IntPtr _0);
            }

            public global::System.IntPtr __Instance { get; protected set; }

            int CppSharp.Runtime.ICppMarshal.NativeDataSize
            {
                get { return 112; }
            }

            void CppSharp.Runtime.ICppMarshal.MarshalManagedToNative(global::System.IntPtr instance)
            {
            }

            void CppSharp.Runtime.ICppMarshal.MarshalNativeToManaged(global::System.IntPtr instance)
            {
            }

            internal ParserOptions(ParserOptions.Internal* native)
                : this(new global::System.IntPtr(native))
            {
            }

            internal ParserOptions(ParserOptions.Internal native)
                : this(&native)
            {
            }

            internal ParserOptions(global::System.IntPtr native)
            {
                __Instance = native;
            }

            public ParserOptions()
            {
                __Instance = Marshal.AllocHGlobal(112);
                Internal.ParserOptions_0(__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                Marshal.FreeHGlobal(__Instance);
            }

            public Std.String FileName
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->FileName;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->FileName = new Std.String();
                }
            }

            public Std.Vector<Std.String> IncludeDirs
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return new Std.Vector<Std.String>(__ptr->IncludeDirs);
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->IncludeDirs = value.Internal;
                }
            }

            public Std.Vector<Std.String> SystemIncludeDirs
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return new Std.Vector<Std.String>(__ptr->SystemIncludeDirs);
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->SystemIncludeDirs = value.Internal;
                }
            }

            public Std.Vector<Std.String> Defines
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return new Std.Vector<Std.String>(__ptr->Defines);
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Defines = value.Internal;
                }
            }

            public Std.Vector<Std.String> LibraryDirs
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return new Std.Vector<Std.String>(__ptr->LibraryDirs);
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->LibraryDirs = value.Internal;
                }
            }

            public CppSharp.Parser.AST.ASTContext ASTContext
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    var __copy = new global::System.IntPtr(&__ptr->ASTContext);
                    return new CppSharp.Parser.AST.ASTContext(__copy);
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->ASTContext = value == (CppSharp.Parser.AST.ASTContext) null ? global::System.IntPtr.Zero : value.__Instance;
                }
            }

            public int ToolSetToUse
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->ToolSetToUse;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->ToolSetToUse = value;
                }
            }

            public Std.String TargetTriple
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->TargetTriple;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->TargetTriple = new Std.String();
                }
            }

            public CppSharp.Parser.AST.CppAbi Abi
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->Abi;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Abi = value;
                }
            }

            public bool NoStandardIncludes
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->NoStandardIncludes;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->NoStandardIncludes = value;
                }
            }

            public bool NoBuiltinIncludes
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->NoBuiltinIncludes;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->NoBuiltinIncludes = value;
                }
            }

            public bool MicrosoftMode
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->MicrosoftMode;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->MicrosoftMode = value;
                }
            }

            public bool Verbose
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->Verbose;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Verbose = value;
                }
            }
        }

        public unsafe partial class ParserDiagnostic : IDisposable, CppSharp.Runtime.ICppMarshal
        {
            [StructLayout(LayoutKind.Explicit, Size = 60)]
            public struct Internal
            {
                [FieldOffset(0)]
                public Std.String FileName;

                [FieldOffset(24)]
                public Std.String Message;

                [FieldOffset(48)]
                public CppSharp.Parser.ParserDiagnosticLevel Level;

                [FieldOffset(52)]
                public int LineNumber;

                [FieldOffset(56)]
                public int ColumnNumber;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                    EntryPoint="??0ParserDiagnostic@CppParser@CppSharp@@QAE@XZ")]
                public static extern global::System.IntPtr ParserDiagnostic_1(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                    EntryPoint="??0ParserDiagnostic@CppParser@CppSharp@@QAE@ABU012@@Z")]
                public static extern global::System.IntPtr ParserDiagnostic_2(global::System.IntPtr instance, global::System.IntPtr _0);
            }

            public global::System.IntPtr __Instance { get; protected set; }

            int CppSharp.Runtime.ICppMarshal.NativeDataSize
            {
                get { return 60; }
            }

            void CppSharp.Runtime.ICppMarshal.MarshalManagedToNative(global::System.IntPtr instance)
            {
            }

            void CppSharp.Runtime.ICppMarshal.MarshalNativeToManaged(global::System.IntPtr instance)
            {
            }

            internal ParserDiagnostic(ParserDiagnostic.Internal* native)
                : this(new global::System.IntPtr(native))
            {
            }

            internal ParserDiagnostic(ParserDiagnostic.Internal native)
                : this(&native)
            {
            }

            internal ParserDiagnostic(global::System.IntPtr native)
            {
                __Instance = native;
            }

            public ParserDiagnostic()
            {
                __Instance = Marshal.AllocHGlobal(60);
                Internal.ParserDiagnostic_1(__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                Marshal.FreeHGlobal(__Instance);
            }

            public Std.String FileName
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->FileName;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->FileName = new Std.String();
                }
            }

            public Std.String Message
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->Message;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Message = new Std.String();
                }
            }

            public CppSharp.Parser.ParserDiagnosticLevel Level
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->Level;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Level = value;
                }
            }

            public int LineNumber
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->LineNumber;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->LineNumber = value;
                }
            }

            public int ColumnNumber
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->ColumnNumber;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->ColumnNumber = value;
                }
            }
        }

        public unsafe partial class ParserResult : IDisposable, CppSharp.Runtime.ICppMarshal
        {
            [StructLayout(LayoutKind.Explicit, Size = 24)]
            public struct Internal
            {
                [FieldOffset(0)]
                public CppSharp.Parser.ParserResultKind Kind;

                [FieldOffset(4)]
                public Std.Vector Diagnostics;

                [FieldOffset(16)]
                public global::System.IntPtr ASTContext;

                [FieldOffset(20)]
                public global::System.IntPtr Library;

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                    EntryPoint="??0ParserResult@CppParser@CppSharp@@QAE@XZ")]
                public static extern global::System.IntPtr ParserResult_1(global::System.IntPtr instance);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                    EntryPoint="??0ParserResult@CppParser@CppSharp@@QAE@ABU012@@Z")]
                public static extern global::System.IntPtr ParserResult_2(global::System.IntPtr instance, global::System.IntPtr _0);
            }

            public global::System.IntPtr __Instance { get; protected set; }

            int CppSharp.Runtime.ICppMarshal.NativeDataSize
            {
                get { return 24; }
            }

            void CppSharp.Runtime.ICppMarshal.MarshalManagedToNative(global::System.IntPtr instance)
            {
            }

            void CppSharp.Runtime.ICppMarshal.MarshalNativeToManaged(global::System.IntPtr instance)
            {
            }

            internal ParserResult(ParserResult.Internal* native)
                : this(new global::System.IntPtr(native))
            {
            }

            internal ParserResult(ParserResult.Internal native)
                : this(&native)
            {
            }

            internal ParserResult(global::System.IntPtr native)
            {
                __Instance = native;
            }

            public ParserResult()
            {
                __Instance = Marshal.AllocHGlobal(24);
                Internal.ParserResult_1(__Instance);
            }

            public void Dispose()
            {
                Dispose(disposing: true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                Marshal.FreeHGlobal(__Instance);
            }

            public CppSharp.Parser.ParserResultKind Kind
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return __ptr->Kind;
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Kind = value;
                }
            }

            public Std.Vector<CppSharp.Parser.ParserDiagnostic> Diagnostics
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    return new Std.Vector<CppSharp.Parser.ParserDiagnostic>(__ptr->Diagnostics);
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Diagnostics = value.Internal;
                }
            }

            public CppSharp.Parser.AST.ASTContext ASTContext
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    var __copy = new global::System.IntPtr(&__ptr->ASTContext);
                    return new CppSharp.Parser.AST.ASTContext(__copy);
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->ASTContext = value == (CppSharp.Parser.AST.ASTContext) null ? global::System.IntPtr.Zero : value.__Instance;
                }
            }

            public CppSharp.Parser.AST.NativeLibrary Library
            {
                get
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    var __copy = new global::System.IntPtr(&__ptr->Library);
                    return new CppSharp.Parser.AST.NativeLibrary(__copy);
                }

                set
                {
                    var __ptr = (Internal*)__Instance.ToPointer();
                    __ptr->Library = value == (CppSharp.Parser.AST.NativeLibrary) null ? global::System.IntPtr.Zero : value.__Instance;
                }
            }
        }

        public unsafe partial class ClangParser : IDisposable, CppSharp.Runtime.ICppMarshal
        {
            [StructLayout(LayoutKind.Explicit, Size = 1)]
            public struct Internal
            {
                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.ThisCall,
                    EntryPoint="??0ClangParser@CppParser@CppSharp@@QAE@ABV012@@Z")]
                public static extern global::System.IntPtr ClangParser_1(global::System.IntPtr instance, global::System.IntPtr _0);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="?ParseHeader@ClangParser@CppParser@CppSharp@@SAPAUParserResult@23@PAUParserOptions@23@@Z")]
                public static extern global::System.IntPtr ParseHeader_0(global::System.IntPtr Opts);

                [SuppressUnmanagedCodeSecurity]
                [DllImport("CppSharp.CppParser.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                    EntryPoint="?ParseLibrary@ClangParser@CppParser@CppSharp@@SAPAUParserResult@23@PAUParserOptions@23@@Z")]
                public static extern global::System.IntPtr ParseLibrary_0(global::System.IntPtr Opts);
            }

            public global::System.IntPtr __Instance { get; protected set; }

            int CppSharp.Runtime.ICppMarshal.NativeDataSize
            {
                get { return 0; }
            }

            void CppSharp.Runtime.ICppMarshal.MarshalManagedToNative(global::System.IntPtr instance)
            {
            }

            void CppSharp.Runtime.ICppMarshal.MarshalNativeToManaged(global::System.IntPtr instance)
            {
            }

            internal ClangParser(ClangParser.Internal* native)
                : this(new global::System.IntPtr(native))
            {
            }

            internal ClangParser(ClangParser.Internal native)
                : this(&native)
            {
            }

            internal ClangParser(global::System.IntPtr native)
            {
                __Instance = native;
            }

            public ClangParser()
            {
                __Instance = Marshal.AllocHGlobal(1);
            }

            public void Dispose()
            {
                Dispose(disposing: true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                Marshal.FreeHGlobal(__Instance);
            }

            public static CppSharp.Parser.ParserResult ParseHeader(CppSharp.Parser.ParserOptions Opts)
            {
                var arg0 = Opts == (CppSharp.Parser.ParserOptions) null ? global::System.IntPtr.Zero : Opts.__Instance;
                var __ret = Internal.ParseHeader_0(arg0);
                if (__ret == global::System.IntPtr.Zero) return null;
                return new CppSharp.Parser.ParserResult(__ret);
            }

            public static CppSharp.Parser.ParserResult ParseLibrary(CppSharp.Parser.ParserOptions Opts)
            {
                var arg0 = Opts == (CppSharp.Parser.ParserOptions) null ? global::System.IntPtr.Zero : Opts.__Instance;
                var __ret = Internal.ParseLibrary_0(arg0);
                if (__ret == global::System.IntPtr.Zero) return null;
                return new CppSharp.Parser.ParserResult(__ret);
            }
        }
    }
}
