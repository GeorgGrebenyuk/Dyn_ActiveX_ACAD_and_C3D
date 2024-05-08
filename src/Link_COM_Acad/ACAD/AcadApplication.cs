#region
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using dr = Autodesk.DesignScript.Runtime;

using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.Win32;

#endregion

namespace DynAXDBLib
{
    [dr.IsVisibleInDynamoLibrary(false)]
    public static class Marshal2
    {
        internal const String OLEAUT32 = "oleaut32.dll";
        internal const String OLE32 = "ole32.dll";

        [System.Security.SecurityCritical]  // auto-generated_required
        public static Object GetActiveObject(String progID)
        {
            Object obj = null;
            Guid clsid;

            // Call CLSIDFromProgIDEx first then fall back on CLSIDFromProgID if
            // CLSIDFromProgIDEx doesn't exist.
            try
            {
                CLSIDFromProgIDEx(progID, out clsid);
            }
            //            catch
            catch (Exception)
            {
                CLSIDFromProgID(progID, out clsid);
            }

            GetActiveObject(ref clsid, IntPtr.Zero, out obj);
            return obj;
        }

        //[DllImport(Microsoft.Win32.Win32Native.OLE32, PreserveSig = false)]
        [DllImport(OLE32, PreserveSig = false)]
        [ResourceExposure(ResourceScope.None)]
        [SuppressUnmanagedCodeSecurity]
        [System.Security.SecurityCritical]  // auto-generated
        private static extern void CLSIDFromProgIDEx([MarshalAs(UnmanagedType.LPWStr)] String progId, out Guid clsid);

        //[DllImport(Microsoft.Win32.Win32Native.OLE32, PreserveSig = false)]
        [DllImport(OLE32, PreserveSig = false)]
        [ResourceExposure(ResourceScope.None)]
        [SuppressUnmanagedCodeSecurity]
        [System.Security.SecurityCritical]  // auto-generated
        private static extern void CLSIDFromProgID([MarshalAs(UnmanagedType.LPWStr)] String progId, out Guid clsid);

        //[DllImport(Microsoft.Win32.Win32Native.OLEAUT32, PreserveSig = false)]
        [DllImport(OLEAUT32, PreserveSig = false)]
        [ResourceExposure(ResourceScope.None)]
        [SuppressUnmanagedCodeSecurity]
        [System.Security.SecurityCritical]  // auto-generated
        private static extern void GetActiveObject(ref Guid rclsid, IntPtr reserved, [MarshalAs(UnmanagedType.Interface)] out Object ppunk);

    }
    /// <summary>
    /// Root clas for wotk with AutoCAD application's instance. An instance of the AutoCAD application
    /// </summary>
    public class AcadApplication
    {
        public Autodesk.AutoCAD.Interop.IAcadApplication _i;
        /// <summary>
        /// Use AcadApplicationVersions to get progID data
        /// </summary>
        /// <param name="progID"></param>
        public AcadApplication(string progID)
        {
            var check_app = Marshal2.GetActiveObject(progID) as Autodesk.AutoCAD.Interop.IAcadApplication;
            if (check_app != null) this._i = check_app;
        }
        /// <summary>
        /// Fet acad instance from latest installed version on PC (Non-recommended for use in public-sharing scripts)
        /// </summary>
        public AcadApplication()
        {
            var check_app = Marshal2.GetActiveObject("AutoCAD.Application") as Autodesk.AutoCAD.Interop.IAcadApplication;
            if (check_app != null) this._i = check_app;
        }

        /// <summary>
        /// Get ProgID identificators for AutoCAD 2010-2025. Old versions may be no supported
        /// </summary>
        /// <returns></returns>
        [dr.MultiReturn(new [] { "AutoCAD 2010", "AutoCAD 2011", "AutoCAD 2012", "AutoCAD 2013", "AutoCAD 2014", 
            "AutoCAD 2015", "AutoCAD 2016", "AutoCAD 2017", "AutoCAD 2018", "AutoCAD 2019", 
            "AutoCAD 2020", "AutoCAD 2021", "AutoCAD 2022", "AutoCAD 2023", "AutoCAD 2024", "AutoCAD 2025" })]
        public static Dictionary<string, string> AcadApplicationVersions() => new Dictionary<string, string>()
        {
            {"AutoCAD 2010","AutoCAD.Application.18.0"  },
            {"AutoCAD 2011","AutoCAD.Application.18.1"  },
            {"AutoCAD 2012","AutoCAD.Application.18.2"  },
            {"AutoCAD 2013","AutoCAD.Application.19.0"  },
            {"AutoCAD 2014","AutoCAD.Application.19.1"  },
            {"AutoCAD 2015","AutoCAD.Application.20"  },
            {"AutoCAD 2016","AutoCAD.Application.20"  },
            {"AutoCAD 2017","AutoCAD.Application.21"  },
            {"AutoCAD 2018","AutoCAD.Application.22"  },
            {"AutoCAD 2019","AutoCAD.Application.23"  },
            {"AutoCAD 2020","AutoCAD.Application.23.1"  },
            {"AutoCAD 2021","AutoCAD.Application.24"  },
            {"AutoCAD 2022","AutoCAD.Application.24.1"  },
            {"AutoCAD 2023","AutoCAD.Application.24.2"  },
            {"AutoCAD 2024","AutoCAD.Application.24.3"  },
            {"AutoCAD 2025","AutoCAD.Application.25"  }
        };

        /// <summary>
        /// Updates the object to the drawing screen
        /// </summary>
        public void Update()
        {
            this._i.Update();
        }

        /// <summary>
        /// Gets the text that the user sees displayed for the application or a menu item
        /// </summary>
        public string Caption => this._i.Caption;

        /// <summary>
        /// The Documents collection for the current AutoCAD session
        /// </summary>
        /// <returns></returns>
        public List<AcadDocument> Documents()
        {
            var docs_row = this._i.Documents;
            List<AcadDocument> docs = new List<AcadDocument>();
            for (int i = 0; i < docs_row.Count; i++)
            {
                docs.Add(new AcadDocument(docs_row.Item(i)));
            }
            return docs;

        }
        /// <summary>
        /// Get active drawing if it exists
        /// </summary>
        public AcadDocument ActiveDocument => new AcadDocument(this._i.ActiveDocument);
        public void Set_ActiveDocument(AcadDocument AcadDocument) => this._i.ActiveDocument = AcadDocument._i;
        #region getting_processes_ROT
        //https://stackoverflow.com/questions/7736280/marshal-getactiveobject-throws-mk-e-unavailable-exception-in-c-sharp
        /// <summary>
        /// Get COM processes ID
        /// </summary>
        /// <returns></returns>
        public static List<string> GetCOMProcesses()
        {
            StringBuilder SB = new StringBuilder();
            List<string> processes = new List<string>();
            foreach (var moniker in EnumRunningObjects())
            {
                List<string> t1 = GetMonikerString(moniker).Split('\t').ToList();
                processes = processes.Concat(t1).ToList();
            }
            return processes;
        }
        private const int S_OK = 0x00000000;

        [DllImport("ole32.dll")]
        private static extern int GetRunningObjectTable(uint reserved, out IRunningObjectTable pprot);

        [DllImport("ole32.dll")]
        private static extern int CreateBindCtx(uint reserved, out IBindCtx ppbc);

        private static void OleCheck(string message, int result)
        {
            if (result != S_OK)
                throw new COMException(message, result);
        }

        private static System.Collections.Generic.IEnumerable<IMoniker> EnumRunningObjects()
        {
            IRunningObjectTable objTbl;
            OleCheck("GetRunningObjectTable failed", GetRunningObjectTable(0, out objTbl));
            IEnumMoniker enumMoniker;
            IMoniker[] monikers = new IMoniker[1];
            objTbl.EnumRunning(out enumMoniker);
            enumMoniker.Reset();
            while (enumMoniker.Next(1, monikers, IntPtr.Zero) == S_OK)
            {
                yield return monikers[0];
            }
        }

        private static bool TryGetCLSIDFromDisplayName(string displayName, out string clsid)
        {
            var bBracket = displayName.IndexOf("{");
            var eBracket = displayName.IndexOf("}");
            if ((bBracket > 0) && (eBracket > 0) && (eBracket > bBracket))
            {
                clsid = displayName.Substring(bBracket, eBracket - bBracket + 1);
                return true;
            }
            else
            {
                clsid = string.Empty;
                return false;
            }
        }

        private static string ReadSubKeyValue(string keyName, RegistryKey key)
        {
            var subKey = key.OpenSubKey(keyName);
            if (subKey != null)
            {
                using (subKey)
                {
                    var value = subKey.GetValue("");
                    return value == null ? string.Empty : value.ToString();
                }
            }
            return string.Empty;
        }

        private static string GetMonikerString(IMoniker moniker)
        {
            IBindCtx ctx;
            OleCheck("CreateBindCtx failed", CreateBindCtx(0, out ctx));
            var sb = new StringBuilder();
            string displayName;
            moniker.GetDisplayName(ctx, null, out displayName);
            sb.Append(displayName);
            sb.Append('\t');
            string clsid;
            if (TryGetCLSIDFromDisplayName(displayName, out clsid))
            {
                var regClass = Registry.ClassesRoot.OpenSubKey("\\CLSID\\" + clsid);
                if (regClass != null)
                {
                    using (regClass)
                    {
                        sb.Append(regClass.GetValue(""));
                        sb.Append('\t');
                        sb.Append(ReadSubKeyValue("ProgID", regClass));
                        sb.Append('\t');
                        sb.Append(ReadSubKeyValue("LocalServer32", regClass));
                    }
                }
            }
            return sb.ToString();
        }
        #endregion
    }

}